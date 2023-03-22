// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemoryDal;
using Entities;

UserManager userManager = new UserManager(new UserDal());

foreach (var u in userManager.GetData())
{
    Console.WriteLine(u.Id);
    Console.WriteLine(u.BirthYear);
    Console.WriteLine(u.Name);
    Console.WriteLine(u.Surname);
    Console.WriteLine("ID: " + u.Id  + " Name: " + u.Name + " Surname: " + u.Surname + " BirthYear: " + u.BirthYear);
}
