namespace Day1_Activity4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            string num1 = Console.ReadLine();
            int n1 = int.Parse(num1);

            Console.WriteLine("Enter a number :");
            string num2 = Console.ReadLine();
            int n2 = int.Parse(num2);

            int Sum = (n1 + n2);
            Console.WriteLine("The sum is: " + Sum);

            int Difference = (n1 - n2);
            Console.WriteLine("The Difference is: " + Difference);

            int Product = (n1 * n2);
            Console.WriteLine("The Product is: " + Product);

            double quotient = (int)((double)n1 / n2);
            Console.WriteLine("The quotient is: " + quotient);
        }
    }
}
