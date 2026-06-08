using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibility
{
    class Program
    {
        static void Main()
        {
            //to check a number is divisible by 2
            Console.WriteLine("Please enter the number");
            int num=Int32.Parse(Console.ReadLine());
            int r = num % 10;
            
            if (r ==0||r==2||r==4||r==6||r==8)
            {
                Console.WriteLine("{0} is divisible by 2", num);
            }
            else
            {
                Console.WriteLine("{0} is not divisible by 2", num);
            }
            Console.Read();  
                                
        }
        public void Main1()
        {
            Console.WriteLine("Please Enter the number ");
            int num = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for(int )
        }
    }
}
