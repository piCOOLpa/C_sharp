using System;

namespace c_sharp_input_output_user_cs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            // Console.ReadLoine() return a string as output  , so we need to explicitly convert it to int 

            // display the output in the console.

            // ERROR ----->  string stream = Console.WriteLine();  as return type of the Console.Writeline() is void 
            Console.WriteLine("entered number is : " + num);
            // print the statement to the output console.

            Console.WriteLine();

        }
    }
}
