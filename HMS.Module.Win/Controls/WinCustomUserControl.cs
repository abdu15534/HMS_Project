using System;
using DevExpress.Xpo;
using DevExpress.Utils;
using System.Collections;
using HMS.Module.Editors;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using System.Drawing;
using System.Windows.Forms;
using XafDataModel.Module.BusinessObjects.test2;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.Editors;

namespace HMS.Module.Win.Controls
{
    /// <summary>
    /// This is a custom WinForms user control that displays persistent data received from XPO.
    /// You do not need to implement the IXpoSessionAwareControl interface if your control gets data from other sources or does not require data at all.
    /// </summary>
    public partial class WinCustomUserControl : DevExpress.XtraEditors.XtraUserControl, IXpoSessionAwareControl, IComplexControl
    {
        //Image myBackgroundImage = Image.FromFile("background.jpg");

        public WinCustomUserControl()
        {
            InitializeComponent();
            //this.BackgroundImage = myBackgroundImage;
            
        }
        //private IObjectSpace objectSpace;
        void IXpoSessionAwareControl.UpdateDataSource(Session session)
        {
            Guard.ArgumentNotNull(session, "session");
            Type persistentDataType = typeof(DevExpress.Persistent.BaseImpl.Task);
            IList persistentData = new XPCollection(session, persistentDataType, CriteriaOperator.Parse("Status = 'NotStarted'"));

        }
        private IObjectSpace objectSpace;
        void IComplexControl.Setup(IObjectSpace objectSpace, XafApplication application)
        {
            //gridControl1.DataSource = objectSpace.GetObjects<EFDemo.Module.Data.DemoTask>();
            this.objectSpace = objectSpace;
        }

        private void WinCustomUserControl_Load(object sender, EventArgs e)
        {
            //this.BackgroundImage = myBackgroundImage;
        }
        private void WinCustomUserControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //var s = objectSpace.GetObjects<Patient>();
                MessageBox.Show("Enter key pressed");
                //Console.WriteLine(s);
                //Session.

            }
            if (e.KeyChar == 13)
            {
                MessageBox.Show("Enter key pressed");
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.DrawImage(myBackgroundImage, this.Size.Width, this.Size.Height, new Rectangle(0, 0, myBackgroundImage.Width, myBackgroundImage.Height), GraphicsUnit.Pixel);
        }
    }
}
