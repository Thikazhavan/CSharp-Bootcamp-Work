namespace Day2_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Weight  (e.g. 70.5) ?");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("What is your Height (e.g. 1.75)?");
            double height = double.Parse(Console.ReadLine());

            double BMI;
            BMI = weight / (height*height);

            if (BMI < 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (BMI >= 18.5 && BMI <= 24.9)
            {
                Console.WriteLine("Normal weight");
            }
            else if (BMI >= 25 && BMI <= 29.9)
            {
                Console.WriteLine("Overweight");
            }
            else
            {
                Console.WriteLine("Obesity");
            }
        }
    }
}
