using System.Windows.Forms;

namespace mart_management
{
    /// <summary>
    /// Strategy Pattern: Interface for interchangeable payment methods.
    /// Each strategy encapsulates its own payment processing logic.
    /// </summary>
    public interface IPaymentStrategy
    {
        string MethodName { get; }
        bool ProcessPayment(double amount);
        string GetReceipt(double amount);
    }

    /// <summary>
    /// Concrete Strategy: Cash payment processing.
    /// </summary>
    public class CashPayment : IPaymentStrategy
    {
        public string MethodName => "Cash";

        public bool ProcessPayment(double amount)
        {
            // Cash payment is always accepted
            return true;
        }

        public string GetReceipt(double amount)
        {
            return $"[CASH RECEIPT]\nAmount Paid: ${amount:F2}\nPayment Method: Cash\nStatus: Completed";
        }

        public override string ToString() => MethodName;
    }

    /// <summary>
    /// Concrete Strategy: Card payment processing.
    /// </summary>
    public class CardPayment : IPaymentStrategy
    {
        public string MethodName => "Card";

        public bool ProcessPayment(double amount)
        {
            // Simulate card processing — succeeds for amounts > 0
            if (amount <= 0)
            {
                MessageBox.Show("Card payment requires a positive amount.",
                    "Card Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public string GetReceipt(double amount)
        {
            return $"[CARD RECEIPT]\nAmount Charged: ${amount:F2}\nPayment Method: Credit/Debit Card\nStatus: Approved";
        }

        public override string ToString() => MethodName;
    }

    /// <summary>
    /// Concrete Strategy: Bank transfer payment processing.
    /// </summary>
    public class TransferPayment : IPaymentStrategy
    {
        public string MethodName => "Transfer";

        public bool ProcessPayment(double amount)
        {
            // Simulate transfer processing — succeeds for amounts > 0
            if (amount <= 0)
            {
                MessageBox.Show("Transfer requires a positive amount.",
                    "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public string GetReceipt(double amount)
        {
            return $"[TRANSFER RECEIPT]\nAmount Transferred: ${amount:F2}\nPayment Method: Bank Transfer\nStatus: Processed";
        }

        public override string ToString() => MethodName;
    }

    /// <summary>
    /// Context class: Uses the selected payment strategy to process payments.
    /// </summary>
    public class PaymentProcessor
    {
        private IPaymentStrategy? _strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public IPaymentStrategy? GetStrategy() => _strategy;

        public bool Process(double amount)
        {
            if (_strategy == null)
            {
                MessageBox.Show("Please select a payment method first.",
                    "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return _strategy.ProcessPayment(amount);
        }

        public string GetReceipt(double amount)
        {
            if (_strategy == null) return "No payment method selected.";
            return _strategy.GetReceipt(amount);
        }
    }
}
