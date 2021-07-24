
namespace HMS.Module.Controllers
{
    partial class DataBaseController
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
            this.BackUpDataBase = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.RestoreDatabase = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // BackUpDataBase
            // 
            this.BackUpDataBase.Caption = "عمل نسخة احتياطية من قاعدة البيانات";
            this.BackUpDataBase.ConfirmationMessage = null;
            this.BackUpDataBase.Id = "BackUpDataBase";
            this.BackUpDataBase.ImageName = "BO_UNKNOWN";
            this.BackUpDataBase.TargetViewId = "StandardFormWithCustomUserControl";
            this.BackUpDataBase.ToolTip = null;
            this.BackUpDataBase.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.BackUpDataBase_Execute);
            // 
            // RestoreDatabase
            // 
            this.RestoreDatabase.Caption = "استعادة نسخة احتياطية من قاعدة البيانات";
            this.RestoreDatabase.ConfirmationMessage = null;
            this.RestoreDatabase.Id = "RestoreDatabase";
            this.RestoreDatabase.ImageName = "BO_UNKNOWN";
            this.RestoreDatabase.TargetViewId = "StandardFormWithCustomUserControl";
            this.RestoreDatabase.ToolTip = null;
            this.RestoreDatabase.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.RestoreDatabase_Execute);
            // 
            // DataBaseController
            // 
            this.Actions.Add(this.BackUpDataBase);
            this.Actions.Add(this.RestoreDatabase);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction BackUpDataBase;
        private DevExpress.ExpressApp.Actions.SimpleAction RestoreDatabase;
    }
}
