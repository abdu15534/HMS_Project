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
    public partial class LabsViewController : ViewController
    {
        public LabsViewController()
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

        private void TestComplete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var test = View.CurrentObject as Test;
            test.Complete = true;
            test.Save();
        }

        private void TestBacktrack_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var test = View.CurrentObject as Test;
            test.Complete = false;
            test.Save();
        }

        private void XrayComplete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var xrays = View.CurrentObject as Xrays;
            xrays.Complete = true;
            xrays.Save();
        }

        private void XrayBacktrack_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var xrays = View.CurrentObject as Xrays;
            xrays.Complete = false;
            xrays.Save();
        }

        private void EndscopeComplete_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var endscope = View.CurrentObject as Endscope;
            endscope.Complete = true;
            endscope.Save();
        }

        private void EndscopeBacktrack_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            var endscope = View.CurrentObject as Endscope;
            endscope.Complete = false;
            endscope.Save();
        }
    }
}
