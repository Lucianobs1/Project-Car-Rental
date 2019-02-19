using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectCarRental.Entites
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax, double totalPayment)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment {

            get { return BasicPayment + Tax; }
        }
    }
}
