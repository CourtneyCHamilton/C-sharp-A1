using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TicketSeller
    {
        private string name;
        private double price = 100;
        private int numOfAdults;
        private int numOfChildren;
        private double amountToPay;

        public void getBuyerName()
        {
            Console.WriteLine("Your name please: ");
            name = Console.ReadLine();
        }

        public void getNumAdults()
        {
            Console.WriteLine("Number of Adults? ");
            numOfAdults = int.Parse(Console.ReadLine());
        }

        public void getNumChildren()
        {
            Console.WriteLine("Number of Children? ");
            numOfChildren = int.Parse(Console.ReadLine());
        }

        public void calculatePrice()
        {
            amountToPay = (numOfAdults * price) + (numOfChildren * (price * 0.25));
        }

        public void displayReceipt()
        {
            Console.WriteLine("+++ Your Receipt +++");
            Console.WriteLine("+++ Amount to Pay: " + amountToPay);
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Faire!");
            Console.WriteLine("Children under 18 get a 75% discount on the ticket price!");
            getBuyerName();
            getNumAdults();
            getNumChildren();
            calculatePrice ();
            displayReceipt();
            Console.WriteLine("Thank you " + name + ", and enjoy the Faire!");
        }
    }
}
