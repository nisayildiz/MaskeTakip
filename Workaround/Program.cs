// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using Entities.Concrete;
using System.Transactions;


public class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine();
        Person person1 = new Person();
        person1.FirstName = "Nisa";
        person1.LastName = "Yıldız";
        person1.DateOfBirthYear = 1998;
        person1.NationalIdentity = 1;



        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        Console.ReadLine();
    }



}



    



