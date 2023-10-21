namespace Classes;

public class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

public class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The animal makes a sound hav hav");
    }
}

public class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The animal makes a sound meaw meaw");
    }
}