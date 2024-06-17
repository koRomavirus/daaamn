using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Entities;

namespace WpfApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Specialist>Specialists { get; set; }
        public DbSet<Report>Reports { get; set; }
        public DbSet<Priority> Priorities   { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public string ConnectionString = @"Server=WIN-VFERN69A15U\SQLEXPRESS;Database=Dem;Trusted_Connection=True;Encrypt=false;";
    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString: ConnectionString);
        }
    }
}
