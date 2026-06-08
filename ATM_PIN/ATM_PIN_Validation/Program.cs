//the Pin should be exactly 4 digits or 6 digits.

//If the supplied pin is invalid, it shows error message.



//Examples:

//Pin = "1234"-- > valid

//Pin = "1234ef"-- > invalid

//Pin = "123456"-- > valid

//Pin = "0"-- > invalid

//Pin = "a4"-- > invalid

using System;

class DebitCard
{
    private string _pin;
    public string Pin
    {

        get
        {
            return _pin;
        }
        set
        {

            if (value.Length == 4 || value.Length == 6)
            {
                // Check if all characters in the pin are digits
                bool isValid = true;
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    _pin = value;
                }
                else
                {
                    Console.WriteLine("Invalid pin. Pin should contain only digits.");
                }
            }
            else
            {
                Console.WriteLine("Invalid pin. Pin should be exactly 4 digits or 6 digits.");
            }
        }
    }
    

    }

 

class Program
{
    static void Main()
    {
        DebitCard debitCard = new DebitCard();
        //Console.Write("Please Enter the PIN: ");
        debitCard.Pin = "1@23";/*Console.ReadLine();*/
        Console.WriteLine(debitCard.Pin);

        Console.ReadKey();
    }
}