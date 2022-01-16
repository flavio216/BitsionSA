using Bitsion.ContextData;
using Bitsion.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bitsion.Business
{
    public class ClientBusiness
    {
        public List<Client> ClientList()
        {
            using(var db = new BitsionDB())
            {
                return db.Clients.Where(c => c.cli_Active == true).ToList();
            }
        }

        public List<Client> ClientDelete()
        {
            using(var db = new BitsionDB())
            {
                return db.Clients.Where(c => c.cli_Active == false).ToList();
            }
        }

        public static List<Client> SearchClient(string value)
        {
            using(var DB = new BitsionDB())
            {
                return DB.Clients.Where(c => c.cli_Name.Contains(value) || c.cli_doc_DocumentType.ToString().Contains(value)).ToList();
            }
        }

        public void CreateClient(Client c)
        {
            using (var db = new BitsionDB())
            {
                db.Clients.Add(c);
                db.SaveChanges();
            }
        }

        public void UpdatePerson(Client c)
        {
            using (var db = new BitsionDB())
            {
                db.Clients.Update(c);
                db.SaveChanges();
            }
        }

        //public static Client PersonByIdentification(int ident)
        //{
        //    using (var db = new BitsionDB())
        //    {
        //        return db.Clients.ToList().LastOrDefault(c => c.identification == ident);
        //    }
        //}
    }
}
