using ProjectCarRental.Entites;
using ProjectCarRental.Services;
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

            Console.WriteLine("Pickup (dd/MM/yyyy HH:mm) : ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Return (dd/MM/yyyy HH:mm) : ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Enter preace per hour");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Enter preace per hour");
            double days = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            CarRental carRental = new CarRental(start, finish,new Vehicle(model));
            RentalService rentalService = new RentalService(hour, days);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

            Console.ReadKey();
        }
    }
}
