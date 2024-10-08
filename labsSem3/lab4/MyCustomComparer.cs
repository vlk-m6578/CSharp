using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class MyCustomComparer : IComparer<Mammal>
    {
        public int Compare(Mammal x, Mammal y)
        {
            return string.Compare(x?.Name, y?.Name, StringComparison.Ordinal);
        }
    }
}
