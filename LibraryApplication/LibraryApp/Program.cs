//Create a C# console application that demonstrates interfaces in an app for college / Univeristy 'Library' environment.
//This Main() method creates objects of the CD, DVD, and Book classes and sets their properties to some example values.
//It then calls the Print() method on each object to display information about it.
//Invoke other methods such as Borrow() and Return() on applicable objects.

using System;
 class Program
 {
      static void Main()
      {
        Book book = new Book();

        book.Borrower = "Sucharitha";
        book.Title = "Quantum Science";
        book.Author = "Samuel K.Y";
        book.ISBN = "987654321";
       

        DVD dvd = new DVD();

        dvd.Borrower = "Hema";
        dvd.Title = "The Hidden History";
        dvd.Director = "Arnev Mehra";
        dvd.LengthInMinutes = 60;
        

        CD cd = new CD();

        cd.Borrower = "Sahithi";
        cd.Title = "Independent India";
        cd.Artist = "Sourabh Mishra";
        cd.NumberOfTracks = 2;
        

        //Console.WriteLine("Borrower: "+book.Borrower);
        //Console.WriteLine("LoanPeriod(days): "+book.LoanPeriod);
        //Console.WriteLine("Borrower: " + cd.Borrower);
        //Console.WriteLine("LoanPeriod(days): " + cd.LoanPeriod);
        //Console.WriteLine("Borrower: " + dvd.Borrower);
        //Console.WriteLine("LoanPeriod(days): " + dvd.LoanPeriod);

        cd.Print();
        book.Print();
        dvd.Print();

        book.Borrow();
        dvd.Return();
        cd.Borrow();

        Console.ReadKey();
        

      }
}

