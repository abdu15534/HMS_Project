using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XafDataModel.Module.BusinessObjects.test2;

namespace HMS.Module.InitialData
{
    class PaymentData
    {
        public Patient patient { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }


        public XPCollection<Payments> paymentData( decimal t )
        {
            XPCollection<Payments> payments = new XPCollection<Payments>();
            return payments;
        }
    }
}
