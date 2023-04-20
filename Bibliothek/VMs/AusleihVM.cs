using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliothek.VMs
{
    internal class AusleihVM
    {
        public DateTime AusleihDatum { get; set; }
        public DateTime RueckgabeDatum { get; set; }
        public string BenutzerNachname { get; set; }
        public string BenutzerVorname { get; set; }
        public string? BuchTtel { get; set; }


    }
}
