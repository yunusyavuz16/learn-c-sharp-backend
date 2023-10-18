namespace Tutorial.ArrayLoop;

public class ArrayLoop
{
    // I do not want to acces someone my favourite cars so it is private
    private string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

    //primitive for loop
    public void loopArrayMethod()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            string item = cars[i];
            if (cars.Length - 1 != i)
            {
                Console.Write(item + ',' + ' ');
            }
            else
            {
                Console.WriteLine(item);
            }
        }

        //what about forEach
        foreach (var car in cars)
        {
            Console.Write(car);
        }
    }
}