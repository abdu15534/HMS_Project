//using DevExpress.Data.Filtering;
//using DevExpress.ExpressApp;
//using DevExpress.ExpressApp.Actions;
//using DevExpress.ExpressApp.Editors;
//using DevExpress.ExpressApp.Layout;
//using DevExpress.ExpressApp.Model.NodeGenerators;
//using DevExpress.ExpressApp.Scheduler.Win;
//using DevExpress.ExpressApp.SystemModule;
//using DevExpress.ExpressApp.Templates;
//using DevExpress.ExpressApp.Utils;
//using DevExpress.Persistent.Base;
//using DevExpress.Persistent.Base.General;
//using DevExpress.Persistent.Validation;
//using DevExpress.XtraScheduler;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace HMS.Module.Win.Controllers
//{
//    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppWindowControllertopic.aspx.
//    public partial class WinSchedulerController : ObjectViewController<ListView, IEvent>
//    {
//        protected override void OnViewControlsCreated()
//        {
//            base.OnViewControlsCreated();
//            SchedulerListEditor listEditor = View.Editor as SchedulerListEditor;
//            if (listEditor != null)
//            {
//                SchedulerControl scheduler = listEditor.SchedulerControl;
//                scheduler.Views.DayView.VisibleTime =
//                    new TimeOfDayInterval(new TimeSpan(8, 0, 0), new TimeSpan(17, 0, 0));
//                scheduler.AppointmentViewInfoCustomizing += SchedulerControl1_AppointmentViewInfoCustomizing;
//            }

//            void SchedulerControl1_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
//            {
               
//                    e.ViewInfo.ToolTipText = String.Format("Started at {0:g} ",e.ViewInfo.Appointment.Start);
//            }
//        }
//    }
//}
