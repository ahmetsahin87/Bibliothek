using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Author
    {
        [Key]       
        public int Id { get; set; }
        public string VorName { get; set; }
        public string Nachname { get; set; }
    }
}