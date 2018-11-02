using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---- for question #1
            //The open-closed method of Solid was used as we have our intial members as private 
            //and then we have public placeholders that can be used and manipulated later on.
            //This allows our code to be more secure moving forward so that we can not mess up past 
            //constructors and variables with new methods. 
            //
            // ---- for question #2
            // I think we use the single responsiblity idea becuase we are only making methods in the square class 
            // that make sense to the square, we can maybe put more basic ideas in the parent class if we want 
            // to have every child class inherit those methods. There could be methods in the square class that 
            // are specific to a square and so we would want to keep them in that for their own purpose.
            //
            testSquareAndShape();

            Console.WriteLine("Here is the output for the code that needed to be refactored and debugged");
            //Here is the Fixed code for Question #3
            int[] array1 = { 1, 2, 3, 4, 5, 6 };

            int result = GetSum(array1);
            Console.WriteLine(result);

        }
        public static int GetSum(int[] array1)
        {
            int sum = 0;
            foreach (int item in array1)
            {
                sum = sum + item;
            }
            return sum;
        }
        public static void testSquareAndShape()
        {
            Console.WriteLine("This is a blank shape being created(in an ideal world this is an interface but for the sake of this question it is a parent class)\n");
            IShape iShape = new IShape();
            iShape.Draw();
            Console.WriteLine();
            Console.WriteLine("Now we will create 2 square shapes that inherit from the shape parent class, one without anything passed, the other with an integer passed \n");
            Square square1 = new Square();
            square1.Draw();
            Console.WriteLine($"Here is the area of the square with nothing passed in the constructor: {square1.GetArea()}");
            Console.WriteLine();
            Square square2 = new Square(3);
            square2.Draw();
            Console.WriteLine($"Here is the area of the square with the int passed in the constructor: {square2.GetArea()}");
            Console.WriteLine();
        }    
    }
}
