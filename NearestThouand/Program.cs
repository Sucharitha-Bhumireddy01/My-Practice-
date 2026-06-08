//If the number's last three digits are greater than or equal to 500; it should "round up" the number.

//If the number's last three digits are less than 500; it should "round down" the number.

//If the number is less than 500; it should round up to 1000.



//Eg:

//Input: 499  Output: 1000

//Input: 500  Output: 1000

//Input: 999  Output: 1000

//Input: 1000 Output: 1000

//Input: 1499 Output: 1000

//Input: 1500 Output: 2000


class Roundoff
{
    static void Main()
    {
        int number = 7200;
        int reminder = 0;
        reminder = number % 1000;//to get the last 3 digits
        int output = (number<500)?1000:(reminder >= 500) ? 1000 + number - reminder : number - reminder;
        System.Console.WriteLine(output);
        System.Console.ReadKey();

    }
}