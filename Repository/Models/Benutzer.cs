using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Benutzer
    {
        [Key]
        public int Id { get; set; }
        public string VorName { get; set; }
        public string Nachname { get; set; }
        public DateTime Geburtsdatum { get; set; }
    }
}