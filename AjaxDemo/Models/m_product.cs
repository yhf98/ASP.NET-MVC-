namespace AjaxDemo.Models
{
    using System;
    using System.Collections.Generic;

    public partial class m_product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public m_product()
        {
            this.m_orderdetails = new HashSet<m_orderdetails>();
        }

        public int id { get; set; }
        public string pname { get; set; }
        public string photo { get; set; }
        public double price { get; set; }
        public string flavor { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public int m_shop_id { get; set; }
        public int m_area_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<m_orderdetails> m_orderdetails { get; set; }
    }
}
