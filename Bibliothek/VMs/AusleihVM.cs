using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.VMs
{
    public class AusleihVM
    {
        public int Id { get; set; }
        public DateTime? AusleihDatum { get; set; }
        public DateTime? RueckgabeDatum { get; set; }
        public string BenutzerNachname { get; set; }
        public string BenutzerVorname { get; set; }
        public string Titel { get; set; }


    }
}
 