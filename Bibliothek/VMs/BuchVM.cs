using System.Security.Cryptography.X509Certificates;

namespace Bibliothek.VMs
{
    public class BuchVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Seite { get; set; }
        public int Erscheinungsjahr { get; set; }
        public string Author { get; set; }
        public string Verlag { get; set; }

    }
}