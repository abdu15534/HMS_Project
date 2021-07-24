using System;
using DevExpress.Xpo;
using HMS.Module.Editors;

namespace HMS.Win.Controls
{
    public partial class WinCustomForm : DevExpress.XtraEditors.XtraForm
    {
        public WinCustomForm()
        {
            InitializeComponent();
        }

        public IXpoSessionAwareControl CustomUserControl { get; private set; }

        public void UpdateDataSource(Session session)
        {
            //Initializing a child control when it is not created by XAF (placed on a custom form).
            ((IXpoSessionAwareControl)this.CustomUserControl).UpdateDataSource(session);
        }
    }
}