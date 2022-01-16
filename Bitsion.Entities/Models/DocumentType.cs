using System.ComponentModel.DataAnnotations;

namespace Bitsion.Entities
{
    public class DocumentType
    {
        [Key]
        public int doc_Id { get; set; }

        public string doc_Document { get; set; }
    }
}
