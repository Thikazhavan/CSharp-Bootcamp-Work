namespace Day1_Activity5_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Width of a rectangle :");
            String W = Console.ReadLine();
            int Width = int.Parse(W);

            Console.WriteLine("Height of a rectangle :");
            String H = Console.ReadLine();
            int Height = int.Parse(H);

            int RArea = (Width * Height);
            Console.WriteLine(RArea);

            Console.WriteLine("Radius of a circle :");
            String r = Console.ReadLine();
            int radius = int.Parse(r);

            int PI = (int)Math.PI;
            int CArea = (PI * radius * radius);
            Console.WriteLine(CArea);
        }
    }
}
