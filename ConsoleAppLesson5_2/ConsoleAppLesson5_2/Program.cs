using System;
using System.Collections.Generic;

namespace ConsoleAppLesson5_2
{
    class Program
    {
        public enum Weekdays 
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
                
        {
            //Create a list to hold tasks
            List<string> taskList = new List<string>();

            //for each value in the Enum...let the user create a task.
            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))

        {
            Console.WriteLine("Enter a new task for " + day);
            string task = day + " : " + Console.ReadLine();
            taskList.Add(task);

        }

            //print all of the tasks.
            foreach (string task in taskList)

        {
            Console.WriteLine(task);
            }
        }
    }
}
