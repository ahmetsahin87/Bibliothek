
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Ausleih
    {
        [Key]
        public int Id { get; set; }
        public DateTime? AusleihDatum { get; set; }
        public DateTime? RueckgabeDatum { get; set; }


        public Benutzer Benutzer { get; set; }
        public Buch Buch { get; set; }

        public int BuchId { get; set; }
        public int BenutzerId { get; set;}
    }

  
}
