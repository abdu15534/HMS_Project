using System;
using DevExpress.Xpo;
using DevExpress.Utils;
using System.Collections;
using HMS.Module.Editors;
using System.Collections.Generic;
using DevExpress.Data.Filtering;
using System.Drawing;
using System.Windows.Forms;

namespace HMS.Module.Win.Controls
{
    /// <summary>
    /// This is a custom WinForms user control that displays persistent data received from XPO.
    /// You do not need to implement the IXpoSessionAwareControl interface if your control gets data from other sources or does not require data at all.
    /// </summary>
    public partial class WinCustomUserControl : DevExpress.XtraEditors.XtraUserControl, IXpoSessionAwareControl
    {
        Image myBackgroundImage = Image.FromFile("background.jpg");

        public WinCustomUserControl()
        {
            InitializeComponent();
            this.BackgroundImage = myBackgroundImage;
            
        }
        void IXpoSessionAwareControl.UpdateDataSource(Session session)
        {
            Guard.ArgumentNotNull(session, "session");
            Type persistentDataType = typeof(DevExpress.Persistent.BaseImpl.Task);
            IList persistentData = new XPCollection(session, persistentDataType, CriteriaOperator.Parse("Status = 'NotStarted'"));

        }

        private void WinCustomUserControl_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = myBackgroundImage;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawImage(myBackgroundImage, this.Size.Width, this.Size.Height, new Rectangle(0, 0, myBackgroundImage.Width, myBackgroundImage.Height), GraphicsUnit.Pixel);
        }
    }
}
