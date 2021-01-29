# Sales-Tax-Calculator
An application, using a solution algorithm where debugging diagnostics were employed to remove and correct  errors. The application asks for the name of the customer, one of three states, i.e., NJ, FL, or NY, how  many items were purchased, and the unit price of the items, then calculates the total sales and total  sales with taxes depending on state. NJ 7% tax, FL 6% tax, and NY 4% tax.

# IPO Model
![Variables & IPO Model](https://raw.githubusercontent.com/kiddjsh/Sales-Tax-Calculator/main/images/Variables%20%26%20IPO%20Model.PNG)

# Hierarchy Chart
![Hierarchy Chart](https://raw.githubusercontent.com/kiddjsh/Sales-Tax-Calculator/main/images/Hierarchy%20Chart.PNG)


# My C# Solution
```C#
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
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

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
```

# Complete Working Program
![Complete Working Program_1](https://raw.githubusercontent.com/kiddjsh/Sales-Tax-Calculator/main/images/Complete%20Working%20Program_1.PNG)
![Complete Working Program_2](https://raw.githubusercontent.com/kiddjsh/Sales-Tax-Calculator/main/images/Complete%20Working%20Program_2.PNG)
![Complete Working Program_3](https://raw.githubusercontent.com/kiddjsh/Sales-Tax-Calculator/main/images/Complete%20Working%20Program_3.PNG)

