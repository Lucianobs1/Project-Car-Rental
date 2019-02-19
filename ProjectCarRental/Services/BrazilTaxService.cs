using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarRental.Services
{
    class BrazilTaxService
    {

        public double Tax(double Amount) {

            if (Amount <= 100)
            {
                return Amount * 0.2;
            }
            else
            {
                return Amount * 0.15;
            }
        }
    }
}
