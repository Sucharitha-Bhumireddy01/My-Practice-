//Write a C# program to print the following output by using 'for' loop, 'break' and 'continue' statements
//Write a C# program to print the following output:

//1 2 3 4 7 8 9 10
//1 2 3 4 7 8 9 10
//1 2 3 4 7 8 9 10
//10 9 8 7 6 5 4 3 2 1
//10 9 8 7 6 5 4 3 2 1
//10 9 8 7 6 5 4 3
//10 9 8 7 6 5 4 3 2 1
//1 2 3 4 5 6 7 9 10

//Each number should be printed by using the loop variable.

//Don't print full line at-a-time as string.

//For example, don't write statements as:

//System.Console.WriteLine("1 2 3 4 7 8 9 10");



//Use for loop, break and continue statements to bring the output.

class Program
{
    static void Main()
    {
        //1 2 3 4 7 8 9 10
        //1 2 3 4 7 8 9 10
        //1 2 3 4 7 8 9 10
        for (int i=1;i<=3;i++)
        {
            for(int j=1;j<=10;j++)
            {
                if(j==5||j==6)
                {
                    continue;
                }
                System.Console.Write(j);
                System.Console.Write(" ");
            }
            System.Console.WriteLine("");
        }
        //10 9 8 7 6 5 4 3 2 1
        //10 9 8 7 6 5 4 3 2 1
        //10 9 8 7 6 5 4 3
        //10 9 8 7 6 5 4 3 2 1
        
        for (int i=1;i<=4;i++)
        {
            for(int j=10;j>=1;j--)
            {
                if((i==3&&(j==2||j==1)))
                {
                    break;
                }
                System.Console.Write(j);
                System.Console.Write(" ");
            }
            System.Console.WriteLine("");
        }
        // 1 2 3 4 5 6 7 9 10
        for(int i=1;i<=10;i++)
        {
            System.Console.Write(i);
            System.Console.Write(" ");
        }

        System.Console.ReadKey();
    }
}