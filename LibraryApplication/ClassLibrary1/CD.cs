//CD: has properties such as Artist, Title, and NumberOfTracks, and should be loanable for 14 days.

using System;
//class
public class CD : ILoanable,IPrintable
{
    public string Artist { set; get; }
    public string Title { set; get; }
    public int NumberOfTracks { set; get; }
    //properties
    public int LoanPeriod
    {//should be loanable for 14 days.
        
        get { return 14; }
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
        Console.WriteLine(Borrower + " borrowed the CD: " + Title +" for " + LoanPeriod + " days");
    }
    public void Return()
    {
        Console.WriteLine(Borrower + " returned the CD: " + Title);
    }
    public void Print()
    {
        //print out the information about the object
        Console.WriteLine("*******The CD Details********");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Artist: " + Artist);
        Console.WriteLine("NumberOfTracks: " + NumberOfTracks);
    }
}