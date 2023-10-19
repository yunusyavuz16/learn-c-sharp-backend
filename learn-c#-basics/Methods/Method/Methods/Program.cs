namespace Methods;

class Program
{
    static void MyMethod(string toDoName = "check the plan")
    {
        Console.WriteLine("I just got executed!");
        Console.WriteLine(toDoName);
    }

    static int calculateMyAge(int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;
        return age;
    }

    static void Main(string[] args)
    {
        // General Information 

        // static means that the method belongs to the
        // Program class and not an object of the Program class.
        // You will learn more about objects and how to access methods through objects later in this tutorial.
        // void means that this method does not have a return value.
        // You will learn more about return values later in this chapter
        MyMethod();
        MyMethod("no check today");
        int myAge = calculateMyAge(2002);
        Console.WriteLine(myAge);
    }
}