using Classes.ObjectClass;
using Classes.Properties;
using Classes.Properties.Derivations;

namespace Classes;

class Program
{
    static void Main(string[] args)
    {
        //What is OOP?
        // Object-oriented programming has several advantages over procedural programming:
        // 
        // OOP is faster and easier to execute
        // OOP provides a clear structure for the programs
        // OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain,
        // modify and debug
        // OOP makes it possible to create full reusable applications with less code and shorter development time

        // Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code.
        // You should extract out the codes that are common for the application, and place them at
        // a single place and REUSE them instead of REPEATING it.

        // defining class members that is not defined, especially useful when creating
        // multiple objects of one class

        Car Ford = new Car();
        Ford.model = "Mustang";
        Ford.color = "red";
        Ford.year = 1969;

        Car Opel = new Car();
        Opel.model = "Astra";
        Opel.color = "white";
        Opel.year = 2005;

        Console.WriteLine(Ford.model);
        Console.WriteLine(Opel.model);
        Opel.fullThrottle();

        //AnotherCarClass FordAnother = new AnotherCarClass();
        AnotherCarClass FordAnother = new AnotherCarClass("mustang", "red", 1969);
        //you will notice that constructors are very useful, as they help reducing the amount of code
        AnotherCarClass OpelAnother = new AnotherCarClass("astra", "white", 2005);

        Console.WriteLine(FordAnother.model);
        Console.WriteLine(OpelAnother.model);

        Person myPerson = new Person();
        myPerson.Name = "Yunus";
        Console.WriteLine(myPerson.Name);

        string surname = myPerson.surname;
        Console.WriteLine("surname: " + surname);

        //myPerson.surname = "new Surname";
        //above lines gives Property or indexer 'Person.surname' cannot be assigned to -- it is read only
        Apple myApple = new Apple("it is a apple red bro");
        Console.WriteLine("fruit Name" + myApple.Name);
        Console.WriteLine("Fruit is grow on tree: " + myApple.GrowOnTree);
        Console.WriteLine("custom fruit variable" + myApple.AppleCustomParamter);

        //Polymorphism
        Animal myAnimal = new Animal();
        Cat myCat = new Cat();
        Dog myDog = new Dog();
        myAnimal.animalSound();
        myCat.animalSound();
        myDog.animalSound();
    }
}