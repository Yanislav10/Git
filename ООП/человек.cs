using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class человек
    {
        public int age;
        public string name;
        public int Height;

        public void SetName(string new_name)
        {  name = new_name; }
        public void GetName()
        {
            Console.WriteLine($"Меня зовут {name}"); 
        }


        public class Child : человек
        { 
        Console.Wr
        }
    }
}
