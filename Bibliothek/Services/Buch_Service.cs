using Bibliothek.UserController;
using Bibliothek.VMs;
using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bibliothek.Services
{
    internal class Buch_Service
    {
        private readonly DbCont _context= new DbCont();

        public void UpdateContext()
        {
            _context.SaveChanges();
        }
        public void CreateBuch(Buch buch)
        {
            _context.Buches.Add(buch);
            _context.SaveChanges();
        }
        public Buch ReadBuch(int id)
        {
            return _context.Buches.FirstOrDefault(b => b.Id == id);
        }
        public Ausleih GetAusleih(int id)
        {
            return _context.Ausleihs.FirstOrDefault(a => a.Id == id); 
        }
        public void UpdateBuch(Buch buch)
        {
            _context.Buches.Update(buch);
            _context.SaveChanges();
        }
        public void DeleteBuch(int id)
        {
            var buch = _context.Buches.FirstOrDefault(b => b.Id == id);
            if (buch != null)
            {
                MessageBoxResult result = MessageBox.Show("Löschen ?", "Bestätigung", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    _context.Buches.Remove(buch);
                    _context.SaveChanges();
                }

            }
        }
        public List<Buch> GetBuchList() 
        {
            return _context.Buches.ToList();
        }
        public List<BuchVM> GetBuchVMs()
        {
           var  Buchlist = _context.Buches.Include(b => b.Author).Include(b => b.Verlag).ToList();
            var Buch_VM_List = new List<BuchVM>();

            foreach (var buch in Buchlist)
            {
                var vm = new BuchVM();
                vm.Id = buch.Id;
                vm.Name = buch.Name;
                vm.Seite = buch.Seite;
                vm.Erscheinungsjahr = buch.Erscheinungsjahr.Year;
                vm.Author = buch.Author.Nachname;
                vm.Verlag = buch.Verlag.Name;

                Buch_VM_List.Add(vm);

            }

            return Buch_VM_List;
        }
        public List<Author> GetAuthorList()
        {
            return _context.Author.ToList();
        }
        public List<Verlag> GetVerlagList()
        {
            return _context.Verlags.ToList();
        }
        public void CreateAuthor(Author author)
        {
            _context.Author.Add(author);
            _context.SaveChanges();
        }
        public Author ReadAuthor(int id)
        {
            return _context.Author.FirstOrDefault(a => a.Id == id);
        }
        public void UpdateAuthor(Author author)
        {
            _context.Author.Update(author);
            _context.SaveChanges();
        }
        public void DeleteAuthor(int id)
        {
            var author = _context.Author.FirstOrDefault(a => a.Id == id);
            if (author != null)
            {
                MessageBoxResult result = MessageBox.Show("Author Löschen ?", "Bestätigung", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes) 
                {
                    _context.Author.Remove(author);
                    _context.SaveChanges();
                }
                
            }
        }
        public void CreateVerlag(Verlag verlag)
        {
            _context.Verlags.Add(verlag);
            _context.SaveChanges();
        }
        public Verlag ReadVerlag(int id)
        {
          return _context.Verlags.FirstOrDefault(v => v.Id == id);
        }
        public void UpdateVerlag(Verlag verlag)
        {
            _context.Verlags.Update(verlag);
            _context.SaveChanges();
        }
        public void DeleteVerlag(int id)
        {
            var verlag = _context.Verlags.FirstOrDefault(v => v.Id == id);
            if (verlag != null)
            {
                MessageBoxResult result = MessageBox.Show("Verlag Löschen ?", "Bestätigung", MessageBoxButton.YesNo, MessageBoxImage.Question);
               if (result == MessageBoxResult.Yes)
                {
                    _context.Verlags.Remove(verlag);
                    _context.SaveChanges();
                }
               
            }
        }
        public List<AuthorVM> GetAuthorVMs()
        {
            var Author_VM_list = new List<AuthorVM>();
           
             var Authorlist = _context.Author.ToList();

                foreach (Author author in Authorlist)
                {
                    var vm = new AuthorVM();
                    vm.Id = author.Id;
                    vm.Nachname = author.Nachname;
                    vm.Vorname = author.VorName;

                    Author_VM_list.Add(vm);
                }
                return Author_VM_list;            
        }
        public List<VerlagVM> GetVerlagVMs()
        {
            var Verlag_VM_list = new List<VerlagVM>();

            var Verlaglist = _context.Verlags.ToList();

            foreach (Verlag verlag in Verlaglist)
            {
                var vm = new VerlagVM();
                vm.Id = verlag.Id;
                vm.Email = verlag.Email;
                vm.Name = verlag.Name;
                vm.Ort = verlag.Ort;

                Verlag_VM_list.Add(vm);
            }
            return Verlag_VM_list;
        }
        public List<BenutzerVM> GetBenutzerVMs()
        {
            var Benutzer_VM_List = new List<BenutzerVM>();
            var Benutzerlist = _context.Benutzer.ToList();
            foreach (var benutzer in Benutzerlist)
            {
                var vm = new BenutzerVM();
                vm.Id = benutzer.Id;
                vm.Nachname = benutzer.Nachname;
                vm.Geburtsdatum = benutzer.Geburtsdatum;
                vm.Vorname = benutzer.VorName;
                Benutzer_VM_List.Add(vm);
            }
            return Benutzer_VM_List;

        }
        public void CreateBenutzer(Benutzer neuerNutzer)
        {
            _context.Benutzer.Add(neuerNutzer);
            _context.SaveChanges();
        }
        public void DeleteBenutzer(int id)
        {
            var nutzer = _context.Benutzer.FirstOrDefault(a => a.Id == id);
            if (nutzer != null)
            {
                MessageBoxResult result = MessageBox.Show("Benutzer Löschen ?", "Bestätigung", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    _context.Benutzer.Remove(nutzer);
                    _context.SaveChanges();
                }

            }
        }

        public List<Benutzer> GetBenutzerList()
        {
            return _context.Benutzer.ToList();
        }

        internal List<AusleihVM> GetAusleihVMs()
        {
            var Ausleihlist = _context.Ausleihs.Include(a => a.Buch).Include(b => b.Benutzer).ToList();
            var Ausleih_VM_List = new List<AusleihVM>();
            foreach (var ausleih in Ausleihlist)
            {
                var vm = new AusleihVM();
                vm.Id = ausleih.Id;
                vm.AusleihDatum = ausleih.AusleihDatum;
                vm.RueckgabeDatum = ausleih.RueckgabeDatum;
                vm.BenutzerVorname = ausleih.Benutzer.VorName;
                vm.BenutzerNachname = ausleih.Benutzer.Nachname;
                vm.Titel = ausleih.Buch.Name;

                Ausleih_VM_List.Add(vm);
            }
            return Ausleih_VM_List;
        }
        internal void RueckgabeAusleih(Ausleih ausleih)
        {            
            _context.Ausleihs.Update(ausleih);
            _context.SaveChanges();
            
        }

        internal void CreateAusleih(Ausleih neuAusleih)
        {
            _context.Ausleihs.Add(neuAusleih);
            _context.SaveChanges();
        }
    }
}
