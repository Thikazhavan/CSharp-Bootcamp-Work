namespace Day1_Activity3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Celsius : ");
            String Celsius = Console.ReadLine();
            double C = double.Parse(Celsius);
            int F = (int)((C * 9 / 5) + 32);
            Console.WriteLine(C + "°C is equal to " + F + "°F.");
        }
    }
}
