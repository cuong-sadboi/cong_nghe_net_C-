
using System;

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Age: {Age}");
    }
}
public class Dog : Animal
{
    public string Breed { get; set; }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Breed: {Breed}");
    }
}

class Program
{
    static void Main(string[] args)

    {
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Age = 3;
        dog.Breed = "Golden Retriever";

        dog.DisplayInfo();
    }
}
