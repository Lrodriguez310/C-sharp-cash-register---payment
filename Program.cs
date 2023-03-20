// Program name: Receipt Printer Program
// Program purpose: Create a program to print a customer's bill
// Program author: [Luis Rodriguez]
// Date and time started:  2022- 02- 12  at 0821
// Start time: 0821 - 2022 02 12
// End time: 1246 - 2022 02 16
// Hours to build program : 4 hours and 46 minutes.
// Date last modified: 2022-02-16


using System;

namespace ReceiptProgram
{
	class Program
	{
		static void Main(string[] args)
		{
	    	Console.WriteLine("Welcome to the Receipt Printer Program for Griff's Great Clips!");  // welcome message added
			
            // Get input from user: his or her family name and first name 
			Console.Write("Enter the customers family name: ");  // input family name
            string familyName = Console.ReadLine();
			Console.Write("Enter the Customers first name: ");  // input first name
			string givenName = Console.ReadLine();
			
            // Declaring variables for input here:  type of haircut , price of haircut , asking if he/she would like to give tip: 0 , 0.15 , 0.20 these decimals will substitute the percent sign for multiplication
            Console.Write("Enter the type of haircut given  Youth - Adult - Styled: "); // enter type of haircut
            string haircutGiven = Console.ReadLine();
            
            Console.Write("Enter price of haircut for Youth(10.00) - Adult(30.00) - Styled(50.00): ");  // enter price of haircut using decimal , type of haircut provided for reference
			decimal priceHaircut = Convert.ToDecimal(Console.ReadLine());   // explicit convert to decimal : this is to display the value as a decimal
            Console.WriteLine($@"Your haircut type and price is: {haircutGiven} {priceHaircut}.");  // outputs haircutGiven and priceHaircut
            
            Console.WriteLine("Will a tip be applied? if not please input 0");  // message for tip.  input 0 if no tip

            Console.Write("Tip amount 0 15% 20%. Please write 0 or 0.15 or 0.20: ");  // using decimal to replace percentage for easy muliplication
            decimal tipPercent = Convert.ToDecimal(Console.ReadLine());     // explicit convert to decimal  ""

            Console.Write("Enter Sales Tax 13%. Please write 0.13: ");
            decimal salesTax = Convert.ToDecimal(Console.ReadLine());       // explicit convert to decimal ""

            // Calculating price without tax or tips , calculating tax amount , calculating tip amount , calculating price with tax alone , calculating price with tips alone, calculating Grand total. 
            decimal tipValue = tipPercent * priceHaircut;   // calculating tip percentage taken from price of specific haircut
            decimal tipTotal = priceHaircut + tipValue;     // calculating tip total of haircut price and tip amount after percent has been applied to main price
            decimal taxValue = salesTax * priceHaircut;     // tax is 13% and the percentage is taken from main price which gives us the taxValue
            decimal taxTotal = priceHaircut + taxValue;     // this will calculate the price of haircut and the tax amount after percentages have been applied to main price
            decimal grandTotal = tipValue + taxValue + priceHaircut;    // the grand total of the tip amount , the tax amount , and the price of the haircut
            
            // Displaying Bill Information: Bill alone, Tax amount , tax with bill , tip amount , tip with bill , and grand total : summing up all values.
            Console.WriteLine("Receipt for: " + givenName + " " + familyName);  // program will display givenName and familyName of the customer
            Console.WriteLine($@"Your haircut type and price is: {haircutGiven} {priceHaircut}.");  // displaying type of haircut :  youth , adult , styled and the priceHaircut : 10.00 , 30.00 , 50.00
            Console.WriteLine("price before taxes: $" + priceHaircut);   // displaying price before taxes
            Console.WriteLine("How much tax added: $" + taxValue); //displays how much tax is added taxValue
            Console.WriteLine($@"Sales Tax is: {salesTax} percent - total with tax {taxTotal}.");  // displays both salesTax which is 13% and the total of price with added sales tax
            Console.WriteLine("Total with taxes: $" + taxTotal);  // displays the taxTotal
            Console.WriteLine("How much tip added: $" + tipValue); // displaying how much tip is added after percentage taken from priceHaircut
            Console.WriteLine($@"You selected to tip: {tipPercent} percent - total with tip {tipTotal}.");  // displays tip percentage and the total with tip added to priceHaircut
            Console.WriteLine("Total with tip: $" + tipTotal);   // tipTotal displayed which is price of haircut with taxes added
            Console.WriteLine("Grand Total: $" + grandTotal);    // grandTotal displayed
            
            // closing program
            Console.WriteLine("Thank you for using the Receipt Printer Program for Griff's Great Clips!");   // end message for program
             
        }
    }
}        