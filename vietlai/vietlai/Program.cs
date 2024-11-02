using System.Reflection.Metadata.Ecma335;

namespace vietlai
{
    internal class Program
    {
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public void DisplayInfo()
            {
                Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
            }
        }
        class Rectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double CalculateArea()
            {
                return Length * Width;
            }
        }
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public void DisplayInfo()
            {
                Console.WriteLine($"{Name} co tuoi la {Age} la hoc sinh");
            }
        }
        class Student : Person
        {
            public string StudentID { get; set; }
            public void Study()
            {
                Console.WriteLine(
            }
        }
        static void Main(string[] args)
        {
            Car car1 = new Car { Make = "Posche", Model = "Taycan", Year = 2000 };
            car1.DisplayInfo();
            Car car2 = new Car { Make = "Honda", Model = "Civic", Year = 2020 };
            car2.DisplayInfo();
            Rectangle hcn = new Rectangle { Width = 5, Length = 6 };
            double dt = hcn.CalculateArea();
            Console.WriteLine("Dien tich hcn la: " + dt);
        }
    }
}
