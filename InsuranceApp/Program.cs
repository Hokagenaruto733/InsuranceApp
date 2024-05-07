//import

using System.Collections.Generic;

namespace InsuranceApp
{
    internal class Program
    {
        //global variables


        //methods and functions


        //Error message for entering letters or lower then the min and higher then max or is blank ("")
        static float CheckCost(string question, float min, float max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);

                    Console.ForegroundColor = ConsoleColor.Green;
                    float userfloat = (float)Convert.ToDecimal(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    if (userfloat >= min && userfloat <= max)
                    {
                        return userfloat;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You must enter an integer between {min} and {max}\n");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You must enter an integer between {min} and {max}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //Error message for entering letters or lower then the min and higher then max or is blank ("")
        static int CheckCategory(string question, float min, float max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);

                    Console.ForegroundColor = ConsoleColor.Green;
                    int userint = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    if (userint >= min && userint <= max)
                    {
                        return userint;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You must enter an integer between {min} and {max} \n");
                    Console.ForegroundColor = ConsoleColor.White;

                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You must enter an integer between {min} and {max} \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //Error message for entering letters or lower then the min and higher then max or is blank ("")
        static int CheckQauntity(string question, float min, float max)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(question);

                    Console.ForegroundColor = ConsoleColor.Green;
                    int userint = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;

                    if (userint >= min && userint <= max)
                    {
                        return userint;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You must enter an integer between {min} and {max}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nERROR: You must enter an integer between {min} and {max} \n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }

        //check if they need to add another device or not and error message if they eneter blank ("") or other then x or <ENTER>
        static string CheckProceed()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPress <ENTER> to add another device or type 'x' to exit\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.White;
                string CheckProceed = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                CheckProceed = CheckProceed.ToUpper();

                if ((CheckProceed.Equals("")) || CheckProceed.Equals("X"))
                {
                    return CheckProceed;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: Invalid choice\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Error message for entering a blank ("") in device name
        static string CheckDevice(string question)
        {
            while (true)
            {
                Console.WriteLine(question);

                Console.ForegroundColor = ConsoleColor.Green;
                string name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;

                if (!name.Equals(""))
                {
                    name = name[0].ToString().ToUpper() + name.Substring(1);

                    return name;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nERROR: You must enter a device name\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }



        //display title
        static string Title()
        { 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nwelcome to insurance app choose a category to countinue.\n");
            Console.ForegroundColor = ConsoleColor.White;
            return $"{OneDevice}";
        }

        static void OneDevice()
        {
            //list for category
            List<string> CATEGORY = new List<string>() { "Laptop", "Desktop", "Other (smartphone, tablet, drone, television, etc)" };
            CATEGORY.AsReadOnly();

            //User eneters the device catergory
            int deviceCategory = CheckCategory("\nChoose a category:\n" +
            $"1. {CATEGORY[0]}\n" +
            $"2. {CATEGORY[1]}\n" +
            $"3. {CATEGORY[2]}\n", 1, 3);


            //user enters device name 
            string deviceName = CheckDevice($"\nEnter the device name from category: {deviceCategory}\n");

            //Users enter the cost of the device.
            float deviceCost = CheckCost($"\nEnter the cost of the device: {deviceName}\n", 1, 1000000);

            //Users enters the amount of quantity of the device
            int qauntityDevice = CheckQauntity($"\nEnter the qauntity of the device: {deviceName}\n", 1, 100000);
            Console.Clear();
           

            //calculate total of cost with 10% discount after anything greater of the qauntity of 5
            float insuranceCost = 0;
            if (qauntityDevice > 5)
            {
                insuranceCost += 5 * deviceCost;
                insuranceCost += (qauntityDevice - 5) * deviceCost * 0.9f;
            }
            else
            {
                insuranceCost += qauntityDevice * deviceCost;
            }

            //display device summary

            Console.WriteLine($"\nName: {deviceName}");
            Console.WriteLine($"\nCategory: {deviceCategory}");
            Console.WriteLine($"\nDevice cost: {deviceCost}");
            Console.WriteLine($"\nDevice qauntity: {qauntityDevice}");
            Console.WriteLine($"\nTotal cost for {qauntityDevice} x {deviceCost} = ${insuranceCost}");
         



            //calculate device depreciation for over 6 months
            Console.WriteLine("\nMonth\tValue loss\n");
            float depreciation = deviceCost;
            for (int month = 0; month < 6; month++)
            {
                depreciation = depreciation * 0.95f;
                Console.WriteLine($"{month + 1}\t{depreciation}");

            }


        }




        //main process or when run...
        static void Main(string[] args)
        {
            Title();

            string proceed = "";
            while (proceed.Equals(""))
            {
               

                OneDevice();

                proceed = CheckProceed();

              
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nThank you for using insurance app\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
