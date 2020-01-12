using System;


namespace DelegateSolutions
{
    class Program
    {
        public delegate double myShipping(double shippingRate, double risk);


        static void Main(string[] args)
        {
            string input;
            do
            {

            Console.WriteLine("What is your destination zone");
            input = Console.ReadLine();

                if (input !="exit")
                {
                    Console.WriteLine("What is the item price");
                    string price = Console.ReadLine();


                    double shippingRate = CalculateFee(input);
                    double riskFee = CalculateRisk(input);

                    double shippingFee = (Convert.ToDouble(price)) * shippingRate + riskFee;

                    Console.WriteLine($"The shipping rate is {shippingFee:C}");
                 }

            } while (input!="exit");
        }

        public static double CalculateFee(string input)
        {
            double zone = Convert.ToDouble(input);

            if (zone == 1)
            {
                return 0.25;

            }
            if (zone == 2)
            {
                return 0.12;


            }
            if (zone == 3)
            {
                return 0.08;


            }

            if (zone == 4)
            {
                return 0.04;


            }
            if (zone == 5)
            {
                return 0.15;


            }
            return 0;

        }
        public static double CalculateRisk(string input)
        {

            if (input == "1")
            {
                return 0;

            }
            if (input == "2")
            {
                return 25;


            }

            if (input == "3")
            {
                return 0;


            }
            if (input == "4")
            {
                return 25;


            }
            if (input == "4")
            {
                return 0;


            }
            return 0;
        }
    }
}
