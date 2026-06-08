using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number to check it is prime Number ");
            int n= Int32.Parse(Console.ReadLine());
            int count = 0;
            
            for (int i=1;i<=n;i++) {
                if(n%i==0) 
                {
                    count++;
                } 
            }
            if (count == 2) {
                Console.WriteLine("The Entered Number is Prime Number");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Entered number is not Prime Number");
                Console.Read();
            }
        }
    }
}
