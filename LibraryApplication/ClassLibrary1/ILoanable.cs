//ILoanable: defines the properties and methods that an item that can be borrowed should have.
//This should include properties such as LoanPeriod and Borrower, as well as methods such as Borrow and Return.



using System;
//interface
interface ILoanable
{
    //auto-propeties
    int LoanPeriod { get; }
    string Borrower { set; get; }

    //methods
    void Borrow();
    void Return();
        
}
