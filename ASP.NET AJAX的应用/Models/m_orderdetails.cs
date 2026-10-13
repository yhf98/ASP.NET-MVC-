namespace ASP.NET_AJAX的应用.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class m_orderdetails
    {
        public int id { get; set; }
        public int amount { get; set; }
        public int m_order_id { get; set; }
        public int m_product_id { get; set; }
    
        public virtual m_order m_order { get; set; }
        public virtual m_product m_product { get; set; }
    }
}
