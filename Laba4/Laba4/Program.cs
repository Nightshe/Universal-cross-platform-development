using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>
            {
                new Book("451° за Фаренгейтом", "Рей Бредбері", "Фантастика", 1953),
                new Book("Маленький принц", "Антуан де Сент-Екзюпері", "Казка", 1943),
                new Book("Преступление и наказание", "Федор Достоевский", "Роман", 1866),
                new Book("Гаррі Поттер і філософський камінь", "Дж. К. Ролінг", "Фентезі", 1997),
                new Book("1984", "Джордж Оруелл", "Антиутопія", 1949),
                new Book("Мартин Иден", "Джек Лондон", "Роман", 1909)
            };

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Облік книг у бібліотеці\n");

            //1. Вибірка книг жанру "Роман"
            var romans = books.Where(b => b.Genre == "Роман");
            Console.WriteLine("Книги жанру 'Роман':");
            foreach (var book in romans)
                Console.WriteLine($"- {book.Title} ({book.Author})");

            //2. Отримати тільки назви книг (Select)
            var titles = books.Select(b => b.Title);
            Console.WriteLine("\nНазви усіх книг:");
            foreach (var title in titles)
                Console.WriteLine($"- {title}");

            //3. Взяти перші 3 книги за алфавітом (OrderBy + Take)
            var firstThree = books.OrderBy(b => b.Title).Take(3);
            Console.WriteLine("\nПерші 3 книги за алфавітом:");
            foreach (var book in firstThree)
                Console.WriteLine($"- {book.Title}");

            // 4. Сортування за роком видання (зміна порядку - OrderByDescending)
            var sortedByYear = books.OrderByDescending(b => b.Year);
            Console.WriteLine("\nСортування за роком видання (спадання):");
            foreach (var book in sortedByYear)
                Console.WriteLine($"- {book.Title} ({book.Year})");

            //5. Reverse — перевернути список
            var reversed = books.AsEnumerable().Reverse();
            Console.WriteLine("\nУ зворотному порядку:");
            foreach (var book in reversed)
                Console.WriteLine($"- {book.Title}");

            //6. ThenBy — другорядне сортування (за жанром, потім за роком)
            var multiSorted = books.OrderBy(b => b.Genre).ThenBy(b => b.Year);
            Console.WriteLine("\nСортування за жанром, потім за роком:");
            foreach (var book in multiSorted)
                Console.WriteLine($"- {book.Title} ({book.Genre}, {book.Year})");

            //7. Перевірити, чи є книги видані до 1950 року (Any)
            bool oldBooksExist = books.Any(b => b.Year < 1950);
            Console.WriteLine($"\nЧи є книги до 1950 року? {(oldBooksExist ? "Так" : "Ні")}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Book(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
        }
    }
}
