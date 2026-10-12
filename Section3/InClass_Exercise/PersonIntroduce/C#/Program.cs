using System;

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {Name}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creates one object and calls Introduce()
        Person myPerson = new Person("Dinh");
        myPerson.Introduce();
    }
}