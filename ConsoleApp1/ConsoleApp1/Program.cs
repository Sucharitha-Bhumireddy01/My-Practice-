using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int TotalCost = 0;
            Start:
            Console.WriteLine("MENU:\n1-Chapati\n2-Dosa\n3-Pulihara\n4-Lemon Rice");
            Console.WriteLine("Please select among 1-4 from the menu");
            int Choice=int.Parse(Console.ReadLine());
            switch(Choice)
            {
                case 1:
                    TotalCost += 10;
                    break;
                case 2:
                    TotalCost += 15;
                    break;
                case 3:
                    TotalCost += 25;
                    break;
                case 4:
                    TotalCost += 20;
                    break;
                default:
                    Console.WriteLine("!!Invalid Choice!!\nPlease select items within the MENU");
                    goto Start;
                    

            }
            Decide:
            Console.WriteLine("Thank you!! Your Order is placed!!\nWould you like to place order again yes or no");
            string Decision=Console.ReadLine();
            switch(Decision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Inavalid Decision!!");
                    goto Decide;
            }
            Console.WriteLine("BILL:{0}",TotalCost);
            Console.Read();
            
        }
        
    }
}
