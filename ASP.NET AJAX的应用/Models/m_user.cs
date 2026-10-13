namespace ASP.NET_AJAX的应用.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class m_user
    {
        public int id { get; set; }
        public string email { get; set; }
        public string pwd { get; set; }
        public Nullable<System.DateTime> logintime { get; set; }
    }
}
