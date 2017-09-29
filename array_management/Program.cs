using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_management
{

    class DisplayMenu
    {
        public static void Menu () //  Display Main Menu
        {

            Console.WriteLine("Choose from the following options:\n");
            Console.WriteLine("0 - exit program");
            Console.WriteLine("1 - Input an array and display the reversed array");
            Console.WriteLine("2 - Display muliplication table");
           
        }
    }

    class Inputs
    {
        public static int InputInt(string statement, int min, int max)
        {
            int returnVal = -1;
            while (returnVal == -1)
            {
                try
                {
                    Console.WriteLine(statement);
                    returnVal = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Try again.");
                }
            }

            return returnVal;
        }

        public static int InputInt(string statement, int min)
        {
            int returnVal = -1;
            while (returnVal == -1)
            {
                try
                {
                    Console.WriteLine(statement);
                    returnVal = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("try again.");
                }
            }

            return returnVal;
        }


    }


    class Program
    {




        public static void MultiplicationTable ()
        {
            int arrayLength = Inputs.InputInt("Enter size of multiplication table: ", 1);

            int[,] timesTable = new int[arrayLength, arrayLength];
            Console.WriteLine("Multiplication table is:\n");

            for (int i = 0; i < arrayLength; i++)
            {
                for (int k = 0; k < arrayLength; k++)
                {
                    timesTable[i, k] = (i + 1) * (k + 1);
                    Console.Write("{0,-10} ", timesTable[i, k]);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }


        public static void calcReverseArray()
        {
            Console.WriteLine("\n");

            int arrayLength = Inputs.InputInt("Enter array size (minimum 1) : ", 1);

            int[] arr = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Enter value for element {0}: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("array element {0} = {1}", i, arr[i]);
            }

            int[] arrReverse = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                arrReverse[i] = arr[arrayLength - (i + 1)];
                Console.WriteLine("Reverse Array - element {0} = {1}", i, arrReverse[i]);

            }

            string[] towns = { "London", "New York", "Sydney" };

            int j = 0;
            foreach (string town in towns)
            {
                Console.WriteLine("towns array element {0} = {1}", j, town);
                j++;
            }
        }




        static void Main(string[] args)
        {

            
            DisplayMenu.Menu();

            int selection = Inputs.InputInt("", 0, 2);

            while (selection != 0)
            {
                switch (selection)
                {
                    case 1:
                        Program.calcReverseArray();
                        selection = -1;
                        continue;
                    case 2:
                        Program.MultiplicationTable();
                        selection = -1;
                        continue;
                    case 0:
                        break;
                    

                }

            }




        }
    }
}
