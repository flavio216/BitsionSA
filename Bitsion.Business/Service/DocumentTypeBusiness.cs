using Bitsion.ContextData;
using Bitsion.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bitsion.Business
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
