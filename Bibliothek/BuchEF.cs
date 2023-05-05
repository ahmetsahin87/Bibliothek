using Repository.Models;
using System;

namespace Bibliothek
{
    internal class BuchEF
    {
        public BuchEF()
        {
        }

        public string Name { get; set; }
        public int Seite { get; set; }
        public DateTime Erscheinungsjahr { get; set; }
        public Author Author { get; set; }
        public Verlag Verlag { get; set; }
    }
}