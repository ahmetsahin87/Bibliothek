
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    public class Buch
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seite { get; set; }
        public DateTime Erscheinungsjahr { get; set; }       
        public Author Author { get; set; }
        public Verlag Verlag { get; set; }

        public int AuthorId { get; set; }
        public int VerlagId { get; set; }
    }
}