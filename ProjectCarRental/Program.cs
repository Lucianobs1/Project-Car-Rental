using ProjectCarRental.Entites;
using System;
using System.Globalization;

namespace ProjectCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data: ");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm) : ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "DD/mm/YYYY HH:mm ",CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Return (dd/MM/yyyy hh:mm) : ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "DD/mm/YYYY HH:mm ", CultureInfo.InvariantCulture);
            Console.WriteLine();

            CarRental carRental = new CarRental(start, finish,new Vehicle(model));
        }
    }
}
