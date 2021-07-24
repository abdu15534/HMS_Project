//using DevExpress.Data.Filtering;
//using DevExpress.ExpressApp;
//using DevExpress.ExpressApp.Actions;
//using DevExpress.ExpressApp.Editors;
//using DevExpress.ExpressApp.Layout;
//using DevExpress.ExpressApp.Model.NodeGenerators;
//using DevExpress.ExpressApp.SystemModule;
//using DevExpress.ExpressApp.Templates;
//using DevExpress.ExpressApp.Utils;
//using DevExpress.ExpressApp.Win.Editors;
//using DevExpress.Persistent.Base;
//using DevExpress.Persistent.Validation;
//using DevExpress.XtraGrid.Views.BandedGrid;
//using System;
//using System.Collections.Generic;
//using System.Configuration;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ClassLibrary1;

//namespace HMS.Module.Controllers
//{
//    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
//    public partial class ListviewHeaderAlignment : ViewController<ListView>
//    {
//        public ListviewHeaderAlignment()
//        {
//            InitializeComponent();
//            RegisterActions(components);
//        }
//        protected override void OnViewControlsCreated()
//        {
//            base.OnViewControlsCreated();
//            var editor = View.Editor as GridListEditor;
//            Devexpress_Component.Resources.Check();

//            /*            if (editor != null)
//                        {

//                            foreach (DevExpress.XtraGrid.Columns.GridColumn col in editor.GridView.Columns)
//                            {
//                                col.AppearanceHeader.Options.UseTextOptions = true;
//                                col.AppearanceCell.Options.UseTextOptions = true;

//                                col.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
//                                col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;

//                            }
//                        }*/
//        }

//    }
//}
