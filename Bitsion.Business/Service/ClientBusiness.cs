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
                return db.Clients.ToList();
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

        public void UpdateClient(Client c)
        {
            using (var db = new BitsionDB())
            {
                db.Clients.Update(c);
                db.SaveChanges();
            }
        }

        public Client ClientById(int id)
        {
            using (var db = new BitsionDB())
            {
                return db.Clients.ToList().LastOrDefault(c => c.cli_Id == id);
            }
        }
    }
}
