using System;

namespace ForEachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            // todo array of strings
            string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
            // going over each item in the todo array
            foreach (string item in todo)
            {
                // placing each string in the array into the createtodoitem method
                CreateTodoItem(item);
            }
        }

        static void CreateTodoItem(string item)
        {
            Console.WriteLine($"[] {item}");
        }
    }
}
