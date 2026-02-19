using System.Windows.Forms;

namespace mart_management
{
    /// <summary>
    /// State Pattern: Interface for sale/order lifecycle states.
    /// Each state determines what actions are allowed.
    /// </summary>
    public interface IOrderState
    {
        string StateName { get; }
        void AddItem(OrderContext context);
        void Confirm(OrderContext context);
        void Complete(OrderContext context);
        void Cancel(OrderContext context);
    }

    /// <summary>
    /// State machine context: Holds the current state and delegates actions.
    /// </summary>
    public class OrderContext
    {
        public IOrderState CurrentState { get; set; }

        public OrderContext()
        {
            CurrentState = new DraftState();
        }

        public void AddItem() => CurrentState.AddItem(this);
        public void Confirm() => CurrentState.Confirm(this);
        public void Complete() => CurrentState.Complete(this);
        public void Cancel() => CurrentState.Cancel(this);

        public void TransitionTo(IOrderState newState)
        {
            CurrentState = newState;
        }
    }

    /// <summary>
    /// Draft State: The order is being built. Items can be added.
    /// Can transition to Confirmed or Cancelled.
    /// </summary>
    public class DraftState : IOrderState
    {
        public string StateName => "Draft";

        public void AddItem(OrderContext context)
        {
            // Allowed in Draft state — handled by the form
        }

        public void Confirm(OrderContext context)
        {
            context.TransitionTo(new ConfirmedState());
            MessageBox.Show("Order confirmed successfully.", "State Change",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Complete(OrderContext context)
        {
            MessageBox.Show("Cannot complete an order that hasn't been confirmed yet.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Cancel(OrderContext context)
        {
            context.TransitionTo(new CancelledState());
            MessageBox.Show("Order has been cancelled.", "State Change",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Confirmed State: Order is locked. No more item changes.
    /// Can transition to Completed or Cancelled.
    /// </summary>
    public class ConfirmedState : IOrderState
    {
        public string StateName => "Confirmed";

        public void AddItem(OrderContext context)
        {
            MessageBox.Show("Cannot add items to a confirmed order.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Confirm(OrderContext context)
        {
            MessageBox.Show("Order is already confirmed.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Complete(OrderContext context)
        {
            context.TransitionTo(new CompletedState());
            MessageBox.Show("Order completed and saved successfully.", "State Change",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Cancel(OrderContext context)
        {
            context.TransitionTo(new CancelledState());
            MessageBox.Show("Confirmed order has been cancelled.", "State Change",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    /// <summary>
    /// Completed State: Final state. No further changes allowed.
    /// </summary>
    public class CompletedState : IOrderState
    {
        public string StateName => "Completed";

        public void AddItem(OrderContext context)
        {
            MessageBox.Show("Cannot modify a completed order.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Confirm(OrderContext context)
        {
            MessageBox.Show("Order is already completed.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Complete(OrderContext context)
        {
            MessageBox.Show("Order is already completed.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Cancel(OrderContext context)
        {
            MessageBox.Show("Cannot cancel a completed order.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    /// <summary>
    /// Cancelled State: Terminal state. No further changes allowed.
    /// </summary>
    public class CancelledState : IOrderState
    {
        public string StateName => "Cancelled";

        public void AddItem(OrderContext context)
        {
            MessageBox.Show("Cannot modify a cancelled order.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Confirm(OrderContext context)
        {
            MessageBox.Show("Cannot confirm a cancelled order.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Complete(OrderContext context)
        {
            MessageBox.Show("Cannot complete a cancelled order.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Cancel(OrderContext context)
        {
            MessageBox.Show("Order is already cancelled.",
                "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
