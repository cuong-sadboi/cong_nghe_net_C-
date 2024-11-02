namespace UnsafeCode
{
    internal class Program
    {
        static unsafe void Main(string[] args)
        {
            int number1 = 53;
            int number2 = 41;

            int* p1 = &number1;
            int* p2 = &number2;

            Console.WriteLine($"Value of Number1 is: {number1}");
            Console.WriteLine($"Value of Address pt1 is: {*p1}");
            Console.WriteLine($"Value of Number2 is: {number2}");
            Console.WriteLine($"Value of Address pt2 is: {*p2}");
            Console.WriteLine("All done!");
        }
    }
}
