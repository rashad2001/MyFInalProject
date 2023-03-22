// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemoryDal;
using Entities;

UserManager userManager = new UserManager(new UserDal());

foreach (var u in userManager.GetData())
{
    Console.WriteLine(u.Surname);
}
