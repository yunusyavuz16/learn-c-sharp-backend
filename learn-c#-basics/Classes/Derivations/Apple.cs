namespace Classes.Properties.Derivations;

public class Apple : Fruit
{
    public string AppleCustomParamter;

    public Apple(string appleCustomParamter) : base(true, "apple")
    {
        AppleCustomParamter = appleCustomParamter;
    }
}