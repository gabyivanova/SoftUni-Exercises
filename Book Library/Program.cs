using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BookLibraryModification
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public long ISBN { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library() { Name = "SomeName", Books = GetBooks() };
            string sDate = Console.ReadLine();
            DateTime specialDate = DateTime.ParseExact(sDate, "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var book in library.Books.Where(x => x.ReleaseDate > specialDate).OrderBy(y => y.ReleaseDate).ThenBy(z => z.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}");
            }
        }

        public static List<Book> GetBooks()
        {
            int count = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();

            for (int i = 0; i < count; i++)
            {
                var book = Console.ReadLine().Split(' ').ToList();
                var title = book[0];
                var author = book[1];
                var publisher = book[2];
                var releaseDate = DateTime.ParseExact(book[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                var isbn = long.Parse(book[4]);
                var price = double.Parse(book[5]);

                Book newBook = new Book();

                newBook.Title = title;
                newBook.Author = author;
                newBook.Publisher = publisher;
                newBook.ReleaseDate = releaseDate;
                newBook.ISBN = isbn;
                newBook.Price = price;

                books.Add(newBook);
            }

            return books;
        }
    }
}
