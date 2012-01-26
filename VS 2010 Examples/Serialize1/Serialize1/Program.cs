using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Serialize1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person
                        {
                            LastName = "Harris",
                            FirstName = "Scott"
                        };

            Console.Out.WriteLine("About to serialize the object...");
            Console.Out.WriteLine("");
            
            var s = new XmlSerializer(typeof(Person));
            s.Serialize(Console.Out, p);
            
            
            // deserialize 
            // exercise for the user

            Console.Out.WriteLine();

            Console.Out.WriteLine("Press Enter, yo!");
            Console.In.ReadLine();
        }
    }
}
