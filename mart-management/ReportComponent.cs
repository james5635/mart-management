namespace mart_management
{
    /// <summary>
    /// Composite Pattern: Uniform interface for both individual 
    /// report items (leaf) and groups of items (composite).
    /// </summary>
    public interface IReportComponent
    {
        string Title { get; }
        string Render(int indent = 0);
        double GetTotal();
    }

    /// <summary>
    /// Leaf node: Represents a single report line item (e.g., one sale detail).
    /// </summary>
    public class ReportLeaf : IReportComponent
    {
        public string Title { get; }
        private readonly double _amount;

        public ReportLeaf(string title, double amount)
        {
            Title = title;
            _amount = amount;
        }

        public string Render(int indent = 0)
        {
            string pad = new string(' ', indent * 2);
            return $"{pad}- {Title}: ${_amount:F2}";
        }

        public double GetTotal() => _amount;
    }

    /// <summary>
    /// Composite node: Contains child components (both leaves and other composites).
    /// Represents a group like "Category" or "Product" in the report hierarchy.
    /// </summary>
    public class ReportComposite : IReportComponent
    {
        public string Title { get; }
        private readonly List<IReportComponent> _children = new List<IReportComponent>();

        public ReportComposite(string title)
        {
            Title = title;
        }

        public void Add(IReportComponent component)
        {
            _children.Add(component);
        }

        public void Remove(IReportComponent component)
        {
            _children.Remove(component);
        }

        public IReadOnlyList<IReportComponent> GetChildren() => _children.AsReadOnly();

        public string Render(int indent = 0)
        {
            string pad = new string(' ', indent * 2);
            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"{pad}+ {Title} (Total: ${GetTotal():F2})");
            foreach (var child in _children)
            {
                sb.AppendLine(child.Render(indent + 1));
            }
            return sb.ToString().TrimEnd();
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var child in _children)
            {
                total += child.GetTotal();
            }
            return total;
        }
    }
}
