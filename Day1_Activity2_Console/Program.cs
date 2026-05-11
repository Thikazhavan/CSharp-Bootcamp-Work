namespace Day1_Activity2_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name : ");
            string first_name = Console.ReadLine();
            Console.WriteLine("Last Name : ");
            string last_name = Console.ReadLine();
            Console.WriteLine("Favorite Color : ");
            string favourite_color = Console.ReadLine();
            Console.WriteLine("User Bio: " + first_name + last_name +"'s favorite color is " + favourite_color + "." );
        }
    }
}
