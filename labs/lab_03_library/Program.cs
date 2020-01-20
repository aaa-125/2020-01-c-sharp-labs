using System;
using lab_03_library_files;
namespace lab_03_use_library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myinstance = new MyClass();
            Console.WriteLine(myinstance.DoubleUp(10));
            Console.WriteLine(myinstance.GravitationalConstant);

            Console.WriteLine(myinstance.AlsoTripUp);
            Console.WriteLine(myinstance.);


        }
    }
}
