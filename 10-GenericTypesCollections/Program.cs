using _10_GenericTypesCollections;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Book b1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
        Book b2 = new Book(2, "1984", "George Orwell", 1949, 328);
        Book b3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
        Book b4 = new Book(4, "Ağ Gəmi", "Cingiz Aytmatov", 1970, 200);
        Book b5 = new Book(5, "Qırıq Budaq", "Elçin", 1998, 350);

        b1.DisplayInfo();
        b2.DisplayInfo();
        b3.DisplayInfo();
        b4.DisplayInfo();
        b5.DisplayInfo();

      
        Library<Book> lib = new Library<Book>("Milli Kitabxana");

        lib.Add(b1);
        lib.Add(b2);
        lib.Add(b3);
        lib.Add(b4);
        lib.Add(b5);

        Console.WriteLine("Kitab sayı: " + lib.Count());

        lib.FindByIndex(0)?.DisplayInfo();
        lib.FindByIndex(2)?.DisplayInfo();

        foreach (var book in lib.GetAll())
            book.DisplayInfo();

      
        List<Member> members = new List<Member>()
        {
            new Member(1,"Ali Məmmədov","ali@mail.com"),
            new Member(2,"Leyla Həsənova","leyla@mail.com"),
            new Member(3,"Vüqar Əliyev","vuqar@mail.com")
        };

        var m = members[0];

        m.BorrowBook(b1);
        m.BorrowBook(b2);
        m.DisplayBorrowedBooks();

        m.ReturnBook(1);
        m.DisplayBorrowedBooks();

        m.BorrowBook(b3);
        m.BorrowBook(b4);
        m.BorrowBook(b5); 

        BookManager manager = new BookManager();

        manager.AddBook(b1);
        manager.AddBook(b2);
        manager.AddBook(b3);
        manager.AddBook(b4);
        manager.AddBook(b5);

        var orwellBooks = manager.GetBooksByAuthor("George Orwell");
        foreach (var book in orwellBooks)
            book.DisplayInfo();

        manager.AddToWaitingQueue("Nigar");
        manager.AddToWaitingQueue("Rəşad");
        manager.AddToWaitingQueue("Səbinə");

        Console.WriteLine("Xidmət edilir: " + manager.ServeNextInQueue());
        Console.WriteLine("Qalan: " + manager.WaitingQueue.Count);

        
        manager.ReturnBook(b1);
        manager.ReturnBook(b2);
        manager.ReturnBook(b3);

        Console.WriteLine("Son kitab:");
        manager.GetLastReturnedBook()?.DisplayInfo();

        manager.RecentlyReturned.Pop();

        Console.WriteLine("Yeni son kitab:");
        manager.GetLastReturnedBook()?.DisplayInfo();

        var found = manager.SearchByTitle("1984");
        found?.DisplayInfo();

        var notFound = manager.SearchByTitle("Harry Potter");
        if (notFound == null)
            Console.WriteLine("Tapılmadı");

       
        Console.WriteLine("Ümumi kitab: " + manager.Books.Count);
        Console.WriteLine("Ümumi üzv: " + members.Count);
        Console.WriteLine("Növbə: " + manager.WaitingQueue.Count);
        Console.WriteLine("Stack: " + manager.RecentlyReturned.Count);

        int minYear = int.MaxValue;
        int maxYear = int.MinValue;

        foreach (var book in manager.Books)
        {
            if (book.Year < minYear)
                minYear = book.Year;

            if (book.Year > maxYear)
                maxYear = book.Year;
        }

        Console.WriteLine("Ən köhnə il: " + minYear);
        Console.WriteLine("Ən yeni il: " + maxYear);
    }
}
