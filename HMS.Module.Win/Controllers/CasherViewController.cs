using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class CasherViewController : ViewController
    {
        public CasherViewController()
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

        private void Paid_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var test = View.CurrentObject as Test;
            test.Paid = true;
            var accRoomStay = ObjectSpace.CreateObject<JournalDetails>();
            accRoomStay.account = ObjectSpace.FindObject<Account>(new BinaryOperator("accountNumber", "401060009"));
            accRoomStay.credit = test.TestDetailsCollection.Sum(p => p.price);
            accRoomStay.statement = $"تحليل برقم : {test.id} للسادة / {test.Patient.FullName}";
            accRoomStay.journal = test.journal;
            test.journal.Post(false);
            test.Save();
        }

        private void CanclePyment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var test = View.CurrentObject as Test;
            test.Paid = false;
            test.journal.Post(true);
            //test.journal.Delete();


        }

        private void XrayPaid_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var xray = View.CurrentObject as Xrays;
            xray.Paid = true;
            var accRoomStay = ObjectSpace.CreateObject<JournalDetails>();
            accRoomStay.account = ObjectSpace.FindObject<Account>(new BinaryOperator("accountNumber", "401060012"));
            accRoomStay.credit = xray.XraysDetailsCollection.Sum(p => p.price);
            accRoomStay.statement = $"اشعة برقم : {xray.id} للسادة / {xray.Patient.FullName}";
            accRoomStay.journal = xray.journal;
            xray.journal.Post(false);
            xray.Save();
        }

        private void XrayCanclePayment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var xray = View.CurrentObject as Xrays;
            xray.Paid = false;
            xray.journal.Post(true);
            //xray.journal.Delete();
        }

        private void EndscopePaid_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var endscope = View.CurrentObject as Endscope;
            endscope.Paid = true;
            var accRoomStay = ObjectSpace.CreateObject<JournalDetails>();
            accRoomStay.account = ObjectSpace.FindObject<Account>(new BinaryOperator("accountNumber", "401060014"));
            accRoomStay.credit = endscope.EndscopeDetailsCollection.Sum(p => p.price);
            accRoomStay.statement = $"اشعة برقم : {endscope.id} للسادة / {endscope.Patient.FullName}";
            accRoomStay.journal = endscope.journal;
            endscope.journal.Post(false);
            endscope.Save();
        }

        private void EndscopeCanclePayment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var endscope = View.CurrentObject as Endscope;
            endscope.Paid = false;
            endscope.journal.Post(true);
            //xray.journal.Delete();
        }
    }
}
