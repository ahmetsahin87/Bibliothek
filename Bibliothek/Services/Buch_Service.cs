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

        public void CreateBuch(Buch buch)
        {
            _context.Buches.Add(buch);
            _context.SaveChanges();
        }

        public Buch ReadBuch(int id)
        {
            return _context.Buches.FirstOrDefault(b => b.Id == id);
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
                MessageBoxResult result = MessageBox.Show("Löschen ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
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
                _context.Author.Remove(author);
                _context.SaveChanges();
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
                _context.Verlags.Remove(verlag);
                _context.SaveChanges();
            }
        }



    }
}
