using System;
//Developed: Dipendra And Jose
namespace BobsBurgers
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            int burgers = 0;
            int fries = 0;
            int drinks = 0;
            int bobbyMeal = 0;
            string answer = String.Empty;
            double subTotal = 0.0;
            double taxTotal = 0.0;
            double grandTotal = 0.0;
            int quantity = 0;
            int orderNumber = 0;
            string customerNumber = String.Empty;
            bool isString = true;
            string itemNum = String.Empty;
            GetOrder(ref burgers, ref fries, ref drinks, ref bobbyMeal, out answer, ref subTotal, out quantity, out orderNumber, out customerNumber, out isString, out itemNum);

            taxTotal = .06875f * subTotal;
            grandTotal = taxTotal + subTotal;

            //output
//TODO refactor this, this should be in the method below and when it is and working I can show you how it will simplify your code
            if (burgers > 0)
                Console.WriteLine("Total number of burgers ordered is " + burgers + " at $" + burgers * 2.99f);

            if (fries > 0)
                Console.WriteLine("Total number of fries ordered is " + fries + " at $" + fries * 1.99f);
            if (drinks > 0)
                Console.WriteLine("Total number of drinks ordered is " + drinks + " at $" + drinks * .99f);
            if (bobbyMeal > 0)
                Console.WriteLine("Total number of bobbyMeal ordered is " + bobbyMeal + " at $" + bobbyMeal * 5.00f);

            Console.WriteLine("SubTotal is $" + Math.Round(subTotal, 2));
            Console.WriteLine("Total tax is $" + Math.Round(taxTotal, 2));
            Console.WriteLine("Total due is $" + Math.Round(grandTotal, 2));

            Console.ReadLine();
        }

        private static void GetOrder(ref int burgers, ref int fries, ref int drinks, ref int bobbyMeal, out string answer, ref double subTotal, out int quantity, out int orderNumber, out string customerNumber, out bool isString, out string itemNum)
        {

            //input

            do
            {
                do
                {
                    //TDOD: refactor this into its own method
                    Console.WriteLine(" Please select the number from following items:\n" +
                        " 1)Burgers $2.99 \n" +
                        " 2)Fries $1.99 \n" +
                        " 3)Drinks$.99 \n" +
                        " 4)Bobby Meal (a burger, fry and drink $5.00)");
                    customerNumber = Console.ReadLine();
                    isString = int.TryParse(customerNumber, out orderNumber);
                    if (orderNumber < 1 || orderNumber > 4)
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }

                } while (orderNumber < 1 || orderNumber > 4);
//todo refactor this into its own method
                do
                {
                    Console.WriteLine("Please enter the quantity of this item ");
                    itemNum = Console.ReadLine();
                    isString = int.TryParse(itemNum, out quantity);
                    if (!isString)
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }

                } while (!isString);

                //process
                if (orderNumber == 1)
                {
                    burgers = burgers + quantity;

                    subTotal = subTotal + 2.99f * quantity;
                }
                else if (orderNumber == 2)
                {
                    fries = fries + quantity;

                    subTotal = subTotal + 1.99f * quantity;
                }
                else if (orderNumber == 3)
                {
                    drinks = drinks + quantity;

                    subTotal = subTotal + .99f * quantity;
                }

                else if (orderNumber == 4)
                {
                    bobbyMeal = bobbyMeal + quantity;
                    subTotal = subTotal + 5.00f * quantity;
                }

                Console.WriteLine(" Do you want to add anything else to your order? Y or N ");

                answer = Console.ReadLine().Substring(0, 1).ToUpper();

            } while (answer == "Y");
        }
    }
}
