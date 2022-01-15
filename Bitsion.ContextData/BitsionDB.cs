using Bitsion.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Bitsion.ContextData
{
    public class BitsionDB : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<DocumentType> DocumentTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            if (!option.IsConfigured)
            {
                option.UseSqlServer(@"Data Source=DESKTOP-K65QDHU\SQLEXPRESS;Initial Catalog=BitsionSA;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            model.Entity<Gender>().HasData(
                new Gender { gen_Id = 1, gen_Gender = "Masculino" },
                new Gender { gen_Id = 2, gen_Gender = "Femenino"},
                new Gender { gen_Id = 3, gen_Gender = "Prefiero no decirlo" },
                new Gender { gen_Id = 4, gen_Gender = "Otro"}
                );

            model.Entity<Client>().Property(c => c.cli_Id).ValueGeneratedOnAdd();
        }
    }
}
