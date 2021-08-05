using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.BaseImpl.PermissionPolicy;
using DevExpress.Persistent.Validation;
using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Win.SystemModule;

namespace HMS.Module.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class AuthViewController : ViewController
    {
        const string keyCustomize = "Customize";
        public AuthViewController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        BarButtonItem newActionBarButtonItem;
        SingleChoiceAction newObjectAction;
        protected override void OnActivated()
        {
            base.OnActivated();
            NewObjectViewController.DefaultNewObjectActionItemListMode = NewObjectActionItemListMode.Default;
            foreach (PermissionPolicyRole role in ((PermissionPolicyUser)SecuritySystem.CurrentUser).Roles)
            {
   
                //detailView.AllowNew[keyCustomize] = false;
                //detailView.AllowEdit[keyCustomize] = false;
                //detailView.AllowDelete[keyCustomize] = false;
                if (role.Name != "Administrators" && role.Name != "Manager")
                {
                    var detailView = View;
                    detailView.AllowDelete[keyCustomize] = false; 
                }
            }
            //WinNewObjectViewController newObjectViewController = Frame.GetController<WinNewObjectViewController>();
            //if (newObjectViewController != null)
            //{
            //    newObjectAction = newObjectViewController.NewObjectAction;
            //    newObjectAction.CustomizeControl += NewObjectAction_CustomizeControl;
            //    newObjectAction.ItemsChanged += NewObjectAction_ItemsChanged;
            //}
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
            //if (newObjectAction != null)
            //{
            //    newObjectAction.CustomizeControl -= NewObjectAction_CustomizeControl;
            //    newObjectAction.ItemsChanged -= NewObjectAction_ItemsChanged;
            //    newObjectAction = null;
            //    newActionBarButtonItem = null;
            //}
        }

        //private void NewObjectAction_ItemsChanged(object sender, ItemsChangedEventArgs e)
        //{
        //    AdjustAction();
        //    //newActionBarButtonItem = e.ChangedItemsInfo as BarButtonItem;
        //    //CustomizeNewButton(newActionBarButtonItem);
        //}
        //private void NewObjectAction_CustomizeControl(object sender, CustomizeControlEventArgs e)
        //{
        //    newActionBarButtonItem = e.Control as BarButtonItem;
        //    AdjustAction();
        //    //CustomizeNewButton(newActionBarButtonItem);
        //}
        //private void AdjustAction()
        //{
        //    if (newActionBarButtonItem != null)
        //    {
        //        int visibleChoicesCount = 0;
        //        foreach (var item in newObjectAction.Items)
        //        {
        //            if (item.Active && item.Enabled)
        //            {
        //                visibleChoicesCount++;
        //            }
        //        }
        //        if (visibleChoicesCount == 1)
        //        {
        //            newActionBarButtonItem.ButtonStyle = BarButtonStyle.Default;
        //        }
        //    }
        //}
        //private void CustomizeNewButton(BarButtonItem item)
        //{
        //    //bool actAsDropdown = newAction.Items.Count > 1;
        //    //if (actAsDropdown)
        //    //{
        //    //item.ButtonStyle = BarButtonStyle.DropDown;
        //    //item.ActAsDropDown = true;
        //    //item.AllowDrawArrow = false;
        //    //}
        //    //else
        //    //{
        //    item.ButtonStyle = BarButtonStyle.Default;
        //    item.ActAsDropDown = false;
        //    //}
        //}
    }
}
