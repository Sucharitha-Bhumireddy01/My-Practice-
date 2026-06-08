//Book: has properties such as Author, Title, and ISBN, and should be loanable for 21 days.

using System;

//class
public class Book : ILoanable, IPrintable
{
    public string Author { set; get; }
   public  string Title { set; get; }
    public string ISBN { set; get; }
    //properties
    
    public int LoanPeriod
    {//should be loanable for 21 days.
        
        get { return 21; }
    }

    private string _borrower;
    
    public string Borrower
    {
        set { this._borrower = value; }
        get { return _borrower; }
    }
    //methods
    public void Borrow()
    {
        Console.WriteLine(Borrower+" borrowed the Book: "+Title+" by "+Author+" for "+LoanPeriod+" days");
    }
    public void Return()
    {
        Console.WriteLine(Borrower+" returned the Book: "+Title+" by "+Author);
    }
    public void Print()
    {
        //print out the information about the object
        Console.WriteLine("*******The Book Details********");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
    }
}