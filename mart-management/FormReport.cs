using Microsoft.EntityFrameworkCore;

namespace mart_management
{
    /// <summary>
    /// FormReport demonstrates the Composite Pattern by building a
    /// hierarchical sales report (Category → Product → Sale Details)
    /// using IReportComponent, ReportLeaf, and ReportComposite.
    /// </summary>
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
            BuildReport();
        }

        private void BuildReport()
        {
            // Use Singleton to get database context
            using var db = DatabaseManager.Instance.CreateContext();

            // Build the root composite node
            var root = new ReportComposite("Sales Report - All Categories");

            // Load all sale details with product and category info
            var saleDetails = db.SaleDetails
                .Include(sd => sd.Product)
                .ThenInclude(p => p.Category)
                .Include(sd => sd.Sale)
                .ToList();

            // Group by Category → Product → individual sale details
            var categoryGroups = saleDetails
                .Where(sd => sd.Product?.Category != null)
                .GroupBy(sd => sd.Product.Category.CategoryName);

            foreach (var catGroup in categoryGroups)
            {
                // Composite node for each category
                var categoryNode = new ReportComposite($"Category: {catGroup.Key}");

                var productGroups = catGroup.GroupBy(sd => sd.Product.ProductName);
                foreach (var prodGroup in productGroups)
                {
                    // Composite node for each product
                    var productNode = new ReportComposite($"Product: {prodGroup.Key}");

                    foreach (var detail in prodGroup)
                    {
                        // Leaf node for each sale detail
                        var leaf = new ReportLeaf(
                            $"Sale #{detail.SaleID} — Qty: {detail.Quantity} × ${detail.UnitPrice:F2}",
                            detail.Subtotal
                        );
                        productNode.Add(leaf);
                    }

                    categoryNode.Add(productNode);
                }

                root.Add(categoryNode);
            }

            // Populate the TreeView from the composite structure
            PopulateTreeView(root);

            // Render the text report
            TxtReportOutput.Text = root.Render();
        }

        private void PopulateTreeView(IReportComponent component)
        {
            TvReport.BeginUpdate();
            TvReport.Nodes.Clear();

            if (component is ReportComposite rootComposite)
            {
                var rootNode = new TreeNode($"{rootComposite.Title} (Total: ${rootComposite.GetTotal():F2})");
                AddChildNodes(rootNode, rootComposite);
                TvReport.Nodes.Add(rootNode);
            }

            TvReport.ExpandAll();
            TvReport.EndUpdate();
        }

        private void AddChildNodes(TreeNode parentTreeNode, ReportComposite composite)
        {
            foreach (var child in composite.GetChildren())
            {
                if (child is ReportComposite childComposite)
                {
                    var childTreeNode = new TreeNode($"{childComposite.Title} (${childComposite.GetTotal():F2})");
                    AddChildNodes(childTreeNode, childComposite);
                    parentTreeNode.Nodes.Add(childTreeNode);
                }
                else if (child is ReportLeaf leaf)
                {
                    parentTreeNode.Nodes.Add(new TreeNode($"{leaf.Title}: ${leaf.GetTotal():F2}"));
                }
            }
        }
    }
}
