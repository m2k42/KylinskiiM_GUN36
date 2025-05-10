using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number 1");

        if (!Int32.TryParse(Console.ReadLine (), out var a))
        {
            Console.WriteLine("Not a number");
         return;
        }

        Console.WriteLine("Enter the number 2");

        if (!Int32.TryParse(Console.ReadLine(), out var b))
        {
            Console.WriteLine("Not a number");
            return;
        }

        Console.WriteLine("Choose an operation : +,-,/,*,%,&,^");

        var s= Console.ReadLine();
        var boolVar = true;
        if (s.Length == 0 || s.Length > 1 && !boolVar)
        { 
            Console.WriteLine("Wrong sign");
            return;
        }
        switch (s[0])
        {
            case '+':
                Console.WriteLine("Resalt of {0} + {1} ={2}", a, b, a + b);
                Console.WriteLine(Convert.ToString(a + b, 2));
                Console.WriteLine(Convert.ToString(a + b, 16));
                break;

            case '-':
                Console.WriteLine("Resalt of {0} - {1} ={2}", a, b, a - b);
                Console.WriteLine(Convert.ToString(a - b, 2));
                Console.WriteLine(Convert.ToString(a - b, 16));
                break;
            case '/':
                Console.WriteLine("Resalt of {0} / {1} ={2}", a, b, a / b);
                Console.WriteLine(Convert.ToString(a / b, 2));
                Console.WriteLine(Convert.ToString(a / b, 16));
                break;
            case '*':
                Console.WriteLine("Resalt of {0} * {1} ={2}", a, b, a * b);
                Console.WriteLine(Convert.ToString(a * b, 2));
                Console.WriteLine(Convert.ToString(a * b, 16));
                break;
            case '%':
                Console.WriteLine("Resalt of {0} % {1} ={2}", a, b, a % b);
                Console.WriteLine(Convert.ToString(a % b, 2));
                Console.WriteLine(Convert.ToString(a % b, 16));
                break;
            case '^':
                Console.WriteLine("Resalt of {0} ^ {1} ={2}", a, b, a ^ b);
                Console.WriteLine(Convert.ToString(a ^ b, 2));
                Console.WriteLine(Convert.ToString(a ^ b, 16));
                break;
            case '&':
                Console.WriteLine("Resalt of {0} & {1} ={2}", a, b, a & b);
                Console.WriteLine(Convert.ToString(a & b, 2));
                Console.WriteLine(Convert.ToString(a & b, 16));
                break;
            default:
                Console.WriteLine("Wrong sign");
                break;
        }


        
        
        
        
        
    }
   
    
}