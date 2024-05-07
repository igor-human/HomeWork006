using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public static class ArrayExtension
    {
        public static void SortAscending(this int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            Array.Sort(array);
        }
    }
}
