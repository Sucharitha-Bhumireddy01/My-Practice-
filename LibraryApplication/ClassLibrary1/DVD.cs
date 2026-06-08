//DVD: has properties such as Director, Title, and LengthInMinutes, and should be loanable for 7 days.

using System;
//class
public class DVD : ILoanable,IPrintable
{
    public string Director { set; get; }
    public string Title { set; get; }
    public int LengthInMinutes { set; get; }
    //properties
    public int LoanPeriod
    {//should be loanable for 7 days.
        
        get { return 7; }
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
        Console.WriteLine(Borrower + " borrowed the DVD: " + Title + " for " + LoanPeriod + " days");
    }
    public void Return()
    {
        Console.WriteLine(Borrower + " returned the DVD: " + Title);
    }
    public void Print()
    {
        //print out the information about the object
        Console.WriteLine("*******The DVD Details********");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Artist: " + Director);
        Console.WriteLine("NumberOfTracks: " + LengthInMinutes);
    }
}