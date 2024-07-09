using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace _04_Duck
{
    internal class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
                return -1;
            if (x.Kind > y.Kind)
                return 1;
            return 0;
        }
    }
}
