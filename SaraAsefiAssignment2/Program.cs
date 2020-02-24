using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaraAsefiAssignment2
{
    class Program
    {
        // method for reading the triangle dimention
        public static int ReadDimention()
        {
            bool validInput = false;
            int dimention = 0;

            do
            {
                string input = "";
                Console.Write("Please enter an integer for triangle dimnetion: ");
                input = Console.ReadLine();

                try
                {
                    if (int.TryParse(input, out dimention))
                    {
                        if (dimention > 0)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter an "
                                              + "integer > 0.");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter an integer.");
                        Console.WriteLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input! Please enter an integer.");
                    Console.WriteLine();
                }

            } while (!validInput);
            return dimention;
        }

        // method for creating the main menu 
        public static int MainMenu()
        {
            bool validInput = false;
            int selectedOption = 0;

            do
            {
                string stringSelectedOption = "";

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("*******************************"
                                  + "*************");
                Console.WriteLine("Main Menu");
                Console.WriteLine("\t1. Enter triangle dimentions");                
                Console.WriteLine("\t2. Exit\n");
                Console.Write("Please select a menu option:  ");
                stringSelectedOption = Console.ReadLine();
                Console.WriteLine();

                try
                {
                    selectedOption = int.Parse(stringSelectedOption);
                    if (selectedOption > 0 && selectedOption <= 2)
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Select, Please Pick "
                                          + "a number between 1 and 2");
                        Console.WriteLine();
                        Console.WriteLine("press any key to return to menu");
                        Console.ReadKey();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input, please try again");
                    Console.WriteLine();
                    Console.WriteLine("press any key to return to menu");
                    Console.ReadKey();
                }
            } while (!validInput);
            return selectedOption;
        }


        static void Main(string[] args)
        {
            int dim1;
            int dim2;
            int dim3;
            int menuOption;

            do
            {
                menuOption = MainMenu();

                switch (menuOption)
                {
                    case 1:
                        Console.WriteLine("First dimention : " );
                        dim1 = ReadDimention();
                        Console.WriteLine();

                        Console.WriteLine("Second dimention : ");
                        dim2 = ReadDimention();
                        Console.WriteLine();

                        Console.WriteLine("Third dimention : ");
                        dim3 = ReadDimention();
                        Console.WriteLine();

                        Console.WriteLine("Triangle dimentions: " + dim1 + "," + dim2 + "," + dim3);
                        Console.WriteLine(TriangleSolver.Analyze(dim1,dim2, dim3));
                        Console.ReadKey();

                        Console.WriteLine("Press akey to go back to menu.");
                        Console.ReadKey();
                        break;                    

                    case 2:
                        Console.WriteLine("Good bye!");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Invalid menu option,try again!");
                        Console.WriteLine("press any key to return to menu");
                        Console.ReadKey();
                        break;
                }
            } while (menuOption != 2);
            
        }
    }
}
