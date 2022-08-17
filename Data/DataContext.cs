using DrugApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DrugApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Users> users { get; set; }
        public DbSet<Admin> admins { get; set; }

        public DbSet<Products> products { get; set; }

        public DbSet<Dummy> dummy { get; set; }

        public DbSet<OrderDetail> OrderDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration["ConnectionStrings:DefaultConnection"];
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

     //   protected override void OnModelCreating(ModelBuilder modelBuilder)
     //   {
     //       // add your own configuratio
     //       //  modelBuilder.Entity<Products>().Ignore(c => c.MfdDate);

     //       base.OnModelCreating(modelBuilder);
     //       object value = modelBuilder.Conventions.Add(new DataTypePropertyAttributeConvention());

     //       modelBuilder.Entity<Products>()
     // .Property(p => p.MfdDate)
     // .HasColumnType("DateOnly");
     //       modelBuilder.Entity<Products>()
     //.Property(p => p.ExpDate)
     //.HasColumnType("DateOnly");


     //   }

    }
}

