using Bitsion.Server.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Bitsion.Entities;

namespace Bitsion.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Entities.Client> Clients { get; set; }

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
                new Gender { gen_Id = 2, gen_Gender = "Femenino" },
                new Gender { gen_Id = 3, gen_Gender = "Prefiero no decirlo" },
                new Gender { gen_Id = 4, gen_Gender = "Otro" }
                );
            model.Entity<DocumentType>().HasData(
               new DocumentType { doc_Id = 1, doc_Document = "DNI" },
               new DocumentType { doc_Id = 2, doc_Document = "Pasaporte" },
               new DocumentType { doc_Id = 3, doc_Document = "Carnet Extranjero" }
               );
            model.Entity<Entities.Client>().Property(c => c.cli_Id).ValueGeneratedOnAdd();
            model.Entity<Entities.Client>().HasData(
                new Entities.Client { cli_Id = 1, cli_Active = true, cli_Dni = "40777666", cli_Diabetic = true, cli_Diseases = "Hipertensión", cli_doc_DocumentType = 1, cli_Drive = true, cli_gen_Gender = 1, cli_Name = "Roberto Gomez", cli_UseGlasses = true },
                new Entities.Client { cli_Id = 2, cli_Active = true, cli_Dni = "14557234", cli_Diabetic = false, cli_Diseases = "Ceguera", cli_doc_DocumentType = 1, cli_Drive = true, cli_gen_Gender = 2, cli_Name = "Fulanita Perez", cli_UseGlasses = true }
                );

            //model.Entity<Client>().Property(c => c.cli_Id).ValueGeneratedOnAdd();
        }
    }
}
