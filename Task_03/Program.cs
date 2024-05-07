using System;
using System.Text;
using Task_03;


namespace _005_Book
{
    class Book
    {
        public string Title { get; set; }
        public List<Notes> NotesList { get; set; }

        public Book(string title)
        {
            Title = title;
            NotesList = new List<Notes>();
        }
        
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

        public void AddNote(string str)
        {
            var note = new Notes(str);
            NotesList.Add(note);
            Console.WriteLine("Замітку додано до книги" + Title + " " + str);
        }

        public void DisplayNotes()
        {
            Console.WriteLine("Замітки для книги " + Title + ":");
            foreach (var note in NotesList)
            {
                Console.WriteLine(" - " +  note.Text);
            }
        }
        public class Notes
        {
            public string Text { get; }

            public Notes(string text)
            {
                Text = text;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Моя улюблена книга ");

            book.AddNote("Нотатка до книги");

            book.DisplayNotes();

            FindAndReplaceManager.FindNext("слово");

            Console.ReadLine();
        }
    }
}
