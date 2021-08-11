﻿
namespace HMS.Module.Win.Controllers
{
    partial class DataImportController
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
            this.AddDepartmentsServices = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.AddXrayServices = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.AddTests = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // AddDepartmentsServices
            // 
            this.AddDepartmentsServices.Caption = "اظافة خدمات الاقسام";
            this.AddDepartmentsServices.ConfirmationMessage = null;
            this.AddDepartmentsServices.Id = "AddDepartmentsServices";
            this.AddDepartmentsServices.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Service);
            this.AddDepartmentsServices.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.AddDepartmentsServices.ToolTip = null;
            this.AddDepartmentsServices.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.AddDepartmentsServices.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleAction1_Execute);
            // 
            // AddXrayServices
            // 
            this.AddXrayServices.Caption = "اظافة خدمات الاشعة";
            this.AddXrayServices.ConfirmationMessage = null;
            this.AddXrayServices.Id = "XrayServices";
            this.AddXrayServices.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Service);
            this.AddXrayServices.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.AddXrayServices.ToolTip = null;
            this.AddXrayServices.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.AddXrayServices.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AddXrayServices_Execute);
            // 
            // AddTests
            // 
            this.AddTests.Caption = "اظافة التحاليل";
            this.AddTests.ConfirmationMessage = null;
            this.AddTests.Id = "AddTests";
            this.AddTests.TargetObjectType = typeof(XafDataModel.Module.BusinessObjects.test2.Service);
            this.AddTests.TargetViewType = DevExpress.ExpressApp.ViewType.ListView;
            this.AddTests.ToolTip = null;
            this.AddTests.TypeOfView = typeof(DevExpress.ExpressApp.ListView);
            this.AddTests.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.AddTests_Execute);
            // 
            // DataImportController
            // 
            this.Actions.Add(this.AddDepartmentsServices);
            this.Actions.Add(this.AddXrayServices);
            this.Actions.Add(this.AddTests);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction AddDepartmentsServices;
        private DevExpress.ExpressApp.Actions.SimpleAction AddXrayServices;
        private DevExpress.ExpressApp.Actions.SimpleAction AddTests;
    }
}