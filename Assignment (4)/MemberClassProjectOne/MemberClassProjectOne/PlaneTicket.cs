using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClassProjectOne
{
    internal class PlaneTicket
    {
        private string origin;
        private string destination;
        private int cost;
        private string currency;

        public string Origin
        {
            get { return origin; }
            set { origin = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = value; }

        }

        public void PrintSummary()
        {
            if (currency == "USD")
            {
                Console.WriteLine($"Convert to Rupiah : {Cost * 15000}");
            }
            else 
            {
                Console.WriteLine($"Convert to Dolar : {Cost / 15000}");
            }
            Console.WriteLine();
        }

    }
}
