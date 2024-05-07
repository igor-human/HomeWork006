using System;
using System.Text;
using Task_04;


namespace _005_Book
{
    

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 5, 7, 4, 2, 4, 9, 2 };

            Console.WriteLine(String.Join(", ", numbers));

            numbers.SortAscending();

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
