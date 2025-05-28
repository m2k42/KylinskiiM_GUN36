using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select a task (1, 2, or 3):");
        Console.WriteLine("Task 1: Working with a list of strings");
        Console.WriteLine("Task 2: Dictionary of students and grades");
        Console.WriteLine("Task 3: A doubly linked list");

        if (!int.TryParse(Console.ReadLine(), out int task) || task < 1 || task > 3)
        {
            Console.WriteLine("Error: enter a number from 1 to 3");
            return;
        }

        switch (task)
        {
            case 1:
                CheckTaskFirst();
                break;
            case 2:
                CheckTaskSecond();
                break;
            case 3:
                CheckTaskThird();
                break;
        }
    }

    private static void CheckTaskFirst()
    {
        var task = new ListTask();
        task.TaskLoop();
    }

    private static void CheckTaskSecond()
    {
        var task = new DictionaryTask();
        task.TaskLoop();
    }

    private static void CheckTaskThird()
    {
        var task = new DoublyLinkedListTask();
        task.TaskLoop();
    }
}
