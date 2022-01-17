using Bitsion.ContextData;
using Bitsion.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bitsion.Business
{
    public class GenderBusiness
    {
        public List<Gender> GenderList()
        {
            using (var db = new BitsionDB())
            {
                return db.Genders.ToList();
            }
        }
    }
}
