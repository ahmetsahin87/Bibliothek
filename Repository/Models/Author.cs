using System.ComponentModel.DataAnnotations;

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