//You have the following values to convert:

//byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
//int b = 10; //Convert this value into "short" type (assign into another short type of variable)
//string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
//decimal d = 20.3; //Convert this value into "string" type (assign into another string type of variable)
//And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.



//You need to consider this order of concepts to prefer for conversion, where the "1" will be the highest priority and the "4" will be the least priority.

//Implicit Casting

//Explicit Casting

//Parse or TryParse (as suggested above)

//Conversion Methods
using System;
class Conversion
{
    static void Main()
    {
        byte a = 10;
        int b = 10;
        string c = "10.34";
        decimal d = 11.56M;
        //Implicit Casting
        short e;
        e = a;
        //Explicit Casting
        short f;
        f = (short)b;
        //Parse
        double g;
        g=double.Parse(c);
        // Also, convert the same value into "decimal" type  using TryParse
        bool i=decimal.TryParse(c, out decimal n);
        
        //Conversion Methods
        string h;
        h = Convert.ToString(d);

        //displaying 
        Console.WriteLine(e+", "+f+", "+g+", "+n+", "+h);

        Console.ReadKey();
    }

}