using _005_Book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Book book = new Book();
            book.FindNext(str);
        }
    }
}
