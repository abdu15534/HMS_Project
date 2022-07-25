using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class AccountsController : ViewController
    {
        public AccountsController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void Transfer_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            AccountTransfers transfer = (AccountTransfers)e.CurrentObject;
            transfer.toAccount.credit = transfer.toAccount.credit + transfer.amount;
            transfer.fromAccount.debit = transfer.fromAccount.debit + transfer.amount;
            transfer.Transferd = true;

        }

        private void CancelTransfer_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            AccountTransfers transfer = (AccountTransfers)e.CurrentObject;
            transfer.toAccount.credit = transfer.toAccount.credit - transfer.amount;
            transfer.fromAccount.debit = transfer.fromAccount.debit - transfer.amount;
            transfer.Transferd = false;
        }
    }
}
