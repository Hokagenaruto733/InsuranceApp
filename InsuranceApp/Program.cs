//import

using System.Collections.Generic;

namespace InsuranceApp
{
    internal class Program
    {
        //global variables





        //methods and functions
        static string CheckProceed()
        {
            while (true)
            {
                Console.WriteLine("\nPress <ENTER> to add another device or type 'x' to exit");
                string CheckProceed = Console.ReadLine();

                CheckProceed = CheckProceed.ToUpper();

                if ((CheckProceed.Equals("")) || CheckProceed.Equals("X"))
                {
                    return CheckProceed;
                }

                Console.WriteLine("Error: Invalid choice");
            }
        }


        static void OneDevice()
        {

            List<string> catergory = new List<string>() { "Laptop", "Desktop", "Other (smartphone, tablet, drone, etc)" };



            //User eneters device catergory
            Console.WriteLine(
            "Choose a category:\n" +
            $"1. {catergory[0]}\n" +
            $"2. {catergory[1]}\n" +
            $"3. {catergory[2]}\n"
            );

            int deviceCategory = Convert.ToInt32(Console.ReadLine());



            //user enters device name 
            Console.WriteLine("\nEnter a device name:\n");
            string deviceName = Console.ReadLine();


            //Users enter the cost of each device.
            Console.WriteLine("\nEnter cost of the device\n");
            float deviceCost = (float)Convert.ToDecimal(Console.ReadLine());


            //Users enters the amount of quantity of devices
            Console.WriteLine("\nEnter the qauntity of devices\n");
            int qauntityDevice = Convert.ToInt32(Console.ReadLine());


            float insuranceCost = 0;

            //calculate total of cost
            if (qauntityDevice > 5)
            {
                insuranceCost += 5 * deviceCost;
                insuranceCost += qauntityDevice * deviceCost;
            }
            else
            {
                insuranceCost += qauntityDevice * deviceCost;
            }

            //display device summary
            Console.WriteLine($"\nName: {deviceName}");
            Console.WriteLine($"Total cost for {qauntityDevice} x {deviceName} is = to ${insuranceCost}");
            Console.WriteLine($"Category: {deviceCategory}");


            //calculate device  over 6 months
            Console.WriteLine("\nMonth\tValue loss\n");

            float depreciation = deviceCost;

            for (int month = 0; month < 6; month++)
            {
                depreciation = depreciation * 0.95f;
                Console.WriteLine($"{month + 1}\t{depreciation}");

            }


        }

        static string CheckName()
        {
            return "";
        }



        //main process or when run...
        static void Main(string[] args)
        {
            string proceed = "";
            while (proceed.Equals(""))
            {

                OneDevice();

                proceed = CheckProceed();
            }


        }
    }
}
