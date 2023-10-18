using System;
using HelloWorld;
using Tutorial.ApplyKnowledgeProblemOne;
using Tutorial.String;

namespace Tutorial
{
    class Program
    {
        //Another thing that always appear in a C# program, is the Main method.
        //Any code inside its curly brackets {} will be executed.
        //You don't have to understand the keywords before and after Main.
        //You will get to know them bit by bit while reading this tutorial.
        static void Main(string[] args)
        {
            //This is our habit for the beginning!
            var newWorld = new HelloWorldWrite();
            //comment example
            /* The code below will print the words Hello World
                to the screen, and it is amazing */
            newWorld.HelloWorldWriteFunction();

            var newClass = new StringMethods();
            newClass.GetMyFullName();
            //in static public this is the way;
            StringMethods.MyFullName();

            //lets loop
            var myCarClass = new ArrayLoop.ArrayLoop();
            myCarClass.loopArrayMethod();

            var firstProblemSolution = new TutorialProblem();
            int average = firstProblemSolution.findAverage();
            firstProblemSolution.commentAverage(average);
        }
    }
}