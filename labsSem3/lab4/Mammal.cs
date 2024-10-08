using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Mammal
    {
        public string Name {  get; set; }
        public int Age { get; set; }
        public bool IsWild { get; set; }
        public Mammal(string name, int age, bool isWild)
        {
            Name = name;
            Age = age;
            IsWild = isWild;
        }
    }
}
