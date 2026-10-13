using Microsoft.EntityFrameworkCore;

namespace AjaxDemo.Models
{
    public partial class meixinEntities : DbContext
    {
        public meixinEntities(DbContextOptions<meixinEntities> options)
            : base(options)
        {
        }

        public virtual DbSet<m_admin> m_admin { get; set; }
        public virtual DbSet<m_order> m_order { get; set; }
        public virtual DbSet<m_orderdetails> m_orderdetails { get; set; }
        public virtual DbSet<m_product> m_product { get; set; }
        public virtual DbSet<m_user> m_user { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<m_orderdetails>(entity =>
            {
                entity.HasOne(d => d.m_order)
                    .WithMany(o => o.m_orderdetails)
                    .HasForeignKey(d => d.m_order_id);

                entity.HasOne(d => d.m_product)
                    .WithMany(p => p.m_orderdetails)
                    .HasForeignKey(d => d.m_product_id);
            });
        }
    }
}
