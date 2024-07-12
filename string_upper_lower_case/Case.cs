using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_upper_lower_case
{
    internal class Case
    {
        string name = "";
        string new_name = "";

        public void Input()
        {
        Console.WriteLine("enter a string name ");
            name = Console.ReadLine();
        }
        public void process()
        {
            foreach(char n in name)
            {
                if (n >= 65 && n <= 91)
                {
                    new_name = new_name + Convert.ToChar(n + 32);
                }
                else if (n >= 97 && n <= 122)
                {
                    new_name = new_name + Convert.ToChar(n - 32);
                }
            }
        }
        public void Display()
        {
            Console.WriteLine(new_name);
        }
    }
}
