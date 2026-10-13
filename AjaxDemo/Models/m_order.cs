namespace AjaxDemo.Models
{
    using System;
    using System.Collections.Generic;

    public partial class m_order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public m_order()
        {
            this.m_orderdetails = new HashSet<m_orderdetails>();
        }

        public int id { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string sendtime { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> ordertime { get; set; }
        public string m_user_email { get; set; }
        public double total { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<m_orderdetails> m_orderdetails { get; set; }
    }
}
