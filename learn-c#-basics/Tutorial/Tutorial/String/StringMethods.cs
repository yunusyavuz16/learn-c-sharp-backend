namespace Tutorial.String;

public class StringMethods
{
    private string myName = "Yunus";
    private string mySurName = "Yavuz";
    private string myFullName;


    // if we define the myFullName in this line,we use instance fields
    // (myName, mySurName, and myFullName) within
    // the class definition, which is a static context.
    // To fix this issue we need to understand
    // the difference between static and instance members in C#.

    // -> Instance members, on the other hand,
    // -> belong to instances of the class (objects) and cannot be accessed directly within a static context.
    public void GetMyFullName()
    {
        myFullName = $"{myName} {mySurName} ";
        Console.WriteLine(myFullName);
    }


    // ->> Static members belong to the class itself and can be accessed without
    // ->> creating an instance of the class.
    static string myStaticName = "Yunus";
    static string myStaticSurName = "Yavuz";
    static string myStaticFullName = $"{myStaticName} {myStaticSurName} ";

    public static void MyFullName()
    {
        Console.WriteLine(myStaticFullName);
    }
}