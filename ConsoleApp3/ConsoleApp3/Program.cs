using System;

class DebitCard
{
    private string pin;

    public string Pin
    {
        get { return pin; }
        set
        {
            // Check if the pin is exactly 4 digits or 6 digits
            if (value.Length == 4 || value.Length == 6)
            {
                // Check if all characters in the pin are digits
                bool containsOnlyDigits = true;
                foreach (char c in value)
                {
                    if (!char.IsDigit(c))
                    {
                        containsOnlyDigits = false;
                        break;
                    }
                }

                if (containsOnlyDigits)
                {
                    pin = value;
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
        DebitCard card = new DebitCard();

        // Valid pins
        card.Pin = "1234"; // Valid 4 digits pin
        Console.WriteLine("Pin set successfully: " + card.Pin);

        card.Pin = "123456"; // Valid 6 digits pin
        Console.WriteLine("Pin set successfully: " + card.Pin);

        // Invalid pins
        card.Pin = "1234ef"; // Invalid pin with non-digit characters
        card.Pin = "0"; // Invalid pin with 1 digit
        card.Pin = "a4"; // Invalid pin with non-digit characters

        Console.ReadLine();
    }
}
