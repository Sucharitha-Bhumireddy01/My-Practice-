using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        //input of creditcard-testing
        string input = "My credit card number is 1234-5678-9012-3456";
        string output = MaskCreditCard(input);
        Console.WriteLine(output);
                
        //securitycard-testing
        input = "My social security number is 123-45-6789";
        output = MaskSocialSecurity(input);
        Console.WriteLine(output);

        //tesitng-MaskData
        input = "My credit card number is 1234-5678-9012-3456 and my social security number is 123-45-6789";
        output = MaskData(input);
        Console.WriteLine(output);
        Console.ReadKey();
    }
    static string MaskCreditCard(string input)
    {
        string[] chars=input.Split(' ');
        for(int i=0;i<chars.Length;i++)
        {
            string charecter = chars[i];
            // Checking if the charecter matches the credit card number format
            if (charecter.Length==19&&charecter[4]=='-'&&charecter[9]=='-'&&charecter[14]=='-')
            {
                // Create a mask with 4 'X'
                string mask = new string('X', 4);
                // Get the last four digits of the credit card number
                string lastFourDigits =charecter.Substring(15, 4);
                // Replace the credit card number with the mask and the last four digits
                chars[i]=mask + "-" + mask + "-" + mask + "-" + lastFourDigits;
            }
        }
        // Join the chars back into a string
        return string.Join(" ", chars);
    }
    // Masks all social security numbers in the input string
    static string MaskSocialSecurity(string input)
    {
        //splitting the input into parts and storing in chars
        string[] chars = input.Split();
        for(int i = 0; i < chars.Length; i++)
        {
            string charecter = chars[i];
            if(charecter.Length==11&&charecter[3]=='-'&&charecter[6]=='-')
            {
                string mask3 = new string('X', 3);
                string mask4 = new string('X', 4);
                string middleTwoDigits = charecter.Substring(4, 2);
                chars[i] = mask3 + "-" + middleTwoDigits + "-" + mask4;
            }
        }
        return string.Join(" ", chars);
    }
    static string MaskData(string input)
    {
        string output = MaskCreditCard(input);
        output = MaskSocialSecurity(output);
        return output;
    }

    
}