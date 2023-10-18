namespace Tutorial.ApplyKnowledgeProblemOne;

public class TutorialProblem
{
    //Write a C# program that calculates the average of a list of numbers.
    // 
    // Create an array or list of numbers (you can hardcode these values initially).
    // Use a loop to iterate through the array or list to calculate the sum of all the numbers.
    // Calculate the average by dividing the sum by the number of elements in the array or list.
    // Display the calculated average to the user.
    //
    //Write Line if the average is "above average," "below average," or "average" results.

    private int[] numbers = { 50, 42, 23, 15, 92, 12, 35, };

    public int findAverage()
    {
        int average;
        int sum = 0;
        foreach (var number in numbers)
        {
            sum += sum;
        }

        average = sum / numbers.Length;
        return average;
    }

    public string commentAverage(int average)
    {
        string message;
        if (average > 50)
        {
            message = "Below Average";
        }
        else if (average < 50)
        {
            message = "Above Average";
        }
        else
        {
            message = "Average";
        }

        Console.WriteLine(message);
        return message;
    }
}