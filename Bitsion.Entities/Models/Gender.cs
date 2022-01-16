using System.ComponentModel.DataAnnotations;

namespace Bitsion.Entities
{
    public class Gender
    {
        [Key]
        public int gen_Id { get; set; }

        public string gen_Gender { get; set; }
    }
}
