using System;

// Lớp cơ sở
public class Animal
{
    public string Name { get; set; }
    public string Sound { get; set; }

    public Animal(string name, string sound)
    {
        Name = name;
        Sound = sound;
    }
}

// Lớp kế thừa 1
public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string sound, string breed) : base(name, sound)
    {
        Breed = breed;
    }

    public override string ToString()
    {
        return $"Dog [Name: {Name}, Sound: {Sound}, Breed: {Breed}]";
    }
}

// Lớp kế thừa 2
public class Cat : Animal
{
    public string Color { get; set; }

    public Cat(string name, string sound, string color) : base(name, sound)
    {
        Color = color;
    }

    public override string ToString()
    {
        return $"Cat [Name: {Name}, Sound: {Sound}, Color: {Color}]";
    }
}

// Lớp kế thừa 3
public class Bird : Animal
{
    public bool CanFly { get; set; }

    public Bird(string name, string sound, bool canFly) : base(name, sound)
    {
        CanFly = canFly;
    }

    public override string ToString()
    {
        return $"Bird [Name: {Name}, Sound: {Sound}, CanFly: {CanFly}]";
    }
}