using Bitsion.ContextData;
using Bitsion.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bitsion.Business.Service
{
    public class DocumentTypeBusiness
    {
        public List<DocumentType> DocumentTypeList()
        {
            using (var db = new BitsionDB())
            {
                return db.DocumentTypes.ToList();
            }
        }

    }
}
