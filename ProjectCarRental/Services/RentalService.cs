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

        public RentalService(double preacePerHour, double preacePerDay)
        {
            PreacePerHour = preacePerHour;
            PreacePerDay = preacePerDay;
        }

        public void ProcessInVoice(CarRental carRental)
        {


        }
    }
}
