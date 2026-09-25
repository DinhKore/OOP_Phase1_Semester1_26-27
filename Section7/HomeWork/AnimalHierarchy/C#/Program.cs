using System;

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Buddy", "Woof", "Golden Retriever");
        Cat cat = new Cat("Whiskers", "Meow", "Black");
        Bird bird = new Bird("Tweety", "Chirp", true);

        Console.WriteLine(dog.ToString());
        Console.WriteLine(cat.ToString());
        Console.WriteLine(bird.ToString());
    }
}