using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class ListTask
        {
            private readonly List<string> _listOfStrings = new List<string>();

            public void TaskLoop()
            {
                Console.WriteLine("--- Task 1:Working with a list of strings ---");
                Console.WriteLine("Enter 'esc' to exit");

                
                _listOfStrings.AddRange(new[] { "one", "two", "three" });

                while (true)
                {
                    Console.WriteLine("The current list:");
                    foreach (var item in _listOfStrings)
                    {
                        Console.WriteLine(item);
                    }

                    Console.Write("enter a new line to add to the end:");
                    string input = Console.ReadLine();
                    if (input == "esc") break;

                    _listOfStrings.Add(input);

                    Console.Write("Enter a line to add to the middle: ");
                    input = Console.ReadLine();
                    if (input == "esc") break;

                    _listOfStrings.Insert(_listOfStrings.Count / 2, input);
                }
            }
        }

        public class DictionaryTask
        {
            private readonly Dictionary<string, int> _studentGrades = new Dictionary<string, int>();

            public void TaskLoop()
            {
                Console.WriteLine("Task 2: Dictionary of students and grades");
                Console.WriteLine("Enter 'esc' to exit");

                while (true)
                {
                    Console.Write("Enter the student's name: ");
                    string name = Console.ReadLine();
                    if (name == "esc") break;

                    Console.Write("Enter the rating (2-5): ");
                    if (!int.TryParse(Console.ReadLine(), out int grade) || grade < 2 || grade > 5)
                    {
                        Console.WriteLine("Error: the score should be a number from 2 to 5");
                        continue;
                    }

                    _studentGrades[name] = grade;

                    Console.Write("Enter the student's name to search for: ");
                    name = Console.ReadLine();
                    if (name == "esc") break;

                    if (_studentGrades.TryGetValue(name, out int foundGrade))
                    {
                        Console.WriteLine($"Student assessment {name}: {foundGrade}");
                    }
                    else
                    {
                        Console.WriteLine($"Student {name} not found");
                    }
                }
            }
        }

        public class DoublyLinkedListTask
        {
            private class Node
            {
                public string Data { get; set; }
                public Node Previous { get; set; }
                public Node Next { get; set; }

                public Node(string data)
                {
                    Data = data;
                }
            }

            private Node _head;
            private Node _tail;

            public void TaskLoop()
            {
                Console.WriteLine(" Task 3: A doubly linked list");
                Console.WriteLine("Enter 'esc' to exit");
                Console.WriteLine("Enter from 3 to 6 items:");

                int count = 0;
                while (count < 6)
                {
                    Console.Write($"items {count + 1}: ");
                    string input = Console.ReadLine();
                    if (input == "esc") break;

                    Add(input);
                    count++;

                    if (count == 6)
                    {
                        Console.WriteLine("The maximum has been reached (6 elements)");
                        break;
                    }
                }

                if (count < 3)
                {
                    Console.WriteLine("Less than 3 elements have been entered. We add the default elements.");
                    AddRange(new[] { "Element1", "Element2", "Element3" });
                }

                Console.WriteLine("The list is in direct order:");
                PrintForward();

                Console.WriteLine("The list is in reverse order:");
                PrintBackward();
            }

            private void Add(string data)
            {
                Node newNode = new Node(data);
                if (_head == null)
                {
                    _head = newNode;
                    _tail = newNode;
                }
                else
                {
                    newNode.Previous = _tail;
                    _tail.Next = newNode;
                    _tail = newNode;
                }
            }

            private void AddRange(IEnumerable<string> items)
            {
                foreach (var item in items)
                {
                    Add(item);
                }
            }

            private void PrintForward()
            {
                Node current = _head;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Next;
                }
            }

            private void PrintBackward()
            {
                Node current = _tail;
                while (current != null)
                {
                    Console.WriteLine(current.Data);
                    current = current.Previous;
                }
            }
        }

        
   
