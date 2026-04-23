using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberClassProjectOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaneTicket ticket1 = new PlaneTicket();

            ticket1.Origin = "JOGJA";
            ticket1.Destination = "PKU";
            ticket1.Cost = 100;
            ticket1.Currency = "USD";

            Console.WriteLine($"Origin: {ticket1.Origin}");
            Console.WriteLine($"Destination: {ticket1.Destination}");
            Console.WriteLine($"Cost: {ticket1.Cost} ({ticket1.Currency})");
            ticket1.PrintSummary();

            PlaneTicket ticket2 = new PlaneTicket();

            ticket2.Origin = "JAKARTA";
            ticket2.Destination = "PKU";
            ticket2.Cost = 750000;
            ticket2.Currency = "IDR";

            Console.WriteLine();

            Console.WriteLine($"Origin: {ticket2.Origin}");
            Console.WriteLine($"Destination: {ticket2.Destination}");
            Console.WriteLine($"Cost: {ticket2.Cost} ({ticket2.Currency})");
            ticket2.PrintSummary();
        }
    }
}
