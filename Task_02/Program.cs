using System;
using System.Text;
using Task_02;


namespace _005_Book
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("слово");

            Console.ReadLine();
        }
    }
}
