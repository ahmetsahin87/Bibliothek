
// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Repository.Models;



internal class Program
{
    delegate void Bakkal(string a);
    private static void Main(string[] args)
    {
        var _context = new DbCont();

        //var s = _context.Buches.Include(a => a.Author).ToList();
        //var a = s.FirstOrDefault().Name;



        //var buch = _context.Buches.ToList().FirstOrDefault();


        //var authorname = buch.Author.VorName;
        Bakkal bakkal =Ekmek;

        bakkal("40");
        

        Console.WriteLine("---------------------------");
        bakkal += Peynir;
        bakkal("10");
        Console.WriteLine("---------------------------");

        bakkal -= Ekmek;
        bakkal("30");
    }

   
    static void Ekmek(string a)
    {
        Console.WriteLine("Ekmek "+a+" lira");
    }

    static void Peynir(string a) 
    {
        Console.WriteLine("Peynir "+a+" lira");
    }
}






//var neuesBuch = new Buch()
//{
//    Name = "hamidi",
//    Seite = 111,
//    Author= new Author() { Id=44},
//    Verlag= new Verlag() { Id=55}
//    };

//using ( _context = new DbCont())
//{
//    _context.Buches.Add(neuesBuch);
//    _context.SaveChanges();
//}