
// See https://aka.ms/new-console-template for more information
using Repository.Models;



var dbcont = new DbCont();

var s = dbcont.Buches.ToList();

var a = s.FirstOrDefault().Name;

Console.WriteLine(a);
