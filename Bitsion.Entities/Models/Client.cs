using System.ComponentModel.DataAnnotations;

namespace Bitsion.Entities.Models
{
    public class Client
    {
        [Key]
        public int cli_Id { get; set; }

        public string cli_Name { get; set; }

        public DocumentType cli_doc_Document { get; set; }

        public Gender cli_gen_Gender { get; set; }

        public bool cli_Active { get; set; }

        public bool cli_Drive { get; set; }

        public bool cli_UseGlasses { get; set; }

        public bool cli_Diabetic { get; set; }

        public string cli_Diseases { get; set; }



    }
}
