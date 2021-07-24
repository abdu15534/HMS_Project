
using DevExpress.ExpressApp.Actions;
using System;

namespace HMS.Module.Win.Controllers
{
    partial class PaymentReportController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PaymentInvoice = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PaymentCheck = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.AccountsSheet = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PeriodExpenes = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.PriceListRequest = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.DelayedPurchases = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.DelayedPurchases2 = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // PaymentInvoice
            // 
            this.PaymentInvoice.Caption = "Payment Invoice";
            this.PaymentInvoice.ConfirmationMessage = null;
            this.PaymentInvoice.Id = "PaymentInvoice";
            this.PaymentInvoice.ImageName = "BO_Invoice";
            this.PaymentInvoice.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Payments);
            this.PaymentInvoice.ToolTip = null;
            this.PaymentInvoice.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentInvoice_Execute);
            // 
            // PaymentCheck
            // 
            this.PaymentCheck.Caption = "PaymentCheck";
            this.PaymentCheck.ConfirmationMessage = null;
            this.PaymentCheck.Id = "PaymentCheck";
            this.PaymentCheck.ImageName = "BO_Invoice";
            this.PaymentCheck.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Payments);
            this.PaymentCheck.ToolTip = null;
            this.PaymentCheck.TypeOfView = typeof(DevExpress.ExpressApp.View);
            this.PaymentCheck.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PaymentCheck_Execute);
            // 
            // AccountsSheet
            // 
            this.AccountsSheet.Caption = "AccountsSheet";
            this.AccountsSheet.ConfirmationMessage = null;
            this.AccountsSheet.Id = "AccountsSheet";
            this.AccountsSheet.ImageName = "BO_Invoice";
            this.AccountsSheet.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.receiptClientBond);
            this.AccountsSheet.ToolTip = null;
            this.AccountsSheet.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AccountsSheet_Execute);
            // 
            // PeriodExpenes
            // 
            this.PeriodExpenes.Caption = "Period Expenes";
            this.PeriodExpenes.ConfirmationMessage = null;
            this.PeriodExpenes.Id = "PeriodExpenes";
            this.PeriodExpenes.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Spendings);
            this.PeriodExpenes.ToolTip = null;
            this.PeriodExpenes.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PeriodExpenes_Execute);
            // 
            // PriceListRequest
            // 
            this.PriceListRequest.Caption = "Price List Request";
            this.PriceListRequest.ConfirmationMessage = null;
            this.PriceListRequest.Id = "PriceListRequest";
            this.PriceListRequest.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchasingOrder);
            this.PriceListRequest.ToolTip = null;
            this.PriceListRequest.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.PriceListRequest_Execute);
            // 
            // DelayedPurchases
            // 
            this.DelayedPurchases.Caption = "Delayed Purchases";
            this.DelayedPurchases.ConfirmationMessage = null;
            this.DelayedPurchases.Id = "DelayedPurchases";
            this.DelayedPurchases.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Supplier);
            this.DelayedPurchases.ToolTip = null;
            this.DelayedPurchases.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DelayedPurchases_Execute);
            // 
            // DelayedPurchases2
            // 
            this.DelayedPurchases2.Caption = "Another Delayed Purchases ";
            this.DelayedPurchases2.ConfirmationMessage = null;
            this.DelayedPurchases2.Id = "DelayedPurchases2";
            this.DelayedPurchases2.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.PurchasingOrder);
            this.DelayedPurchases2.ToolTip = null;
            this.DelayedPurchases2.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.DelayedPurchases2_Execute);
            // 
            // PaymentReportController
            // 
            this.Actions.Add(this.PaymentInvoice);
            this.Actions.Add(this.PaymentCheck);
            this.Actions.Add(this.AccountsSheet);
            this.Actions.Add(this.PeriodExpenes);
            this.Actions.Add(this.PriceListRequest);
            this.Actions.Add(this.DelayedPurchases);
            this.Actions.Add(this.DelayedPurchases2);

        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction PaymentInvoice;
        private DevExpress.ExpressApp.Actions.SimpleAction PaymentCheck;
        private DevExpress.ExpressApp.Actions.SimpleAction AccountsSheet;
        private SimpleAction PeriodExpenes;
        private SimpleAction PriceListRequest;
        private SimpleAction DelayedPurchases;
        private SimpleAction DelayedPurchases2;
    }
}
