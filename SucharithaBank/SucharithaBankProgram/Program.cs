using SucharitBank.Presentation;
class Program
{
    static void Main()
    {
        string userName = null, password = null;
        
        System.Console.WriteLine("***********Sucharitha Bank**********");
        System.Console.WriteLine("\n::Login Page::");
        System.Console.Write("Username: ");
        userName=System.Console.ReadLine();
        if (userName!="")
        {
            System.Console.Write("Password: ");
            password = System.Console.ReadLine();
        }

        //check username and password
        if(userName=="system"&& password == "manager")
        {
            //declare variable to store menu choice
            int mainMenuChoice = -1;
            do
            {
                //show main menu
                System.Console.WriteLine("\n:::Main Menu:::");
                System.Console.WriteLine("1. Customer");
                System.Console.WriteLine("2. Accounts");
                System.Console.WriteLine("3. Fund Transfer");
                System.Console.WriteLine("4. Funds transfer Statement");
                System.Console.WriteLine("5. Account Statement");
                System.Console.WriteLine("0. Exit");

                //accept menu choices from keyboard
                System.Console.Write("Enter Choice: ");
                mainMenuChoice = int.Parse(System.Console.ReadLine());

                //switch case to check menu choice
                switch (mainMenuChoice)
                {
                    case 1:
                        CustomersMenu();
                        break;
                    case 2:
                        AccountsMenu();
                        break;
                    case 3://TO DO:Display finds transfer menu
                        break;
                    case 4://TO DO:Display funds transfer statement menu
                        break;
                    case 5://TO DO:Display account statement menu
                        break;

                }
            } while (mainMenuChoice != 0);

        }
        else
        {
            System.Console.WriteLine("Invalid Username or Password");
        }

        

        
        System.Console.WriteLine("Thank You For Visiting! Visit Again. ");
        System.Console.ReadKey();
    }

    static void CustomersMenu()
    {
        //variable to store customers choice
        int customersMenuChoice = -1;
        //do-while loop starts
        do
        {
            //print customers menu
            System.Console.WriteLine("\n:::Customers Menu:::");
            System.Console.WriteLine("1. Add customer");
            System.Console.WriteLine("2. Delete Customer");
            System.Console.WriteLine("3. Update Customer");
            System.Console.WriteLine("4. Search Customer");
            System.Console.WriteLine("5. View Customers");
            System.Console.WriteLine("0. Back to Main Menu");

            //accept customers' menu choice
            System.Console.Write("Enter Choice: ");
            customersMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

            //switch case
            switch(customersMenuChoice)
            {
                case 1: CustomersPresentation.AddCustomer();break;

                case 5: CustomersPresentation.ViewCustomers();break;
            }

        } while (customersMenuChoice != 0);
        }

    static void AccountsMenu()
    {

        int AccountsMenuChoice = -1;
        do
        {
            System.Console.WriteLine("\n:::Accounts Menu:::");
            System.Console.WriteLine("1. Add Account");
            System.Console.WriteLine("2. Delete Account");
            System.Console.WriteLine("3. Update Account");
            System.Console.WriteLine("4. View Accounts");
            System.Console.WriteLine("0. Exit");

            AccountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
        } while (AccountsMenuChoice != 0);
    }
    
}