using System;
using System.Diagnostics;
using System.IO;
using System.Threading; 

namespace lab_04_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            x = x + 10;
            int y = x * x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Trace.WriteLine($"Trace WriteLine  {i}");
                Debug.WriteLine($"Debug writeLine {i}");
                Debug.WriteLineIf(i == 6, "Hey, i is 6!!!");
                File.AppendAllText("log.dat", $"Logging i={i} at {DateTime.Now}");
                Console.WriteLine("//");
                Console.WriteLine("\n Hello\nHellow\nHello");
                File.AppendAllText(@"c:\log\log.dat", $"Logging i=[i] at {DateTime.Now}");
                //File.AppendAllText("c: \log\log.dat", $"Logging i={i} at {DateTime.Now}
                // note:\ is a special character 
                // use '@' to provide clean 
                

            }
            Console.ReadLine();
        }
    }
}
