//Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
//Eg:

//seconds = 288970

//The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"

//Output: 3 days, 8 hours, 16 minutes, 10 seconds



//Note: Don 't use any control statements such as 'if' or loops.
 
//Don't use any predefined API (classes or structs).

class SecondsConverter
{
    static void Main()
    {
        int seconds = 288970;
        //1 min=60 sec
        //1 hour=3600 sec
        //1 day=24 hours=24*3600 sec
        
        int days = seconds / (24 * 3600);
        seconds = seconds % (24 * 3600);
        int hours = seconds / 3600;
        seconds = seconds % 3600;
        int minutes = seconds / 60;
        seconds = seconds % 60;
        System.Console.WriteLine(days+" days, "+hours+" hours, "+minutes+ " minutes, " + seconds+ " seconds");
        System.Console.ReadKey();
    }
}

//1 year=365 days=365*24*3600 sec
//int years = seconds / (365 * 24 * 3600);
//seconds = seconds % (365 * 24 * 3600);