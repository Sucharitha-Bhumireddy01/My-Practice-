class Sample
{
    static void Main()
    {
        Employee.OrganizationName = "Harsha Inc.";
        //creating refernce variables
        Employee Employee1, Employee2, Employee3, Employee4, Employee5;
        //creating objects
        Employee1 = new Employee();
        Employee2 = new Employee();
        Employee3 = new Employee();
        Employee4 = new Employee();
        Employee5 = new Employee();
              

        
        int i = 1;
        do
        {
            switch (i)
            {
                case 1:
                    //reading employee details
                    System.Console.WriteLine("Employee 1 Details");
                    System.Console.Write("Employee ID: ");
                    Employee1.EmpID = int.Parse(System.Console.ReadLine());
                    System.Console.Write("Employee Name: ");
                    Employee1.EmpName = System.Console.ReadLine();
                    System.Console.Write("salary Per Hour: ");
                    Employee1.SalaryPerHour = double.Parse(System.Console.ReadLine());
                    System.Console.Write("Number of Working Hours: ");
                    Employee1.NoOfWorkingHours = int.Parse(System.Console.ReadLine());
                    Employee1.NetSalary = Employee1.SalaryPerHour * Employee1.NoOfWorkingHours;
                    //displaying employee details
                    System.Console.WriteLine("Employee ID: " + Employee1.EmpID);
                    System.Console.WriteLine("Employee Name: " + Employee1.EmpName);
                    System.Console.WriteLine("Salary Per Hour: " + Employee1.SalaryPerHour);
                    System.Console.WriteLine("Number of Working Hours: " + Employee1.NoOfWorkingHours);
                    System.Console.WriteLine("Net Salary:" + Employee1.NetSalary);
                    System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
                    System.Console.WriteLine("Type Of Employee:" + Employee.TypeOfEmployee);
                    System.Console.WriteLine("Department Name:" + Employee1.DepartmentName);

                    break;

                case 2:
                    System.Console.WriteLine("Employee 2 Details");
                    System.Console.Write("Employee ID: ");
                    Employee2.EmpID = int.Parse(System.Console.ReadLine());
                    System.Console.Write("Employee Name: ");
                    Employee2.EmpName = System.Console.ReadLine();
                    System.Console.Write("salary Per Hour: ");
                    Employee2.SalaryPerHour = double.Parse(System.Console.ReadLine());
                    System.Console.Write("Number of Working Hours: ");
                    Employee2.NoOfWorkingHours = int.Parse(System.Console.ReadLine());
                    Employee2.NetSalary = Employee2.SalaryPerHour * Employee2.NoOfWorkingHours;

                    System.Console.WriteLine("Employee ID: " + Employee2.EmpID);
                    System.Console.WriteLine("Employee Name: " + Employee2.EmpName);
                    System.Console.WriteLine("Salary Per Hour: " + Employee2.SalaryPerHour);
                    System.Console.WriteLine("Number of Working Hours: " + Employee2.NoOfWorkingHours);
                    System.Console.WriteLine("Net Salary:" + Employee2.NetSalary);
                    System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
                    System.Console.WriteLine("Type Of Employee:" + Employee.TypeOfEmployee);
                    System.Console.WriteLine("Department Name:" + Employee2.DepartmentName);
                    break;

                case 3:
                    System.Console.WriteLine("Employee 3 Details");
                    System.Console.Write("Employee ID: ");
                    Employee3.EmpID = int.Parse(System.Console.ReadLine());
                    System.Console.Write("Employee Name: ");
                    Employee3.EmpName = System.Console.ReadLine();
                    System.Console.Write("salary Per Hour: ");
                    Employee3.SalaryPerHour = double.Parse(System.Console.ReadLine());
                    System.Console.Write("Number of Working Hours: ");
                    Employee3.NoOfWorkingHours = int.Parse(System.Console.ReadLine());
                    Employee3.NetSalary = Employee3.SalaryPerHour * Employee3.NoOfWorkingHours;

                    System.Console.WriteLine("Employee ID: " + Employee3.EmpID);
                    System.Console.WriteLine("Employee Name: " + Employee3.EmpName);
                    System.Console.WriteLine("Salary Per Hour: " + Employee3.SalaryPerHour);
                    System.Console.WriteLine("Number of Working Hours: " + Employee3.NoOfWorkingHours);
                    System.Console.WriteLine("Net Salary:" + Employee3.NetSalary);
                    System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
                    System.Console.WriteLine("Type Of Employee:" + Employee.TypeOfEmployee);
                    System.Console.WriteLine("Department Name:" + Employee3.DepartmentName);

                    break;
                case 4:
                    System.Console.WriteLine("Employee 4 Details");
                    System.Console.Write("Employee ID: ");
                    Employee4.EmpID = int.Parse(System.Console.ReadLine());
                    System.Console.Write("Employee Name: ");
                    Employee4.EmpName = System.Console.ReadLine();
                    System.Console.Write("salary Per Hour: ");
                    Employee4.SalaryPerHour = double.Parse(System.Console.ReadLine());
                    System.Console.Write("Number of Working Hours: ");
                    Employee4.NoOfWorkingHours = int.Parse(System.Console.ReadLine());
                    Employee4.NetSalary = Employee4.SalaryPerHour * Employee4.NoOfWorkingHours;

                    System.Console.WriteLine("Employee ID: " + Employee4.EmpID);
                    System.Console.WriteLine("Employee Name: " + Employee4.EmpName);
                    System.Console.WriteLine("Salary Per Hour: " + Employee4.SalaryPerHour);
                    System.Console.WriteLine("Number of Working Hours: " + Employee4.NoOfWorkingHours);
                    System.Console.WriteLine("Net Salary:" + Employee4.NetSalary);
                    System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
                    System.Console.WriteLine("Type Of Employee:" + Employee.TypeOfEmployee);
                    System.Console.WriteLine("Department Name:" + Employee4.DepartmentName);

                    break;

                case 5:
                    System.Console.WriteLine("Employee 5 Details");
                    System.Console.Write("Employee ID: ");
                    Employee5.EmpID = int.Parse(System.Console.ReadLine());
                    System.Console.Write("Employee Name: ");
                    Employee5.EmpName = System.Console.ReadLine();
                    System.Console.Write("salary Per Hour: ");
                    Employee5.SalaryPerHour = double.Parse(System.Console.ReadLine());
                    System.Console.Write("Number of Working Hours: ");
                    Employee5.NoOfWorkingHours = int.Parse(System.Console.ReadLine());

                    System.Console.WriteLine("Employee ID: " + Employee5.EmpID);
                    System.Console.WriteLine("Employee Name: " + Employee5.EmpName);
                    System.Console.WriteLine("Salary Per Hour: " + Employee5.SalaryPerHour);
                    System.Console.WriteLine("Number of Working Hours: " + Employee5.NoOfWorkingHours);
                    System.Console.WriteLine("Net Salary:" + Employee5.NetSalary);
                    System.Console.WriteLine("Organization Name: " + Employee.OrganizationName);
                    System.Console.WriteLine("Type Of Employee:" + Employee.TypeOfEmployee);
                    System.Console.WriteLine("Department Name:" + Employee5.DepartmentName);

                    break;

                default:
                    break;

            }
            i++;
            System.Console.WriteLine("Do you want to continue to next employee:Yes/No");
            string userChoice = System.Console.ReadLine();
            if(userChoice=="No"||userChoice=="NO"||userChoice=="no"||userChoice=="nO")
            {
                break;
            }
        } while (i <= 5);

        System.Console.WriteLine("Thank You for visiting!!");
        System.Console.ReadKey();

        
    }
}