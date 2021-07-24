using DevExpress.ExpressApp;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Drawing;
using DisplayNameAttribute = System.ComponentModel.DisplayNameAttribute;

namespace SimpleProjectManager.Module.BusinessObjects.Planning
{

    public enum ProjectTaskStatus
    {
        [ImageName("State_Task_NotStarted")]
        NotStarted = 0,
        [ImageName("State_Task_InProgress")]
        InProgress = 1,
        [ImageName("State_Validation_Valid")]
        Completed = 2,
        [ImageName("State_Task_Deferred")]
        Deferred = 3
    }
    [ImageName("BO_Task")]
    [NavigationItem("Task")]
    [DefaultProperty(nameof(ProjectTask.Subject))]
    [DefaultListViewOptions(MasterDetailMode.ListViewOnly, true, NewItemRowPosition.Top)]
    [Appearance("Completed1", TargetItems = nameof(Subject), Criteria = ProjectTask.CompletedCriteria, FontStyle = FontStyle.Strikeout, FontColor = "ForestGreen")]
    [Appearance("Completed2", TargetItems = nameof(Subject), Criteria = ProjectTask.CompletedCriteria, Enabled = false)]
    [Appearance("InProgress", TargetItems = "*", Criteria = ProjectTask.InProgressCriteria, BackColor = "LemonChiffon")]
    [Appearance("Deferred", TargetItems = "*", Criteria = ProjectTask.DeferredCriteria, BackColor = "MistyRose")]
    [RuleCriteria("EndDate >= StartDate")]
    [DisplayName("Task")]
    public class ProjectTask : BaseObject
    {

        public const string CompletedCriteria = "Status = 'Completed'";
        public const string DeferredCriteria = "Status = 'Deferred'";
        public const string InProgressCriteria = "Status = 'InProgress'";
        string subject;
        ProjectTaskStatus status;
        Person assignedTo;
        DateTime startDate;
        DateTime endDate;
        string notes;
        //Project project;
        public ProjectTask(Session session) : base(session) { }
        [Size(255), RuleRequiredField]
        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                SetPropertyValue(nameof(Subject), ref subject, value);
            }
        }
        [ImmediatePostData]
        public ProjectTaskStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                SetPropertyValue(nameof(Status), ref status, value);
            }
        }
        [RuleRequiredField(TargetCriteria = ProjectTask.CompletedCriteria)]
        // [DataSourceCriteria("IsExactType(This, 'YourNameSpace.YourClassName'")]
        public Person AssignedTo
        {
            get
            {
                return assignedTo;
            }
            set
            {
                SetPropertyValue(nameof(AssignedTo), ref assignedTo, value);
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                SetPropertyValue(nameof(startDate), ref startDate, value);
            }
        }
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                SetPropertyValue(nameof(endDate), ref endDate, value);
            }
        }
        [Size(SizeAttribute.Unlimited)]
        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                SetPropertyValue(nameof(Notes), ref notes, value);
            }
        }
    }
}
