namespace ClassExercises
{
    internal class Program
    {
        static void Main()
        {
            
                double number13, number22, number3, number4, number5;

                Console.Write("Enter the First number: ");
                number13 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the Second number: ");
                number22 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the third number: ");
                number3 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the fourth number: ");
                number4 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the fifth number: ");
                number5 = Convert.ToDouble(Console.ReadLine());

                double result = (number13 + number22 + number3 + number4 + number5) / 5;
            Console.WriteLine("The average of {0}, {1}, {2}, {3}, {4} is: {5}",
            number13, number22, number3, number4, number5, result);
             //Redo at home 
             //

        }
    }
}
