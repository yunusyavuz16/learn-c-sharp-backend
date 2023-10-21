namespace Classes.ObjectClass;

// A constructor is a special method that is used to initialize objects. The advantage of a constructor,
// is that it is called when an object of a class is created. It can be used to set initial values for fields:
public class AnotherCarClass
{
    public string model;
    public string color;
    public int year;

    // Create a class constructor with multiple parameters
    public AnotherCarClass(string modelName, string modelColor, int modelYear)
    {
        model = modelName;
        color = modelColor;
        year = modelYear;
    }
}