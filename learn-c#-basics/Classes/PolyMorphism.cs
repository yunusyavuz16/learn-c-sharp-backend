namespace Classes;

public class PolyMorphism
{
    public class Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound hav hav");
        }
    }

    public class Cat : Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound meaw meaw");
        }
    }
}