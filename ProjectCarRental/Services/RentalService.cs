using ProjectCarRental.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarRental.Services
{
    class RentalService
    {
        public double PreacePerHour { get; private set; }
        public double PreacePerDay { get; private set; }
        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double preacePerHour, double preacePerDay)
        {
            PreacePerHour = preacePerHour;
            PreacePerDay = preacePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PreacePerHour * Math.Ceiling(duration.TotalHours);
            }

            else
            {
                basicPayment = PreacePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment,tax);
        }
    }
}
