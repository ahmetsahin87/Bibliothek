
// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Repository.Models;



var _context = new DbCont();

//var s = _context.Buches.Include(a => a.Author).ToList();
//var a = s.FirstOrDefault().Name;



//var buch = _context.Buches.ToList().FirstOrDefault();


//var authorname = buch.Author.VorName;

Console.WriteLine("   sss");


var neuesBuch = new Buch()
{
    Name = "hamidi",
    Seite = 111,
    Author= new Author() { Id=44},
    Verlag= new Verlag() { Id=55}
    };

using ( _context = new DbCont())
{
    _context.Buches.Add(neuesBuch);
    _context.SaveChanges();
}