using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            (string FirstLetter, int TheNumber, string SecondLetter) values = ("a", 5, "c");
            var values2 = (FirstLetter:"b", TheNumber:6, SecondLetter:"d");
            Console.WriteLine($"First item: {values.Item1}");
            Console.WriteLine($"Second item: {values.Item2}");
            Console.WriteLine($"Third item: {values.Item3}");

            Console.WriteLine($"First item: {values2.FirstLetter}");
            Console.WriteLine($"Second item: {values2.TheNumber}");
            Console.WriteLine($"Third item: {values2.SecondLetter}");

            Console.WriteLine("Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");

            var samples = FillTheseValues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Bool is: {samples.c}");
            Console.WriteLine();

            var Names = SplitNames("Jay John Jameson");
            Console.WriteLine($"Firstname is: {Names.name}");
            Console.WriteLine($"Secondname is: {Names.secondName}");
            Console.WriteLine($"Thirdname is: {Names.thirdName}");
            Console.WriteLine();

            Console.ReadLine();
        }
        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }
        static (string name, string secondName, string thirdName) SplitNames(string fullName)
        {
            string name = fullName.Substring(0, fullName.IndexOf(' '));
            fullName = fullName.Remove(0, (name.Length + 1));
            string sName = fullName.Substring(0, fullName.IndexOf(' '));
            fullName = fullName.Remove(0, (sName.Length + 1));
            string tName = fullName;
            return (name, sName, tName);
        }
    }
}
