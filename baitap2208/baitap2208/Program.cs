using System;
using System.Collections.Generic;
namespace baitap2208
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
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    //class Student : Person
    //{
        //public string StudentID { get; set; }
        //public void Study()
        //{
           // Console.WriteLine($"{Name} is studying.");
        //}
    //}
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Square : Shape
    {
        public double Side { get; set; }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
    abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Gau! Gau!");
        }
    }
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
    }
    class Student
    {
        public string Name { get; set; }
        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

        public void Enroll(Course course)
        {
            Enrollments.Add(new Enrollment { Course = course, Student = this });
        }
    }
    class Enrollment
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
    class Course
    {
        public string CourseName { get; set; }
    }
    class Book
    {
        public string Title { get; set; }
    }
    class Member
    {
        public string Name { get; set; }
        public List<Loan> Loans { get; set; } = new List<Loan>();
        public void BorrowBook(Book book)
        {
            Loans.Add(new Loan { Book = book, Member = this });
        }
    }
    class Loan
    {
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
    class Employee

    {
        public string Name { get; set; }
    }
    class Manager : Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
    class Department
    {
        public string DepartmentName { get; set; }
        public Manager DepartmentManager { get; set; }
    }
    class Product
    {
        public string ProductName { get; set; }
    }
    class Customer
    {
        public string Name { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
    class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public Customer Customer { get; set; }
    }
    class Patient
    {
        public string Name { get; set; }
        public List<Appointment> Appointments { get; set; } = new List<Appointment>();

        public void BookAppointment(Doctor doctor)
        {
            Appointments.Add(new Appointment { Doctor = doctor, Patient = this });
        }
    }
    class Doctor
    {
        public string Name { get; set; }
    }
    class Appointment
    {
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
    internal class Program
    {
        // static void Main(string[] args)
        //{
        //Car car1 = new Car { Make = "Porsche", Model = "Taycan", Year = 2020 };
        //Car car2 = new Car { Make = "Honda", Model = "Civic", Year = 2019 };
        //car1.DisplayInfo();
        //car2.DisplayInfo();
        //Rectangle rectangle = new Rectangle { Length = 5.0, Width = 4.0 };
        //double area = rectangle.CalculateArea();
        //Console.WriteLine($"Area of Rectangle: {area}");
        //Student student = new Student { Name = "Nguyen Cuong", Age = 20, StudentID = "S12345" };
        //student.DisplayInfo();
        //student.Study();
        //Circle circle = new Circle { Radius = 3.0 };
        //Square square = new Square { Side = 4.0 };
        //Console.WriteLine($"Area of hinh tron: {circle.CalculateArea()}");
        //Console.WriteLine($"Area of hinh vuong: {square.CalculateArea()}");
        //}
        //static void Main(string[] args)
        //{
        //Animal dog = new Dog();
        //Animal cat = new Cat();
        //dog.MakeSound();
        //cat.MakeSound();
        //Student student = new Student { Name = "Cuong" };
        //Course course = new Course { CourseName = "Toan" };
        //student.Enroll(course);
        //Console.WriteLine($"{student.Name} da dang ky vao {student.Enrollments[0].Course.CourseName}");
        //Member member = new Member { Name = "Cuong" };
        //Book book = new Book { Title = "C# Programming" };
        //member.BorrowBook(book);
        //Console.WriteLine($"{member.Name} da muon {member.Loans[0].Book.Title}");
        //}
        //static void Main(string[] ards)
        //{
        //Manager manager = new Manager { Name = "Cuong" };
        //Department department = new Department { DepartmentName = "IT", DepartmentManager = manager };
        //Employee employee1 = new Employee { Name = "John" };
        //Employee employee2 = new Employee { Name = "Anna" };
        //manager.Employees.Add(employee1);
        //manager.Employees.Add(employee2);
        //Console.WriteLine($"{manager.Name} quan ly {manager.Employees.Count} nhan vien o bo phan {department.DepartmentName}.");
        //Customer customer = new Customer { Name = "Cuong" };
        //Product product1 = new Product { ProductName = "Laptop" };
        //Product product2 = new Product { ProductName = "Mouse" };
        //Order order = new Order { Customer = customer };
        //order.Products.Add(product1);
        //order.Products.Add(product2);
        //customer.Orders.Add(order);
        // Console.WriteLine($"{customer.Name} da dat hang voi {order.Products.Count} san pham.");
        //}
        static void Main(string[] ards)
        {
            Patient patient = new Patient { Name = "Cuong" };
            Doctor doctor = new Doctor { Name = "bac si Anh" };

            patient.BookAppointment(doctor);

            Console.WriteLine($"{patient.Name} da co cuoc hen voi {patient.Appointments[0].Doctor.Name}");
        }
    }
}
