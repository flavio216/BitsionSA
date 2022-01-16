using System.ComponentModel.DataAnnotations;

namespace Bitsion.Entities
{
    public class Client
    {
        [Key]
        public int cli_Id { get; set; }

        public string cli_Name { get; set; }

        public string cli_Dni { get; set; }

        public int cli_doc_DocumentType { get; set; }

        public int cli_gen_Gender { get; set; }

        public bool cli_Active { get; set; }

        public bool cli_Drive { get; set; }

        public bool cli_UseGlasses { get; set; }

        public bool cli_Diabetic { get; set; }

        public bool cli_OtherDiseases { get; set; }
        public string cli_Diseases { get; set; }

        public string ToBooleanString(bool flag)
        {
            if (flag)
                return "SI";
            else
                return "NO";
        }
    }

    
}
