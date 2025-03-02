using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП
{
    internal class ClassCat
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string poroda { get; set; }

        public int tail { get; set; }
        public void SetTailLenth(int x)
        {
            if ((x > 5) & (x < 50)) ;
            {
                tail = x;
            }
        }
        public void GetTailLenght()
        {
            Console.WriteLine($"Длина хвоста - {tail} сантиметров");
        }
    }
}
