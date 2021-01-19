using System;

namespace Lab__02
{
    class Program
    {
        static void Main(string[] args)
        {

            string yesOrNo;
            
            
            Console.WriteLine("Welcome to the room calculator!"); // only comes up first time
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.Write("Please enter the room length "); // length functions
                var length = Console.ReadLine();
                var roomLength = double.Parse(length);
                Console.WriteLine($"you have entered  {roomLength}");

                Console.WriteLine();

                Console.Write("Please enter the room width "); // width functions
                var width = Console.ReadLine();
                var roomWidth = double.Parse(width);
                Console.WriteLine($"you have entered  {roomWidth}");

                Console.WriteLine();

                Console.Write("Please enter the room height "); // height functions
                var height = Console.ReadLine();
                var roomHeight = double.Parse(height);
                Console.WriteLine($"you have entered  {roomHeight}");

                Console.WriteLine();

                Console.WriteLine($"The perimeter of the room is  {(roomLength * 2) + (roomWidth * 2)} "); //perimeter calculation
                Console.WriteLine();
                Console.WriteLine($"The area of the room is  {(roomLength * roomWidth)} "); //area calculation
                Console.WriteLine();
                Console.WriteLine($"The volume of the room is  {(roomLength * roomWidth * roomHeight)}"); //volume calculation
                Console.WriteLine();

                Console.WriteLine("Would you like to try again? (y/n)");
                yesOrNo = Console.ReadLine();
                

            } while (yesOrNo == "y");
            

            Console.WriteLine();
            Console.WriteLine("Goodbye");
            Console.ReadLine();

        }
    }
}
