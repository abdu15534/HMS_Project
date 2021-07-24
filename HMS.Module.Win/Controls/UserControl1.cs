using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using System.Windows.Forms;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.Win.Controls
{
    public partial class UserControl1 : UserControl, IComplexControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private IObjectSpace objectSpace;
        void IComplexControl.Setup(IObjectSpace objectSpace, XafApplication application)
        {
            gridControl1.DataSource = objectSpace.GetObjects<StockProduct>();
            this.objectSpace = objectSpace;
        }
        void IComplexControl.Refresh()
        {
            gridControl1.DataSource = objectSpace.GetObjects<StockProduct>();
        }

        private void gridControl1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
