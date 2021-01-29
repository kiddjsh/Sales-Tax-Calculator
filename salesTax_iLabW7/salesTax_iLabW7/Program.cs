using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesTax_iLabW6
{
    class Program
    {

        static void Main(string[] args)
        {
            //declare variables            
            double price = 0, sales = 0, tax = 0, total = 0;
            int quantity = 0;
            string customerName = "", state = "";

            //output greeting
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Hi! Welcome to the Sales Tax Calculator.");

            //user input
            Console.WriteLine();
            Console.Write("Enter the name of the customer: ");
            customerName = Console.ReadLine();
            Console.Write("In which state (NY / NJ / FL)?: ");
            state = Console.ReadLine();
            Console.Write("How many items were purchased?: ");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("What was the unit price of the items?: $");
            price = Convert.ToDouble(Console.ReadLine());

            //need to do the name, state, quantity, price
            sales = computeTotal(quantity, price, sales);
            tax = computeTax(sales, state, tax);
            total = sales + tax;
            sales = Math.Round(sales, 2);  //round

            //output
            Console.WriteLine();
            Console.Write("The total sales for " + customerName + " are: $" + sales);
            Console.WriteLine();
            Console.Write("The total with taxes is: " + total.ToString("C"));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Press any key to continue...");

            Console.ReadLine();  //call the console.readline function. ignore the return value.
        }

        public static double computeTotal(int quantity, double price, double sales)
        {
            sales = quantity * price;
            sales = Math.Round(sales, 2);  //round
            return sales;
        }

        public static double computeTax(double sales, string state, double tax)
        {
            if (state == "NJ")
                tax = sales * .07;

            if (state == "FL")
                tax = sales * .06;

            if (state == "NY")
                tax = sales * .04;

            return tax;           
        }

    }
}


