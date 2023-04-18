using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Abgelaufen
    {
        public Ausleih Ausleih { get; set; }
        public bool IstAbgelaufen { get; set; }
    }
}
