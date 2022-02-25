

using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace MasayaNaturistCenter.Model.Models
{
    public partial class MasayaNaturistCenterContext : DbContext
    {
        public MasayaNaturistCenterContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MasayaNaturistCenterDataBase"].ConnectionString);
        }

        public virtual DbSet<Consult> Consult { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Patient> Patient { get; set;}
        public virtual DbSet<PrescriptionProduct> PrescriptionProduct { get; set;}
        public virtual DbSet<Presentation> Presentation { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderPhone> ProviderPhone { get; set; }
        public virtual DbSet<SaleDetail> SaleDetail { get; set; }
        public virtual DbSet<Sell> Sell { get; set; }
        public virtual DbSet<Stock> Stock { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<SupplyDetail> SupplyDetail { get; set; }
    }
}
