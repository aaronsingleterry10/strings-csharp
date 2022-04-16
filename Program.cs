using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Aaron Singleterry ";
            //Console.WriteLine("Trim: '{0}'", fullName.Trim());
            //Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            //Console.WriteLine("First: " + firstName);
            //Console.WriteLine("Last: " + lastName);

            var names = fullName.Split(' ');
            var first = names[0];
            var last = names[1];
            //Console.WriteLine(first);
            //Console.WriteLine(last);

            var update = fullName.Replace("a", "A");
            fullName.Replace(" ", "");

            //Console.WriteLine(update);

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);

            float price = 29.95f;

            Console.WriteLine(price.ToString("C0"));
        }
    }
}
