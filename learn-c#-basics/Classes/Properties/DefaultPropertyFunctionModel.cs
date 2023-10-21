namespace Classes.Properties;

public class Person
{
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //short-hande usage
    public int myAge { get; set; } //read and also write
    public string surname { get; } //just read

    //here is comes
    //Why Encapsulation?
    // Better control of class members (reduce the possibility of yourself (or others) to mess up the code)
    // Fields can be made
    // READ-ONLY
    // (if you only use the get method), or
    // WRITE-ONLY
    // (if you only use the set method)
    // Flexible: the programmer can change one part of the code without affecting other parts
    // Increased security of data
    
    
}