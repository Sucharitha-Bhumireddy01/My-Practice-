//Write a C# program to find out largest number among three numbers, using "if".
//Eg:

//num1 = 60

//num2 = 45

//num3 = 123

//Output: 123

class LargestNumber
{
    static void Main()
    {
        int num1 = 60, num2 = 45, num3 = 123;
        if (num1 > num2 && num1 > num3)
            System.Console.WriteLine(num1);
        else if (num2 > num1 && num2 > num3)
            System.Console.WriteLine(num2);
        else 
            System.Console.WriteLine(num3);
        System.Console.ReadKey();


    }
}