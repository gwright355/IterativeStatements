using System;
// Glenn Wright
// Iterative Statements
// Date: 1/22/2019


namespace IterativeStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value between 1 and 100");

            try
            {    // Start of try

                // This variable will gather input from the user

                string input = Console.ReadLine();



                int value_of_input = int.Parse(input);



                if ((value_of_input >= 1) && (value_of_input <= 100))

                {

                    Console.WriteLine("A For Loop will execute");

                    Console.WriteLine("You have entered: " + value_of_input.ToString());


                   // This is a for loop
                    for (int i = 0; i < value_of_input; i++)

                    {

                        Console.WriteLine("This is the current integer in the loop: " + i.ToString());

                    }

                    Console.WriteLine("To exit press any key");

                    Console.ReadKey(true);
                } // end of try
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");

                Console.WriteLine("Press any key to exit the program ...");

                Console.ReadKey(true);
            } // end of catch










            
         }  // end of main            
    } // end of class
} // end of namespace
