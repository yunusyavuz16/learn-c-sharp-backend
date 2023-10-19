using Program.FirstStep;
using Program.SecondStep;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // There are some steps to create and manage a db for any business
            //
            // First Step: Write what you need in sentences
            // Second Step: Write the required business rules according to the needs
            // Third Step: Compose the required Class Diagram for the business rules that you wrote
            // Four Step: Compose the required Logic Diagram according to Class Diagram
            // Five Step: Make the database normalization

            Problem.writeIdea();
            Need.writeRequirements();
            BusinessRules.writeBusinessRules();
        }
    }
}