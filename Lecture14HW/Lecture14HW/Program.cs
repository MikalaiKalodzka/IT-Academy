using System;
using System.Collections.Generic;
using System.Linq;
using Lecture14HW.Task1;
using Lecture14HW.Task2;
using Lecture14HW.Task3;

namespace Lecture14HW
{
    class Program
    {
        public delegate List<Book> SortYearMethod(List<Book> books, int year);

        public delegate List<Book> SortWordMethod(List<Book> books, string word);
        
        static void Main(string[] args)
        {
            TaskOne();

            Console.WriteLine("\n\n\n");

            TaskTwo();

            Console.ReadKey();
        }

        static void TaskOne()
        {
            // TODO Задача 1 Делегаты и методы
            /*
             1. Объявить делегат для работы с выборками.
             2. Создать метод, в классе каталог, позволяющий делать выборки из каталога.
             3. Создать класс BookSorter и объявить в нём методы необходимые для 
                выполнения задач по сортировке книг
             3. Вывести в консоль книги написанные до 85ого года. Передав статический метод и BookSorter-a
             4. Вывести книги написаны в названии которых есть слово "мир"
             */
            var catalog = new Catalog();
            catalog.Books = new List<Book>()
            {                
                {new Book("End of Eternity", "Isaak Asimov", new DateTime(1955,1,1)) },
                {new Book ("Time and Time Again", "Ben Elton", new DateTime(2014,1,1)) },
                {new Book ("The Lost World", "Sir Arthur Conan Doyle", new DateTime(1912,1,1)) },
                {new Book ("Definitely Maybe", "Arkady and Boris Strugatsky", new DateTime(1977,1,1)) },
                {new Book ("Black Swan Green", "David Mitchell", new DateTime(2006,1,1)) },
                {new Book ("Catch-22", "Joseph Heller", new DateTime(1961,1,1)) },
                {new Book ("The Perks of Being a Wallflower", "Stephen Chbosky", new DateTime(1999,1,1)) },
                {new Book ("The Martian", "Andy Weir", new DateTime(2011,1,1)) },
                {new Book ("Dandelion Wine", "Ray Bradbury", new DateTime(1957,1,1)) },
                {new Book ("Brave New World", "Aldous Huxley", new DateTime(1932,1,1)) },
                {new Book ("To Kill a Mockingbird", "Harper Lee", new DateTime(1960,1,1)) }
            };

            var sorter = new BookSorter();
            
            SortWordMethod wordMethod = new SortWordMethod(sorter.BookWithWorld);
            var list1 = wordMethod.Invoke(catalog.Books, "world");
            PrintStringBook(list1);

            Console.WriteLine("\n\n\n");

            SortYearMethod yearMethod = new SortYearMethod(sorter.BookPublishedBefore);
            yearMethod = sorter.BookPublishedBefore;
            var list2 = yearMethod.Invoke(catalog.Books, 1985);
            PrintDateBook(list2);
        }

        public static void PrintStringBook(List<Book> books)
        {
            if (books == null)
                throw new ArgumentNullException("books");            
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }            
        }

        public static void PrintDateBook(List<Book> books)
        {
            if (books == null)
                throw new ArgumentNullException("books");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        static void TaskTwo()
        {
            // TODO Задача 2 Делегаты и анонимные методы и/или лямбда выражения
            /* 
             1. Объявить делегаты для работы со студентами
             2. Создать метод, в классе группа, позволяющий сортировать студентов.
             3. Создать метод, в классе группа, предоставляющий возможность выполнить действие
                с приватной коллекцией студентов.
             4. Используя метод из пункта 2, отсортировать студентов по средней оценке
             5. Используя метод из пункта 3, всем студентам с оценкой от 4 до 6 добавить 1 балл.
             */
            var group = new Group(new List<Student> { new Student(), new Student(), new Student(), new Student(), new Student(), new Student() });

            //group.DoSmth(WriteName);

            group.DoSmth((student) => Console.WriteLine($"Student {student.FirstName} {student.LastName} | Average Mark: {student.AvgMark: 0.00}"));

            Console.WriteLine("\n\n\n");

            var sortedList = group.SortStudents(CompareByAvrMark);

            Console.WriteLine(string.Join("\n", sortedList.Select(student => $"Student {student.FirstName} {student.LastName} | Average Mark: {student.AvgMark: 0.00}")));

            Console.WriteLine("\n\n\n");

            group.DoSmth((student) => { if (student.AvgMark >= 4 && student.AvgMark <= 6)
                    student.ChangeAvgMark(student, 1.0);
            });

            Console.WriteLine(string.Join("\n", sortedList.Select(student => $"Student {student.FirstName} {student.LastName} | Average Mark {student.AvgMark: 0.00}")));
        }
        
        static bool CompareByAvrMark(Student firstStudent, Student secondStudent)
        {
            return firstStudent.AvgMark > secondStudent.AvgMark;
        }

        static void AddMark(Student student)
        {
            if (student.AvgMark >= 4 && student.AvgMark <= 6)
                student.ChangeAvgMark(student, 1.0);
        }

        static void WriteName(Student student)
        {
            Console.WriteLine($"Student {student.FirstName} {student.LastName} | Average Mark {student.AvgMark}");
        }

        static void TaskThree()
        {
            // TODO Задача 3* Func, Action + =>
            // В задаче нельзя объявлять делегаты
            /*
             1. Создать методы расширения для класса CarPark:
                а. Производит выборку из внутренней коллекции используя передаваемую функцию
                б. Производит сортировку внутренней коллекции используя передаваемую функцию
             2. Создать внутреннее свойство в классе CarPark для хранение действия.
             3. Вызывать это действие при добавлении новой машины в парк:
                 => Как вариант выводить в консоль информацию о машине 
                 Console: Toyota RAV4 was added to the park. It costs ... $. 
             */
            var group = new CarPark()
            {
                Cars = new List<Car>()
                {
                    // TODO add cars
                }
            };
        }
    }
}
