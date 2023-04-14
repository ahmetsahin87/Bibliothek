
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class Buch
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seite { get; set; }
        public DateTime Erscheinungsjahr { get; set; }
        public Author Author { get; set; }
        public Verlag Verlag { get; set; }
    }
}