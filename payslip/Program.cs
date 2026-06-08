using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace project
{
    /*static class DBConfiguration
    {

        #region ----------- PRIVATE VARIABLES -----------
        private static string dbSource = @"(localDB)\MSSQLLocalDB";
        private static Boolean integrityValue = true;
        private static string programDB_Name = "PresentDb";


        private static string allowance_Table = "[dbo].[Allowance_Table]";

        private static string employee_Table = "[dbo].[Employee_Table]";
        private static string salary_Table = "[dbo].[Salary_Table]";
        private static string designation_Table = "[dbo].[Designation_Table]";
        private static string attendance_Table = "[dbo].[Attendance_Table]";
        private static string cs1 = $"Data Source= {DbSource}; Initial Catalog = {ProgramDB_Name}; Integrated Security = {IntegrityValue}";

        #endregion ----------- PRIVATE VARIABLES -----------

        #region ----------- PUBLIC ACCESS METHODS GETTERS  -----------
        public static string Designation_Table
        {
            get { return designation_Table; }
        }
        public static string Attendance_Table
        {
            get { return attendance_Table; }
        }
        public static string DbSource
        {
            get { return dbSource; }
        }
        public static Boolean IntegrityValue
        {
            get { return integrityValue; }
        }
        public static string ProgramDB_Name
        {
            get { return programDB_Name; }
        }

        public static string Allowance_Table
        {
            get { return allowance_Table; }
        }




        public static string Employee_Table
        {
            get { return employee_Table; }
        }

        public static string Salary_Table
        {
            get { return salary_Table; }
        }
        public static string ConnectionString
        {
            get { return cs1; }
        }


        #endregion ----------- PUBLIC ACCESS METHODS GETTERS  -----------
    }*/
    public class Designation
    {
        private string emp_desg;
        public String EmpDes
        {
            get { return emp_desg; }
            set { emp_desg = value; }
        }
        private int lvl;
        public int Level
        {
            get { return lvl; }
            set { lvl = value; }
        }


        // constructor
        public Designation()
        {
            this.EmpDes = null;
            this.Level = 0;
        }

        public Designation(int level)
        {
            this.Level = level;
        }
        /* public void Insertinto_Designation_Table(employee e)
         {
             // string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = ProjectReview; Integrated Security = True";
             //SqlConnection con = new SqlConnection( DBConfiguration.ConnectionString);
             SqlConnection con = null;
         Line1:
             try
             {
                 using (con = new SqlConnection(DBConfiguration.ConnectionString))
                 {
                     string query = $"insert into {DBConfiguration.Designation_Table} values(@Designation_Id,@Employee_Id,@Employee_Designation,@Employee_Level)";
                     SqlCommand cmd = new SqlCommand(query, con);

                     Console.WriteLine("enter designation Id");
                     int desgid = int.Parse(Console.ReadLine());
                     ////Console.WriteLine("enter employee name");
                     ////string empname = Console.ReadLine();
                     ////Console.WriteLine("enter employee salary");
                     ////float esalary = float.Parse(Console.ReadLine());
                     ////Console.WriteLine("enter employee Employee_Dateofbirth");
                     ////string Employee_Dateofbirth = Console.ReadLine();
                     ////Console.WriteLine("enter employee Employee_Dateofjoining");
                     ////string Employee_Dateofjoining = Console.ReadLine();
                     ////Console.WriteLine("enter employee Employee_Designation");
                     ////string Employee_Designation = Console.ReadLine();
                     ////Console.WriteLine("enter employee Employee_Workingdays");
                     ////int Employee_Workingdays = int.Parse(Console.ReadLine());
                     cmd.Parameters.AddWithValue("@Designation_Id", desgid);
                     cmd.Parameters.AddWithValue("@Employee_Id", e.Employeeid);
                     cmd.Parameters.AddWithValue("@Employee_Designation", e.EmpDesignation.EmpDes);
                     cmd.Parameters.AddWithValue("@Employee_Level", e.EmpDesignation.Level);
                     con.Open();
                     cmd.ExecuteNonQuery();
                     //if (k > 0)
                     //{
                     //    Console.WriteLine("Data has been Inserted in Designation_Table");
                     //}
                     //else { Console.WriteLine("Data Insertion has Failed"); }
                 }
             }
             catch (SqlException ex)
             {
                 Console.WriteLine(ex.Message);
                 goto Line1;

             }

         }
         //UPDATE DESIGNATION TABLE
         public void Update_Designation_Table()
         {

             SqlConnection con = null;

             string Employee_Designation = " ";
             int Employee_level = 0;
         Line_u1:
             try
             {
                 using (con = new SqlConnection(DBConfiguration.ConnectionString))
                 {
                     Console.WriteLine("Available options to update");

                     Console.WriteLine("1.employee Designation");
                     Console.WriteLine("2.employee level");
                     Console.WriteLine("enter your choice");
                     int choice = int.Parse(Console.ReadLine());
                     SqlCommand cmd = null;

                     Console.WriteLine("enter Designation id");
                     int Designation_Id = int.Parse(Console.ReadLine());

                     switch (choice)
                     {


                         case 1:
                             {
                                 String query1 = $"update {DBConfiguration.Designation_Table}  set Employee_Designation=@Employee_Designation where Designation_Id=@Designation_Id";

                                 cmd = new SqlCommand(query1, con);

                                 //Console.WriteLine("enter employee id");
                                 //string Employee_Id = Console.ReadLine();


                                 Console.WriteLine("The available Designations are:");
                                 Console.WriteLine("Manager\n  HR\n  Developer\n  Analyst\n  Maintanance\n  Senior Manager ");

                                 Console.WriteLine("enter employee designation");
                                 Employee_Designation = Console.ReadLine();

                                 //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                 //cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);

                                 break;
                             }

                         case 2:
                             {
                                 String query2 = $"update {DBConfiguration.Designation_Table} set Employee_Level=@Employee_Level where  Designation_Id=@Designation_Id";

                                 cmd = new SqlCommand(query2, con);

                                 //Console.WriteLine("enter employee id");
                                 //string Employee_Id = Console.ReadLine();

                                 Console.WriteLine("enter employee level");
                                 Employee_level = int.Parse(Console.ReadLine());
                                 //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);

                                 //cmd.Parameters.AddWithValue("@Employee_Dateofjoining", Employee_Dateofjoining);

                                 break;
                             }





                         default:
                             Console.WriteLine("updation failed");
                             break;
                     }

                     cmd.Parameters.AddWithValue("@Designation_Id", Designation_Id);
                     cmd.Parameters.AddWithValue("@Employee_Designation", Employee_Designation);
                     cmd.Parameters.AddWithValue("@Employee_Level", Employee_level);

                     con.Open();
                     int k = cmd.ExecuteNonQuery();
                     if (k > 0)
                     {
                         Console.WriteLine("Data has been updated");
                     }
                     else
                     {
                         Console.WriteLine("Data update has Failed");
                     }

                 }
             }


             // Console.WriteLine("The Updated Record in the Employee Table");
             //string query_Select = $"select * from {DBConfiguration.Employee_Table} where @Employee_Id = Employee_Id";
             //SqlCommand cmd2 = new SqlCommand(query_Select, con);
             //Console.WriteLine("enter Employee id");
             //string employee_id = Console.ReadLine();
             //cmd2.Parameters.AddWithValue("@Employee_Id", employee_id);
             //SqlDataReader dr = cmd2.ExecuteReader();
             //while (dr.Read())
             //{
             //    Console.WriteLine("Employee_Id: = " + dr["Employee_Id"] + " Name:= " + dr["Employee_Name"] + " Salary:=" + dr["Employee_salary"] +
             //      "  Date-of-Joining: = " + dr["Employee_Dateofjoining"] + "  Designation: = " + dr["Employee_Designation"]+"Employee Working Days:" + dr["Employee_Woringdays"]);

             //}
             catch (SqlException ex)
             {
                 Console.WriteLine(ex.Message);
                 goto Line_u1;
             }
             finally
             {
                 con.Close();
             }
         }


     }*/
        public class level : Designation
        {


            string[] level1 = { "Manager", "HR" };
            string[] level2 = { "Developer", "Analyst" };
            string[] level3 = { "Maintanance", "Senior Manager" };


            public void Designation_Set_By_Lvl(employee e)
            {
                // two cases :
                // if the person is a new comer
                // if the person already has a designation so it won't assign anything.

                if (e.EmpDesignation.EmpDes == null)
                {
                    if (e.EmpDesignation.Level == 1)
                    {
                        e.EmpDesignation.EmpDes = level1[0];
                        Console.WriteLine("Running");
                    }
                    if (e.EmpDesignation.Level == 2)
                    {
                        e.EmpDesignation.EmpDes = level2[0];
                        Console.WriteLine("Running");

                    }
                    if (e.EmpDesignation.Level == 3)
                    {
                        e.EmpDesignation.EmpDes = level3[0];
                        Console.WriteLine("Running");

                    }
                }

                else if (e.EmpDesignation.EmpDes != null)
                {
                    if (e.EmpDesignation.Level == 1)
                    {
                        for (int i = 0; i < level1.Length; i++)
                        {
                            if (level1[i] == e.EmpDesignation.EmpDes)
                            {
                                if (i < (level1.Length - 1))
                                {
                                    e.EmpDesignation.EmpDes = level1[i + 1];
                                }
                                else
                                {
                                    e.EmpDesignation.EmpDes = level1[1];
                                    Console.WriteLine("Employee is at " + e.EmpDesignation.EmpDes);

                                    // at the end of the array
                                    Console.WriteLine("Employee is at the peak of his/her level 1 ");
                                }
                            }
                        }
                    }



                    if (e.EmpDesignation.Level == 2)
                    {
                        for (int i = 0; i < level2.Length; i++)
                        {
                            if (level2[i] == e.EmpDesignation.EmpDes)
                            {
                                if (i < (level2.Length - 1))
                                {
                                    e.EmpDesignation.EmpDes = level2[i + 1];
                                }
                                else
                                {
                                    // at the end of the array
                                    Console.WriteLine("Employee is at the peak of his/her level 2 ");
                                }
                            }
                        }
                    }


                    if (e.EmpDesignation.Level == 3)
                    {
                        for (int i = 0; i < level2.Length; i++)
                        {
                            if (level3[i] == e.EmpDesignation.EmpDes)
                            {
                                if (i < (level3.Length - 1))
                                {
                                    e.EmpDesignation.EmpDes = level3[i + 1];
                                }
                                else
                                {
                                    // at the end of the array
                                    Console.WriteLine("Employee is at the peak of his/her level 3 ");
                                }
                            }
                        }
                    }


                }
            }
        }


        public class Attendance : level
        {
            // Attendance
            private const int numberOfWorkingDays = 30;
            public int NumberOfWorkingDays
            {
                get { return numberOfWorkingDays; }

                // no setter will be there for const varibles because once assigned it cannot be change inside the program
            }
            private int numberOfPaidLeaves;
            public int NumberOfPaidLeaves
            {
                get { return numberOfPaidLeaves; }
                set { numberOfPaidLeaves = value; }
            }
            private int numberofExtraLeaves;
            public int NumberOfExtraLeaves
            {
                get { return numberofExtraLeaves; }
                set { numberofExtraLeaves = value; }
            }



            // Holidays and Deduction.
            private int totalSalaryDeducted;   // no of extra leaves * one day salary
            public int TotalSalaryDeducted
            {
                get { return totalSalaryDeducted; }
                set { totalSalaryDeducted = value; }
            }
            private int oneDaySalary;
            public int OneDaySalary
            {
                get { return oneDaySalary; }
                set { oneDaySalary = value; }
            }

            private int salaryAfterDeduction;
            public int SalaryAfterDeduction
            {
                get { return salaryAfterDeduction; }
                set { salaryAfterDeduction = value; }
            }


            public Attendance()
            {

            }

            public Attendance(int numberofPaidLeaves, int numberofExtraLeaves)
            {
                this.NumberOfPaidLeaves = numberofPaidLeaves;
                this.NumberOfExtraLeaves = numberofExtraLeaves;
            }



            #region ---- FUNCTIONS ------

            public void ExecuteDeduction(employee e)
            {
                // leaves * one day salary

                // find one day salary.
                e.EmpAttendance.OneDaySalary = e.EmpSal.B_sal / e.EmpAttendance.NumberOfWorkingDays;

                if (e.EmpAttendance.NumberOfExtraLeaves > 0)
                {
                    // find the total deduction
                    e.EmpAttendance.TotalSalaryDeducted = e.EmpAttendance.NumberOfExtraLeaves * e.EmpAttendance.OneDaySalary;
                    e.EmpAttendance.SalaryAfterDeduction = e.EmpSal.B_sal - e.EmpAttendance.TotalSalaryDeducted;
                }
            }

            public void ShowDeductionDetails(employee e)
            {
                Console.WriteLine("Total Working Days : " + e.EmpAttendance.NumberOfWorkingDays);
                Console.WriteLine("Total Paid Leaves : " + e.EmpAttendance.NumberOfPaidLeaves);
                Console.WriteLine("Total Extra Leaves : " + e.EmpAttendance.numberofExtraLeaves);
                Console.WriteLine("OneDaySalary : " + e.EmpAttendance.OneDaySalary);
                Console.WriteLine("Total Salary Deduction : " + e.EmpAttendance.TotalSalaryDeducted);
                Console.WriteLine("Total Salary After Deduction : " + e.EmpAttendance.SalaryAfterDeduction);
            }
            /*public void Insertinto_Attendance_Table(employee e)
            {
                // string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = ProjectReview; Integrated Security = True";
                //SqlConnection con = new SqlConnection( DBConfiguration.ConnectionString);
                SqlConnection con = null;
            Line2:
                try
                {
                    using (con = new SqlConnection(DBConfiguration.ConnectionString))
                    {
                        string query = $"insert into {DBConfiguration.Attendance_Table} values(@Attendance_Id,@Employee_Id,@No_of_WorkingDays,@No_of_PaidLeaves,@No_of_ExtraLeaves,@Total_Salary_Deduction,@One_DaySalary,@Salary_AfterDeduction)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        Console.WriteLine("enter Attendance Id");
                        int Attendanceid = int.Parse(Console.ReadLine());
                        ////Console.WriteLine("enter employee name");
                        ////string empname = Console.ReadLine();
                        ////Console.WriteLine("enter employee salary");
                        ////float esalary = float.Parse(Console.ReadLine());
                        ////Console.WriteLine("enter employee Employee_Dateofbirth");
                        ////string Employee_Dateofbirth = Console.ReadLine();
                        ////Console.WriteLine("enter employee Employee_Dateofjoining");
                        ////string Employee_Dateofjoining = Console.ReadLine();
                        ////Console.WriteLine("enter employee Employee_Designation");
                        ////string Employee_Designation = Console.ReadLine();
                        ////Console.WriteLine("enter employee Employee_Workingdays");
                        ////int Employee_Workingdays = int.Parse(Console.ReadLine());
                        cmd.Parameters.AddWithValue("@Attendance_Id", Attendanceid);
                        cmd.Parameters.AddWithValue("@Employee_Id", e.Employeeid);
                        cmd.Parameters.AddWithValue("@No_of_WorkingDays", e.EmpAttendance.NumberOfWorkingDays);
                        cmd.Parameters.AddWithValue("@No_of_PaidLeaves", e.EmpAttendance.NumberOfPaidLeaves);
                        cmd.Parameters.AddWithValue("@No_of_ExtraLeaves", e.EmpAttendance.NumberOfExtraLeaves);
                        cmd.Parameters.AddWithValue("@Total_Salary_Deduction", e.EmpAttendance.TotalSalaryDeducted);
                        cmd.Parameters.AddWithValue("@One_DaySalary", e.EmpAttendance.OneDaySalary);
                        cmd.Parameters.AddWithValue("@Salary_AfterDeduction", e.EmpAttendance.SalaryAfterDeduction);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        //if (k > 0)
                        //{
                        //    Console.WriteLine("Data has been Inserted in Attendence_Table");
                        //}
                        //else { Console.WriteLine("Data Insertion has Failed"); }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Line2;

                }

            }
            //UPDATE ATTENDENCE TABLE
            public void Update_Attendance_Table()
            {

                SqlConnection con = null;
                int No_of_WorkingDays = 0;
                int No_of_PaidLeaves = 0;
                int No_of_ExtraLeaves = 0;
                float Total_Salary_Deduction = 0;
                float One_Day_Salary = 0;
                float Salary_AfterDeduction = 0;
            Line_u2:
                try
                {
                    using (con = new SqlConnection(DBConfiguration.ConnectionString))
                    {
                        Console.WriteLine("Available options to update");

                        Console.WriteLine("1.No of paid Leaves");
                        Console.WriteLine("2.No of extra Leaves");
                        Console.WriteLine("3.Total Salary Deduction");
                        Console.WriteLine("4.One day salary");
                        Console.WriteLine("5.Salary After Deduction");
                        Console.WriteLine("enter your choice");
                        int choice = int.Parse(Console.ReadLine());
                        SqlCommand cmd = null;
                        Console.WriteLine("enter  Attendance id");
                        int Attendance_Id = int.Parse(Console.ReadLine());
                        switch (choice)
                        {

                            case 1:
                                {
                                    String query2 = $"update {DBConfiguration.Attendance_Table}set No_of_PaidLeaves = @No_of_PaidLeaves where Attendance_Id=@Attendance_Id";

                                    cmd = new SqlCommand(query2, con);



                                    Console.WriteLine("enter No of PaidLeaves");
                                    No_of_PaidLeaves = int.Parse(Console.ReadLine());

                                    //cmd.Parameters.AddWithValue("@Attendance_Id", Attendance_Id);
                                    //cmd.Parameters.AddWithValue("@No_of_PaidLeaves", No_of_PaidLeaves);

                                    break;
                                }
                            case 2:
                                {
                                    String query3 = $"update {DBConfiguration.Attendance_Table} set No_of_ExtraLeaves = @ No_of_ExtraLeaves where Attendance_Id=@Attendance_Id";

                                    cmd = new SqlCommand(query3, con);


                                    Console.WriteLine("enter No of ExtraLeaves");
                                    No_of_ExtraLeaves = int.Parse(Console.ReadLine());

                                    //cmd.Parameters.AddWithValue("@Attendance_Id", Attendance_Id);
                                    //cmd.Parameters.AddWithValue("@No_of_ExtraLeaves", No_of_ExtraLeaves);


                                    break;
                                }
                            case 3:
                                {
                                    String query4 = $"update {DBConfiguration.Attendance_Table} set Total_Salary_Deduction = @ Total_Salary_Deduction where Attendance_Id=@Attendance_Id";

                                    cmd = new SqlCommand(query4, con);


                                    Console.WriteLine("enter Total Salary Deduction");
                                    Total_Salary_Deduction = float.Parse(Console.ReadLine());

                                    //cmd.Parameters.AddWithValue("@Attendance_Id", Attendance_Id);
                                    //cmd.Parameters.AddWithValue("@Total_Salary_Deduction", Total_Salary_Deduction);

                                    break;
                                }
                            case 4:
                                {
                                    String query5 = $"update {DBConfiguration.Attendance_Table} set One_Day_Salary = @One_Day_Salary where Attendance_Id=@Attendance_Id";
                                    cmd = new SqlCommand(query5, con);


                                    Console.WriteLine("enter One_Day_Salary");
                                    One_Day_Salary = float.Parse(Console.ReadLine());

                                    //cmd.Parameters.AddWithValue("@Attendance_Id", Attendance_Id);
                                    //cmd.Parameters.AddWithValue("@One_Day_Salary", One_Day_Salary);
                                    break;
                                }
                            case 5:
                                {
                                    String query6 = $"update {DBConfiguration.Attendance_Table} set Salary_AfterDeduction = @Salary_AfterDeduction where Attendance_Id=@Attendance_Id";

                                    cmd = new SqlCommand(query6, con);



                                    Console.WriteLine("enter Salary_AfterDeduction ");
                                    Salary_AfterDeduction = float.Parse(Console.ReadLine());

                                    //cmd.Parameters.AddWithValue("@Employee_Id", Attendance_Id);
                                    //cmd.Parameters.AddWithValue("@Salary_AfterDeduction", Salary_AfterDeduction);


                                    break;
                                }
                            default:
                                Console.WriteLine("updation failed");
                                break;
                        }

                        cmd.Parameters.AddWithValue("@Attendance_Id", Attendance_Id);
                        cmd.Parameters.AddWithValue("@No_of_PaidLeaves", No_of_PaidLeaves);
                        cmd.Parameters.AddWithValue("@No_of_ExtraLeaves", No_of_ExtraLeaves);
                        cmd.Parameters.AddWithValue("@Total_Salary_Deduction", Total_Salary_Deduction);
                        cmd.Parameters.AddWithValue("@One_Day_Salary", One_Day_Salary);
                        cmd.Parameters.AddWithValue("@Salary_AfterDeduction", Salary_AfterDeduction);

                        con.Open();
                        int k = cmd.ExecuteNonQuery();
                        if (k > 0)
                        {
                            Console.WriteLine("Data has been updated ");
                        }
                        else
                        {
                            Console.WriteLine("Data updation failed");
                        }



                        // Console.WriteLine("The Updated Record in the Attendance Table");
                        //string query = "select * from dbo.Attendance_Table where @Attendance_Id = Attendance_Id";
                        //SqlCommand cmd2 = new SqlCommand(query, con);
                        //Console.WriteLine("enter Attendance id");
                        //string Attendance_id = Console.ReadLine();
                        //cmd2.Parameters.AddWithValue("@Attendance_Id", Attendance_id);
                        //SqlDataReader dr = cmd2.ExecuteReader();
                        //while (dr.Read())
                        //{
                        //  Console.WriteLine("Attendance_Id: = " + dr["Attendance_Id"]+ "Employee_Id: = " + dr["Employee_Id"] + "No_of_WorkingDays:= " + dr["No_of_WorkingDays"]
                        //    + " No_of_PaidLeaves :=" + dr["No_of_PaidLeaves"] + " No_of_ExtraLeaves : = " + dr["No_of_ExtraLeaves"]
                        // + " Total_Salary_Deduction : = " + dr["Total_Salary_Deduction"] + "One_Day_Salary : = " + dr["One_Day_Salary"] + "Salary_AfterDeduction : = " + dr["Salary_AfterDeduction"]);

                        //}
                    }
                }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Line_u2;
                }
                finally
                {
                    con.Close();
                }



            }*/



            #endregion
        }
        public class salary : Attendance
        {
            private int b_sal;
            public int B_sal
            {
                get { return b_sal; }
                set { b_sal = value; }
            }
            private int ctc;
            public int Ctc
            {
                get { return ctc; }
                set { ctc = value; }
            }

            public salary()
            {
                this.B_sal = 0;
                this.Ctc = 0;
            }



            public void DisplpayEmployeeSalary(employee e)
            {
                Console.WriteLine("Employee Base Salary : " + e.EmpSal.B_sal);
                Console.WriteLine("Employee CTC : " + e.EmpSal.Ctc);
            }

            public void SetSalaryByLevel(employee e)
            {
                if (e.EmpDesignation.Level == 1)
                {
                    e.EmpSal.Ctc = 1200000;
                    e.EmpSal.B_sal = (e.EmpSal.Ctc / 12);
                }

                if (e.EmpDesignation.Level == 2)
                {
                    e.EmpSal.Ctc = 2500000;
                    e.EmpSal.B_sal = (e.EmpSal.Ctc / 12);
                }

                if (e.EmpDesignation.Level == 3)
                {
                    e.EmpSal.Ctc = 4200000;
                    e.EmpSal.B_sal = (e.EmpSal.Ctc / 12);
                }
            }
            /*public void Insertinto_Salary_Table(employee e)
            {
                // string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = ProjectReview; Integrated Security = True";
                //SqlConnection con = new SqlConnection( DBConfiguration.ConnectionString);
                SqlConnection con = null;
            Line3:
                try
                {
                    using (con = new SqlConnection(DBConfiguration.ConnectionString))
                    {
                        string query = $"insert into {DBConfiguration.Salary_Table} values(@Salary_Id,@Employee_Id,@Basic_Salary,@CTC)";
                        SqlCommand cmd = new SqlCommand(query, con);

                        Console.WriteLine("enter Salary Id");
                        int salaryid = int.Parse(Console.ReadLine());
                        //Console.WriteLine("enter Attendance Id");
                        //int Attendanceid = int.Parse(Console.ReadLine());
                        ////Console.WriteLine("enter employee salary");
                        ////float esalary = float.Parse(Console.ReadLine());
                        ////Console.WriteLine("enter employee Employee_Dateofbirth");
                        ////string Employee_Dateofbirth = Console.ReadLine();
                        ////Console.WriteLine("enter employee Employee_Dateofjoining");
                        ////string Employee_Dateofjoining = Console.ReadLine();
                        ////Console.WriteLine("enter employee Employee_Designation");
                        ////string Employee_Designation = Console.ReadLine();
                        ////Console.WriteLine("enter employee Employee_Workingdays");
                        ////int Employee_Workingdays = int.Parse(Console.ReadLine());
                        cmd.Parameters.AddWithValue("@Salary_Id", salaryid);
                        //cmd.Parameters.AddWithValue("@Attendance_Id", Attendanceid);
                        cmd.Parameters.AddWithValue("@Employee_Id", e.Employeeid);
                        cmd.Parameters.AddWithValue("@Basic_Salary", e.EmpSal.B_sal);
                        cmd.Parameters.AddWithValue("@CTC", e.EmpSal.Ctc);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        //if (k > 0)
                        //{
                        //    Console.WriteLine("Data has been Inserted in Salary_Table");
                        //}
                        //else { Console.WriteLine("Data Insertion has Failed"); }
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Line3;
                }
            }
            //UPDATE SALARY TABLE
            public void Update_Salary_Table()
            {

                SqlConnection con = null;
                float Basic_Salary = 0;
                float CTC = 0;
            Line_u3:
                try
                {
                    using (con = new SqlConnection(DBConfiguration.ConnectionString))
                    {
                        Console.WriteLine("Available options to update");
                        Console.WriteLine("1.Basic Salary");
                        Console.WriteLine("2.CTC");
                        Console.WriteLine("enter your choice");
                        int choice = int.Parse(Console.ReadLine());
                        SqlCommand cmd = null;
                        Console.WriteLine("enter Salary id");
                        int Salary_Id = int.Parse(Console.ReadLine());

                        switch (choice)
                        {


                            case 1:
                                {
                                    String query2 = $"update {DBConfiguration.Salary_Table}  set Basic_Salary=@Basic_Salary where Salary_Id=@Salary_Id";

                                    cmd = new SqlCommand(query2, con);

                                    //Console.WriteLine("enter employee id");
                                    //string Employee_Id = Console.ReadLine();

                                    Console.WriteLine("enter basic salary");
                                    Basic_Salary = float.Parse(Console.ReadLine());
                                    //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                    //cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);

                                    break;
                                }

                            case 2:
                                {
                                    String query3 = $"update {DBConfiguration.Salary_Table} set CTC=@CTC where Salary_Id=@Salary_Id";

                                    cmd = new SqlCommand(query3, con);

                                    //Console.WriteLine("enter employee id");
                                    //string Employee_Id = Console.ReadLine();

                                    Console.WriteLine("enter employee CTC");
                                    CTC = float.Parse(Console.ReadLine());
                                    //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);

                                    //cmd.Parameters.AddWithValue("@Employee_Dateofjoining", Employee_Dateofjoining);

                                    break;
                                }





                            default:
                                Console.WriteLine("updation failed");
                                break;
                        }
                        cmd.Parameters.AddWithValue("@Salary_Id", Salary_Id);
                        cmd.Parameters.AddWithValue("@Basic_Salary", Basic_Salary);
                        cmd.Parameters.AddWithValue("@CTC", CTC);

                        con.Open();
                        int k = cmd.ExecuteNonQuery();
                        if (k > 0)
                        {
                            Console.WriteLine("Data has been updated ");
                        }
                        else
                        {
                            Console.WriteLine("Data updation failed");
                        }


                        //Console.WriteLine("The Updated Record in the Employee Table");
                        //string query_Select = $"select * from {DBConfiguration.Employee_Table} where @Employee_Id = Employee_Id";
                        //SqlCommand cmd2 = new SqlCommand(query_Select, con);
                        //Console.WriteLine("enter Employee id");
                        //string employee_id = Console.ReadLine();
                        //cmd2.Parameters.AddWithValue("@Employee_Id", employee_id);
                        //SqlDataReader dr = cmd2.ExecuteReader();
                        //while (dr.Read())
                        //{
                        //    Console.WriteLine("Employee_Id: = " + dr["Employee_Id"] + " Name:= " + dr["Employee_Name"] + " Salary:=" + dr["Employee_salary"] +
                        //      "  Date-of-Joining: = " + dr["Employee_Dateofjoining"] + "  Designation: = " + dr["Employee_Designation"]+"Employee Working Days:" + dr["Employee_Woringdays"]);

                        //}
                    }
                }

                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Line_u3;
                }
                finally
                {
                    con.Close();
                }
            }*/

        }
        public class Allowances : salary
        {

            // make these private get and set all of them variables
            private int houseallowances;
            public int Houseallowances
            {
                get { return houseallowances; }
                set { houseallowances = value; }
            }
            private int carloanallowance;
            public int Carloanallowance
            {
                get { return carloanallowance; }
                set { carloanallowance = value; }
            }
            // add more allowances
            // if you want

            public Allowances()
            {
                // 0 is set because all these values will be Calculated based on the level of the person

                this.Houseallowances = 0;
                this.Carloanallowance = 0;
            }

            public void Display_Employee_Allowances(employee e)
            {
                Console.WriteLine("Employee Car Loan Allowance : " + e.EmpAllw.Carloanallowance);
                Console.WriteLine("Employee House Loan Allowance : " + e.EmpAllw.Houseallowances);

            }

            public void AllowanceSetByLevel(employee e)
            {
                if (e.EmpDesignation.Level == 1)
                {
                    e.EmpAllw.Carloanallowance = 12000;
                    e.EmpAllw.Houseallowances = 18000;
                }

                if (e.EmpDesignation.Level == 2)
                {
                    //sConsole.WriteLine("Running For Level 2");
                    e.EmpAllw.Carloanallowance = 15000;
                    e.EmpAllw.Houseallowances = 20000;
                }

                if (e.EmpDesignation.Level == 3)
                {
                    e.EmpAllw.Carloanallowance = 18000;
                    e.EmpAllw.Houseallowances = 22000;
                }

            }
            /* public void Insertinto_Allowance_Table(employee e)
             {
                 // string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = ProjectReview; Integrated Security = True";
                 //SqlConnection con = new SqlConnection( DBConfiguration.ConnectionString);
                 SqlConnection con = null;
             Line4:
                 try
                 {
                     using (con = new SqlConnection(DBConfiguration.ConnectionString))
                     {
                         string query = $"insert into {DBConfiguration.Allowance_Table} values(@Allowance_Id,@Employee_Id,@Carloanallowance,@Houseallowances)";
                         SqlCommand cmd = new SqlCommand(query, con);
                         Console.WriteLine("enter Allowance Id");
                         int allowanceid = int.Parse(Console.ReadLine());
                         //Console.WriteLine("enter Salary id");
                         //int salaryid = int.Parse(Console.ReadLine());
                         ////Console.WriteLine("enter employee salary");
                         ////float esalary = float.Parse(Console.ReadLine());
                         ////Console.WriteLine("enter employee Employee_Dateofbirth");
                         ////string Employee_Dateofbirth = Console.ReadLine();
                         ////Console.WriteLine("enter employee Employee_Dateofjoining");
                         ////string Employee_Dateofjoining = Console.ReadLine();
                         ////Console.WriteLine("enter employee Employee_Designation");
                         ////string Employee_Designation = Console.ReadLine();
                         ////Console.WriteLine("enter employee Employee_Workingdays");
                         ////int Employee_Workingdays = int.Parse(Console.ReadLine());
                         cmd.Parameters.AddWithValue("@Allowance_Id", allowanceid);
                         //cmd.Parameters.AddWithValue("@Salary_Id", salaryid);
                         cmd.Parameters.AddWithValue("@Employee_Id", e.Employeeid);
                         cmd.Parameters.AddWithValue("@Carloanallowance", e.EmpAllw.Carloanallowance);
                         cmd.Parameters.AddWithValue("@Houseallowances", e.EmpAllw.Houseallowances);
                         con.Open();
                         cmd.ExecuteNonQuery();
                         //if (k > 0)
                         //{
                         //    Console.WriteLine("Data has been Inserted in Allowances_Table");
                         //}
                         //else { Console.WriteLine("Data Insertion has Failed"); }
                     }
                 }
                 catch (SqlException ex)
                 {
                     Console.WriteLine(ex.Message);
                     goto Line4;
                 }
             }
             //UPDATE ALLOWANCES
             public void Update_Allowance_Table()
             {

                 SqlConnection con = null;

                 float Carloanallowance = 0;
                 float Houseallowances = 0;
             Line_u4:
                 try
                 {
                     using (con = new SqlConnection(DBConfiguration.ConnectionString))
                     {
                         Console.WriteLine("\nAvailable options to update");
                         Console.WriteLine("1.Carloanallowance");
                         Console.WriteLine("2.Houseallowamces");
                         Console.WriteLine("enter your choice");
                         int choice = int.Parse(Console.ReadLine());
                         SqlCommand cmd = null;
                         Console.WriteLine("enter Allowace id");
                         int Allowance_Id = int.Parse(Console.ReadLine());

                         switch (choice)
                         {
                             case 1:
                                 {
                                     String query1 = $"update {DBConfiguration.Allowance_Table} set Carloanallowance=@Carloanallowance where Allowance_Id=@Allowance_Id";

                                     cmd = new SqlCommand(query1, con);



                                     Console.WriteLine("Carloanallowance");
                                     Carloanallowance = float.Parse(Console.ReadLine());




                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                     //cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name);
                                     //cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);
                                     //cmd.Parameters.AddWithValue("@Employee_Dateofjoining", Employee_Dateofjoining);
                                     //cmd.Parameters.AddWithValue("@Employee_Designation", Employee_Designation);
                                     //cmd.Parameters.AddWithValue("@Employee_Workingdays", Employee_Workingdays);


                                     break;
                                 }

                             case 2:
                                 {
                                     String query2 = $"update {DBConfiguration.Allowance_Table}  set Houseallowances=@Houseallowances where Allowance_Id=@Allowance_Id";

                                     cmd = new SqlCommand(query2, con);

                                     //Console.WriteLine("enter employee id");
                                     //string Employee_Id = Console.ReadLine();

                                     Console.WriteLine("enter Houseallowances");
                                     Houseallowances = float.Parse(Console.ReadLine());
                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                     //cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);

                                     break;
                                 }





                             default:
                                 Console.WriteLine("updation failed");
                                 break;
                         }
                         cmd.Parameters.AddWithValue("@Allowance_Id", Allowance_Id);
                         cmd.Parameters.AddWithValue("@Carloanallowance", Carloanallowance);
                         cmd.Parameters.AddWithValue("@Houseallowances", Houseallowances);

                         con.Open();
                         int k = cmd.ExecuteNonQuery();
                         if (k > 0)
                         {
                             Console.WriteLine("Data has been updated ");
                         }
                         else
                         {
                             Console.WriteLine("Data updation failed");
                         }


                         //Console.WriteLine("The Updated Record in the Allowence Table");
                         //string query_Select = $"select * from {DBConfiguration.Employee_Table} where @Employee_Id = Employee_Id";
                         //SqlCommand cmd2 = new SqlCommand(query_Select, con);
                         //Console.WriteLine("enter Employee id");
                         //string employee_id = Console.ReadLine();
                         //cmd2.Parameters.AddWithValue("@Employee_Id", employee_id);
                         //SqlDataReader dr = cmd2.ExecuteReader();
                         //while (dr.Read())
                         //{
                         //    Console.WriteLine("Employee_Id: = " + dr["Employee_Id"] + " Name:= " + dr["Employee_Name"] + " Salary:=" + dr["Employee_salary"] +
                         //      "  Date-of-Joining: = " + dr["Employee_Dateofjoining"] + "  Designation: = " + dr["Employee_Designation"]+"Employee Working Days:" + dr["Employee_Woringdays"]);

                         //}
                     }
                 }

                 catch (SqlException ex)
                 {
                     Console.WriteLine(ex.Message);
                     goto Line_u4;
                 }
                 finally
                 {
                     con.Close();
                 }



             }*/





        }
        public class employee : Allowances
        {
            private int employeeid;
            public int Employeeid
            {
                get { return employeeid; }
                set { employeeid = value; }
            }

            private string employeename;
            public string Employeename
            {
                get { return employeename; }
                set { employeename = value; }
            }
            private string employedate;
            public string Employedate
            {
                get { return employedate; }
                set { employedate = value; }
            }
            private salary emp_sal;
            public salary EmpSal
            {
                get { return emp_sal; }
                set
                {
                    emp_sal = value;
                }
            }
            private Allowances emp_allw;
            public Allowances EmpAllw
            {
                get { return emp_allw; }
                set
                {
                    emp_allw = value;
                }
            }
            private Designation emp_designation;
            public Designation EmpDesignation
            {
                get { return emp_designation; }
                set { emp_designation = value; }
            }
            private Attendance emp_attendance;
            public Attendance EmpAttendance
            {
                get { return emp_attendance; }
                set
                {
                    emp_attendance = value;
                }
            }



            public employee()
            {
                this.EmpSal = new salary();
                this.EmpAllw = new Allowances();
                this.EmpDesignation = new Designation();
                this.EmpAttendance = new Attendance();
            }


            public employee(int emp_id, string emp_name, string emp_date, salary emp_sal, Allowances emp_all, Designation emp_des, Attendance emp_att)
            {
                this.Employeeid = emp_id;
                this.Employeename = emp_name;
                this.Employedate = emp_date;
                this.EmpSal = emp_sal;
                this.EmpAllw = emp_all;
                this.EmpDesignation = emp_des;
                this.EmpAttendance = emp_att;
            }
            /* public void Insertinto_Employee_Table(employee e)
             {
                 // string cs = @"Data Source = (LocalDB)\MSSQLLocalDB; Initial Catalog = ProjectReview; Integrated Security = True";
                 //SqlConnection con = new SqlConnection( DBConfiguration.ConnectionString);
                 SqlConnection con = null;
             Line5:
                 try
                 {
                     using (con = new SqlConnection(DBConfiguration.ConnectionString))
                     {
                         string query = $"insert into {DBConfiguration.Employee_Table} values(@Employee_Id,@Employee_Name,@Employee_Salary,@Employee_Dateofjoining,@Employee_Designation,@Employee_Workingdays)";
                         SqlCommand cmd = new SqlCommand(query, con);

                         ////Console.WriteLine("enter employee Id");
                         ////int empid = int.Parse(Console.ReadLine());
                         ////Console.WriteLine("enter employee name");
                         ////string empname = Console.ReadLine();
                         ////Console.WriteLine("enter employee salary");
                         ////float esalary = float.Parse(Console.ReadLine());
                         ////Console.WriteLine("enter employee Employee_Dateofbirth");
                         ////string Employee_Dateofbirth = Console.ReadLine();
                         ////Console.WriteLine("enter employee Employee_Dateofjoining");
                         ////string Employee_Dateofjoining = Console.ReadLine();
                         ////Console.WriteLine("enter employee Employee_Designation");
                         ////string Employee_Designation = Console.ReadLine();
                         ////Console.WriteLine("enter employee Employee_Workingdays");
                         ////int Employee_Workingdays = int.Parse(Console.ReadLine());

                         cmd.Parameters.AddWithValue("@Employee_Id", e.employeeid);
                         cmd.Parameters.AddWithValue("@Employee_Name", e.employeename);
                         cmd.Parameters.AddWithValue("@Employee_Salary", e.emp_sal.B_sal);
                         cmd.Parameters.AddWithValue("@Employee_Dateofjoining", e.employedate);
                         cmd.Parameters.AddWithValue("@Employee_Designation", e.emp_designation.EmpDes);
                         cmd.Parameters.AddWithValue("@Employee_Workingdays", e.emp_attendance.NumberOfWorkingDays);
                         con.Open();
                         cmd.ExecuteNonQuery();
                         //if (k > 0)
                         //{
                         //    Console.WriteLine("Data has been Inserted in Employee_Table");
                         //}
                         //else { Console.WriteLine("Data Insertion has Failed"); }
                     }
                 }
                 catch (SqlException ex)
                 {
                     Console.WriteLine(ex.Message);
                     goto Line5;
                 }
             }
             //UPDATION EMPLOYEE TABLE
             public void Update_EmployeeTable()
             {

                 SqlConnection con = null;
                 string Employee_Name = "";
                 float Employee_Salary = 0;
                 string Employee_Dateofjoining = "";
                 string Employee_Designation = "";
                 int Employee_Workingdays = 0;
             Line_u5:
                 try
                 {
                     using (con = new SqlConnection(DBConfiguration.ConnectionString))
                     {
                         Console.WriteLine("Available options to update");
                         Console.WriteLine("1.employee name");
                         Console.WriteLine("2.employee salary");
                         Console.WriteLine("3.employee date of joining");
                         Console.WriteLine("4.employee Designation");
                         Console.WriteLine("5.employee workingDays");

                         Console.WriteLine("enter your choice ");
                         int choice = int.Parse(Console.ReadLine());
                         SqlCommand cmd = null;
                         Console.WriteLine("enter employee id");
                         string Employee_Id = Console.ReadLine();

                         switch (choice)
                         {
                             case 1:
                                 {
                                     String query1 = $"update {DBConfiguration.Employee_Table} set Employee_Name=@Employee_Name where Employee_Id=@Employee_Id";

                                     cmd = new SqlCommand(query1, con);



                                     Console.WriteLine("enter employee Name");
                                     Employee_Name = Console.ReadLine();




                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                     //cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name);
                                     //cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);
                                     //cmd.Parameters.AddWithValue("@Employee_Dateofjoining", Employee_Dateofjoining);
                                     //cmd.Parameters.AddWithValue("@Employee_Designation", Employee_Designation);
                                     //cmd.Parameters.AddWithValue("@Employee_Workingdays", Employee_Workingdays);


                                     break;
                                 }

                             case 2:
                                 {
                                     String query2 = $"update {DBConfiguration.Employee_Table}  set Employee_Salary=@Employee_Salary where Employee_Id=@Employee_Id";

                                     cmd = new SqlCommand(query2, con);

                                     //Console.WriteLine("enter employee id");
                                     //string Employee_Id = Console.ReadLine();

                                     Console.WriteLine("enter employee salary");
                                     Employee_Salary = float.Parse(Console.ReadLine());
                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                     //cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);

                                     break;
                                 }

                             case 3:
                                 {
                                     String query3 = $"update {DBConfiguration.Employee_Table} set Employee_Dateofjoining=@Employee_Dateofjoining where Employee_Id=@Employee_Id";

                                     cmd = new SqlCommand(query3, con);

                                     //Console.WriteLine("enter employee id");
                                     //string Employee_Id = Console.ReadLine();

                                     Console.WriteLine("enter employee Dateofjoining");
                                     Employee_Dateofjoining = Console.ReadLine();
                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);

                                     //cmd.Parameters.AddWithValue("@Employee_Dateofjoining", Employee_Dateofjoining);

                                     break;
                                 }
                             case 4:
                                 {
                                     String query4 = $"update {DBConfiguration.Employee_Table} set Employee_Designation=@Employee_Designation where Employee_Id=@Employee_Id";

                                     cmd = new SqlCommand(query4, con);

                                     //Console.WriteLine("enter employee id");
                                     //string Employee_Id = Console.ReadLine();

                                     Console.WriteLine("The available Designations are:");
                                     Console.WriteLine("Manager\n  HR\n  Developer\n  Analyst\n  Maintanance\n  Senior Manager ");

                                     Console.WriteLine("enter employee Designation");
                                     Employee_Designation = Console.ReadLine();
                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);

                                     //cmd.Parameters.AddWithValue("@Employee_Designation", Employee_Designation);

                                     break;
                                 }
                             case 5:
                                 {
                                     String query5 = $"update {DBConfiguration.Employee_Table} set Employee_Workingdays=@Employee_Workingdays where Employee_Id=@Employee_Id";

                                     cmd = new SqlCommand(query5, con);

                                     //Console.WriteLine("enter employee id");
                                     //string Employee_Id = Console.ReadLine();

                                     Console.WriteLine("enter employee workingdays ");
                                     Employee_Workingdays = int.Parse(Console.ReadLine());

                                     //cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                                     //cmd.Parameters.AddWithValue("@Employee_Workingdays", Employee_Workingdays);
                                     break;

                                 }




                             default:
                                 Console.WriteLine("updation failed");
                                 break;
                         }
                         cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);
                         cmd.Parameters.AddWithValue("@Employee_Name", Employee_Name);
                         cmd.Parameters.AddWithValue("@Employee_Salary", Employee_Salary);
                         cmd.Parameters.AddWithValue("@Employee_Dateofjoining", Employee_Dateofjoining);
                         cmd.Parameters.AddWithValue("@Employee_Designation", Employee_Designation);
                         cmd.Parameters.AddWithValue("@Employee_Workingdays", Employee_Workingdays);
                         con.Open();
                         int k = cmd.ExecuteNonQuery();
                         if (k > 0)
                         {
                             Console.WriteLine("Data has been updated ");
                         }
                         else
                         {
                             Console.WriteLine("Data updation failed");
                         }


                         //Console.WriteLine("The Updated Record in the Employee Table");
                         //string query_Select = $"select * from {DBConfiguration.Employee_Table} where @Employee_Id = Employee_Id";
                         //SqlCommand cmd2 = new SqlCommand(query_Select, con);
                         //Console.WriteLine("enter Employee id");
                         //string employee_id = Console.ReadLine();
                         //cmd2.Parameters.AddWithValue("@Employee_Id", employee_id);
                         //SqlDataReader dr = cmd2.ExecuteReader();
                         //while (dr.Read())
                         //{
                         //    Console.WriteLine("Employee_Id: = " + dr["Employee_Id"] + " Name:= " + dr["Employee_Name"] + " Salary:=" + dr["Employee_salary"] +
                         //      "  Date-of-Joining: = " + dr["Employee_Dateofjoining"] + "  Designation: = " + dr["Employee_Designation"]+"Employee Working Days:" + dr["Employee_Woringdays"]);

                         //}
                     }
                 }

                 catch (SqlException ex)
                 {
                     Console.WriteLine(ex.Message);
                     goto Line_u5;
                 }
                 finally
                 {
                     con.Close();
                 }

             }*/






            //public void displayemployeedetails()
            //{
            // Console.WriteLine("employee name:" + this.Employeename);
            // Console.WriteLine("employee id:" + this.Employeeid);
            //Console.WriteLine("employee dateofbirth:" + this.Employedate);
            //Console.WriteLine("employee basesalary:" + this.EmpSal.B_sal);
            //Console.WriteLine("employee CTC:" + this.EmpSal.Ctc);
            //Console.WriteLine("employee houseallowances:" + this.EmpAllw.Houseallowancces);
            //Console.WriteLine("employee carallowances:" + this.EmpAllw.Carloanallowance);

            // }


            public void DisplayPaySlip(employee e)
            {
                // Call Few Functions to the prior.
                // DO NOT TOUCH THE FUNCTIONS AT ALL
                e.Designation_Set_By_Lvl(e);
                e.SetSalaryByLevel(e);
                e.AllowanceSetByLevel(e);
                e.ExecuteDeduction(e);


                Console.WriteLine("-----------------------------------------------------------------------------------------");
                //// Implement payslip from here
                String[,] payslip = new String[4, 4];
                payslip[0, 0] = "                                    PAYSLIP";
                payslip[1, 0] = "Employee Name: ";
                payslip[1, 2] = "                                            Date Of Joining: ";
                payslip[2, 0] = "Designation: ";
                payslip[1, 1] = Convert.ToString(e.Employeename);
                payslip[2, 1] = Convert.ToString(e.EmpDesignation.EmpDes);
                payslip[1, 3] = e.Employedate;

                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(payslip[i, j]);
                    }
                    Console.WriteLine();
                }

                String[,] PAYslip = new String[7, 7];
                PAYslip[0, 0] = "Earnings";
                PAYslip[0, 1] = "               Amount";
                PAYslip[0, 2] = "                     Deductions";
                PAYslip[0, 3] = "                         Amount";

                PAYslip[1, 0] = "Basic                  ";
                PAYslip[2, 0] = "Car Loan Allowance     ";
                PAYslip[3, 0] = "Home Loan Allowance    ";
                int provident_fund = (e.EmpSal.Ctc / 10);
                PAYslip[4, 0] = "provident fund         ";
                PAYslip[5, 0] = "Total Earnings         ";
                int total_earnings = e.EmpSal.B_sal + e.EmpAllw.Carloanallowance + e.EmpAllw.Houseallowances + provident_fund;
                PAYslip[1, 1] = Convert.ToString(e.EmpSal.B_sal);
                PAYslip[2, 1] = Convert.ToString(e.EmpAllw.Carloanallowance);
                PAYslip[3, 1] = Convert.ToString(e.EmpAllw.Houseallowances);
                PAYslip[4, 1] = Convert.ToString(provident_fund);
                PAYslip[5, 1] = Convert.ToString(total_earnings);

                int total_deduction = e.EmpAttendance.TotalSalaryDeducted;
                PAYslip[1, 2] = "                     Salary deduction                   ";
                PAYslip[5, 2] = "                    Total deduction:                   ";
                PAYslip[1, 3] = Convert.ToString(e.EmpAttendance.TotalSalaryDeducted);
                PAYslip[5, 3] = Convert.ToString(total_deduction);
                int Netincome = total_earnings - total_deduction;

                PAYslip[6, 1] = "                              Net Income:     ";
                PAYslip[6, 2] = Convert.ToString(Netincome);
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        Console.Write(PAYslip[i, j]);
                    }
                    Console.WriteLine();
                }
                //e.Display_Employee_Allowances(e);
                //e.DisplpayEmployeeSalary(e);
                //e.ShowDeductionDetails(e);

            }



            // public void TakeInput(employee e)
            //{
            // TAKE INPUT AND HANDLE EXCEPTION HANDLING HERE ONLY
            // TAKE SEPERATE VARIABLES AND THEN TRY TO PASS THE VARIABLES IN THE CONTRUCTORS OF THE CLASSES. LIKE
            // DONE IN THE MAIN FUNCTION

            // }
            /*public void Handle_Insertion(employee e)
            {
                e.Insertinto_Employee_Table(e);
                e.Insertinto_Designation_Table(e);
                e.Insertinto_Attendance_Table(e);
                e.Insertinto_Salary_Table(e);
                e.Insertinto_Allowance_Table(e);
            }


            public void Handle_Updation(employee e)
            {

                Console.WriteLine("Avialable options to Update");
                Console.WriteLine("1.Update_EmployeeTable");
                Console.WriteLine("2.Update_Attendance_Table");
                Console.WriteLine("3.Update_Salary_Table");
                Console.WriteLine("4.Update_Allowance_Table");
                Console.WriteLine("5.Update_Designation_Table");
                //Console.WriteLine("6.Update_Level");
                Console.WriteLine("Enter your choice for updation");
                int value = int.Parse(Console.ReadLine());
                if (value == 1)
                {
                    e.Update_EmployeeTable();
                }
                if (value == 2)
                {
                    e.Update_Attendance_Table();
                }
                if (value == 3)
                {
                    e.Update_Salary_Table();
                }
                if (value == 4)
                {
                    e.Update_Allowance_Table();
                }
                if (value == 5)
                {
                    e.Update_Designation_Table();
                }

                //if (value == 6)
                //{
                //  e.UPDATE_RECORD();
                //}
            }
            //public void UPDATE_RECORD()
            //{
            //  SqlConnection con = null;
            //SqlCommand cmd = null;

            //string query = $"update from {DBConfiguration.Employee_Table} where Employee_Id = @Employee_Id";
            //string query1 = $"update  {DBConfiguration.Allowance_Table} set  where Employee_Id = @Employee_Id";
            //string query2 = $"update {DBConfiguration.Salary_Table} set where Employee_Id = @Employee_Id";
            //string query3 = $"update  {DBConfiguration.Attendance_Table} set where Employee_Id = @Employee_Id";
            //string query4 = $"update  {DBConfiguration.Designation_Table} set Employee_Level = @Employee_Level, Employee_Designation = @Employee_Designation where Employee_Id = @Employee_Id";

            //Console.WriteLine("Enter Employee ID : ");
            //int emp_id = Convert.ToInt32(Console.ReadLine());

            //try
            //{
            // using (con = new SqlConnection(DBConfiguration.ConnectionString))
            //{


            //cmd = new SqlCommand(query1, con);
            //con.Open();
            //cmd.Parameters.Add("@Employee_Id", emp_id);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //cmd = new SqlCommand(query2, con);
            //con.Open();
            //cmd.Parameters.Add("@Employee_Id", emp_id);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //cmd = new SqlCommand(query3, con);
            //con.Open();
            // cmd.Parameters.Add("@Employee_Id", emp_id);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //Console.WriteLine("Enter Employee Level : ");
            //int emp_lev = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("The available Designations are:");
            //Console.WriteLine("  Manager\n  HR\n  Developer\n  Analyst\n  Maintanance\n  Senior Manager ");

            //Console.WriteLine("Enter Employee Designation : ");
            //string emp_des = Console.ReadLine();

            //cmd = new SqlCommand(query4, con);
            //con.Open();
            //cmd.Parameters.Add("@Employee_Id", emp_id);
            //cmd.Parameters.Add("@Employee_Level", emp_lev);
            //cmd.Parameters.Add("@Employee_Designation", emp_des);
            //cmd.ExecuteNonQuery();
            //con.Close();

            //cmd = new SqlCommand(query, con);
            //con.Open();
            //cmd.Parameters.Add("@Employee_Id", emp_id);
            //cmd.ExecuteNonQuery();
            //con.Close();


            //Console.WriteLine(emp_id + "Employee Id is updated");
            //}
            //}
            //catch (SqlException ex)
            //{
            //  Console.WriteLine(ex.Message);
            //}

            //}
            public void DELETE_RECORD()
            {
                SqlConnection con = null;
                SqlCommand cmd = null;

                string query = $"Delete from {DBConfiguration.Employee_Table} where Employee_Id = @Employee_Id";
                string query1 = $"Delete from {DBConfiguration.Allowance_Table} where Employee_Id = @Employee_Id";
                string query2 = $"Delete from {DBConfiguration.Salary_Table} where Employee_Id = @Employee_Id";
                string query3 = $"Delete from {DBConfiguration.Attendance_Table} where Employee_Id = @Employee_Id";
                string query4 = $"Delete from {DBConfiguration.Designation_Table} where Employee_Id = @Employee_Id";

                Console.WriteLine("Enter Employee ID : ");
                int emp_id = Convert.ToInt32(Console.ReadLine());

                try
                {
                    using (con = new SqlConnection(DBConfiguration.ConnectionString))
                    {


                        cmd = new SqlCommand(query1, con);
                        con.Open();
                        cmd.Parameters.Add("@Employee_Id", emp_id);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        cmd = new SqlCommand(query2, con);
                        con.Open();
                        cmd.Parameters.Add("@Employee_Id", emp_id);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        cmd = new SqlCommand(query3, con);
                        con.Open();
                        cmd.Parameters.Add("@Employee_Id", emp_id);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        cmd = new SqlCommand(query4, con);
                        con.Open();
                        cmd.Parameters.Add("@Employee_Id", emp_id);
                        cmd.ExecuteNonQuery();
                        con.Close();

                        cmd = new SqlCommand(query, con);
                        con.Open();
                        cmd.Parameters.Add("@Employee_Id", emp_id);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        Console.WriteLine(emp_id + "Employee Id is deleted");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            public void Select_From_Tables(employee e)
            {
                SqlConnection con = null;
                SqlCommand cmd = null;
                SqlDataReader dr = null;

                string query = $"select *  from {DBConfiguration.Employee_Table}";
                string query2 = $"select *  from {DBConfiguration.Salary_Table}";
                string query3 = $"select *  from {DBConfiguration.Allowance_Table}";
                string query4 = $"select *  from {DBConfiguration.Attendance_Table}";
                string query5 = $"select *  from {DBConfiguration.Designation_Table}";

                try
                {
                    using (con = new SqlConnection(DBConfiguration.ConnectionString))
                    {
                        Console.WriteLine("1. Show Employee Table");
                        Console.WriteLine("2. Show Salary Table");
                        Console.WriteLine("3. Show Allowance Table");
                        Console.WriteLine("4. Show Attendence Table");
                        Console.WriteLine("5. Show Designation Table");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        if (choice == 1)
                        {

                            Console.WriteLine("Press 1 : To show all Employee");
                            Console.WriteLine("Press 2 : To show the specific Employee");
                            int choice_inner = Convert.ToInt32(Console.ReadLine());

                            if (choice_inner == 1)
                            {
                                Console.WriteLine("Displying all the Employee Table : ");
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                dr = cmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    Console.WriteLine($"Employee Id : {dr["Employee_Id"]}  Employee Name:{dr["Employee_Name"]}   Employee Salary: {dr["Employee_Salary"]}  Date of Joining:  {dr["Employee_Dateofjoining"]}  Employee_Designation: {dr["Employee_Designation"]}   Employee_Workingdays: {dr["Employee_Workingdays"]}");
                                }

                            }
                            else if (choice_inner == 2)
                            {
                                Console.WriteLine("Displying one employee : ");
                                Console.WriteLine("Enter Employee Id");
                                int temp_emp_id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Runing");
                                cmd = new SqlCommand(query, con);
                                con.Open();
                                dr = cmd.ExecuteReader();

                                while (dr.Read())
                                {
                                    if (temp_emp_id == Convert.ToInt32(dr["Employee_Id"]))
                                    {
                                        e.Employeename = Convert.ToString(dr["Employee_Name"]);
                                        e.Employedate = Convert.ToString(dr["Employee_Dateofjoining"]);
                                        e.EmpDesignation.EmpDes = Convert.ToString(dr["Employee_Designation"]);
                                        e.EmpSal.B_sal = Convert.ToInt32(dr["Employee_Salary"]);


                                        Console.WriteLine("Employee Name: " + e.Employeename + "  " + "Employee Date of Joining: " + e.Employedate + " " + "Employee Designation:  " + e.EmpDesignation.EmpDes + " " + "Employee Salary:  " + e.EmpSal.B_sal);
                                        //Console.Write(e.Employedate + "  ");
                                        //Console.Write(e.EmpDesignation.EmpDes + "  ");
                                        //Console.WriteLine(e.EmpSal.B_sal + "  ");


                                        // Show for all the details

                                    }
                                }
                            }
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Press 1 : To show all Salary_Id ");
                            Console.WriteLine("Press 2 : To show the specific Salary_ID");
                            int choice_inner = Convert.ToInt32(Console.ReadLine());

                            if (choice_inner == 1)
                            {
                                Console.WriteLine("Displying all the Salary Table : ");
                                cmd = new SqlCommand(query2, con);
                                con.Open();
                                dr = cmd.ExecuteReader();
                                while (dr.Read())
                                {
                                    Console.WriteLine($"Employee Id  : {dr["Employee_Id"]}  Salary Id  : {dr["Salary_Id"]}  Basic_Salary : {dr["Basic_Salary"]}  CTC : {dr["CTC"]}");
                                }

                            }
                            else if (choice_inner == 2)
                            {
                                Console.WriteLine("Displying one Salary_Id : ");


                                Console.WriteLine("Enter Employee Id");
                                int temp_emp_id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Salary_Id");
                                int temp_salary_id = Convert.ToInt32(Console.ReadLine());


                                //Console.WriteLine("Works");
                                cmd = new SqlCommand(query2, con);
                                con.Open();

                                //Console.WriteLine("Works");

                                dr = cmd.ExecuteReader();

                                while (dr.Read())
                                {
                                    //Console.WriteLine("Works");
                                    if (temp_emp_id == Convert.ToInt32(dr["Employee_Id"]) && temp_salary_id == Convert.ToInt32(dr["Salary_Id"]))
                                    {
                                        //Console.WriteLine("Works");

                                        e.EmpSal.B_sal = Convert.ToInt32(dr["Basic_Salary"]);
                                        e.EmpSal.Ctc = Convert.ToInt32(dr["CTC"]);
                                        Console.WriteLine("Employee Base Salary :  " + e.EmpSal.B_sal + "  " + "CTC:  " + e.EmpSal.Ctc);
                                        // Console.WriteLine("CTC:  " + e.EmpSal.Ctc);
                                    }
                                }
                            }
                        }
                        else if (choice == 3)
                        {


                            Console.WriteLine("Press 1 :To show all Allowances  ");
                            Console.WriteLine("Press 2 : To show the specific Allowance_Id");
                            int choice_inner = Convert.ToInt32(Console.ReadLine());
                            SqlDataReader dr3 = null;
                            if (choice_inner == 1)
                            {
                                Console.WriteLine("Displying all the Allowances Table : ");
                                cmd = new SqlCommand(query3, con);
                                con.Open();
                                dr3 = cmd.ExecuteReader();
                                while (dr3.Read())
                                {
                                    Console.WriteLine("Allowance Id :   " + dr3["Allowance_Id"] + " " + "House Allowancces" + dr3["Houseallowances"]);
                                    //Console.WriteLine("House Allowancces" + dr3["Houseallowances"]);
                                }

                            }
                            else if (choice_inner == 2)
                            {
                                Console.WriteLine("Displying one Allowance id : ");


                                Console.WriteLine("Enter Employee Id");
                                int temp_emp_id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Allowance id");
                                int temp_allowance_id_id = Convert.ToInt32(Console.ReadLine());
                                cmd = new SqlCommand(query3, con);
                                con.Open();
                                dr3 = cmd.ExecuteReader();

                                while (dr3.Read())
                                {
                                    if (temp_emp_id == Convert.ToInt32(dr3["Employee_Id"]) && temp_allowance_id_id == Convert.ToInt32(dr3["Allowance_Id"]))
                                    {
                                        e.employeeid = Convert.ToInt32(dr3["Employee_Id"]);
                                        e.EmpAllw.Houseallowances = Convert.ToInt32(dr3["Houseallowances"]);
                                        e.EmpAllw.Carloanallowance = Convert.ToInt32(dr3["Carloanallowance"]);
                                        Console.WriteLine("Employee Id: " + e.employeeid + " " + " House Allowance: " + e.EmpAllw.Houseallowances + " " + " House Allowance: " + e.EmpAllw.Carloanallowance);
                                        //Console.WriteLine(e.EmpAllw.Houseallowances);
                                        //Console.WriteLine(e.EmpAllw.Carloanallowance);
                                        break;
                                    }
                                }
                            }
                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("Press 1 : To show all Attendances ");
                            Console.WriteLine("Press 2 : To show the specific Attendance_Id");
                            int choice_inner = Convert.ToInt32(Console.ReadLine());
                            SqlDataReader dr2 = null;

                            if (choice_inner == 1)
                            {
                                Console.WriteLine("Displying all the Attendances Table : ");
                                cmd = new SqlCommand(query4, con);
                                con.Open();
                                dr2 = cmd.ExecuteReader();
                                while (dr2.Read())
                                {
                                    Console.WriteLine($"Attendance id : {dr2["Attendance_Id"]}   Employee id : {dr2["Employee_Id"]}  No_of_PaidLeaves : {dr2["No_of_PaidLeaves"]}   No_of_ExtraLeaves : {dr2["No_of_ExtraLeaves"]}  Total_Salary_Deduction : {dr2["Total_Salary_Deduction"]}  One_DaySalary : {dr2["One_DaySalary"]}  Salary_AfterDeduction : {dr2["Salary_AfterDeduction"]} ");
                                }

                            }
                            else if (choice_inner == 2)
                            {
                                Console.WriteLine("Displying one Attendances id : ");


                                Console.WriteLine("Enter Employee Id");
                                int temp_emp_id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Attendances id");
                                int temp_attendance_id = Convert.ToInt32(Console.ReadLine());
                                cmd = new SqlCommand(query4, con);
                                con.Open();
                                dr2 = cmd.ExecuteReader();

                                while (dr2.Read())
                                {
                                    if (temp_emp_id == Convert.ToInt32(dr2["Employee_Id"]) && temp_attendance_id == Convert.ToInt32(dr2["Attendance_Id"]))
                                    {
                                        e.employeeid = Convert.ToInt32(dr2["Employee_Id"]);
                                        e.EmpAttendance.NumberOfPaidLeaves = Convert.ToInt32(dr2["No_of_PaidLeaves"]);
                                        e.EmpAttendance.NumberOfExtraLeaves = Convert.ToInt32(dr2["No_of_ExtraLeaves"]);
                                        e.EmpAttendance.TotalSalaryDeducted = Convert.ToInt32(dr2["Total_Salary_Deduction"]);
                                        e.EmpAttendance.OneDaySalary = Convert.ToInt32(dr2["One_DaySalary"]);
                                        e.EmpAttendance.SalaryAfterDeduction = Convert.ToInt32(dr2["Salary_AfterDeduction"]);

                                        Console.WriteLine("Employee Id: " + e.employeeid + "  " + "No of paid Leaves: " + e.EmpAttendance.NumberOfPaidLeaves + "  " + "No of extraLeaves: "
                                            + e.EmpAttendance.NumberOfExtraLeaves + " " + "Total Salary Deducted: " + e.EmpAttendance.TotalSalaryDeducted + " " + "One Day Salary: " + e.EmpAttendance.OneDaySalary + " " + "Salary After Deduction: " + e.EmpAttendance.SalaryAfterDeduction);
                                        //Console.WriteLine(e.EmpAttendance.NumberOfPaidLeaves);
                                        //Console.WriteLine(e.EmpAttendance.NumberOfExtraLeaves);
                                        //Console.WriteLine(e.EmpAttendance.TotalSalaryDeducted);
                                        //Console.WriteLine(e.EmpAttendance.OneDaySalary);
                                        //Console.WriteLine(e.EmpAttendance.SalaryAfterDeduction);

                                        break;
                                    }
                                }
                            }
                        }

                        else if (choice == 5)
                        {
                            Console.WriteLine("Press 1 : To show all Designations ID ");
                            Console.WriteLine("Press 2 : To show the specific Designation");
                            int choice_inner = Convert.ToInt32(Console.ReadLine());
                            SqlDataReader dr1 = null;
                            if (choice_inner == 1)
                            {
                                Console.WriteLine("Displying all the Designation Table : ");
                                cmd = new SqlCommand(query5, con);
                                con.Open();
                                dr1 = cmd.ExecuteReader();
                                while (dr1.Read())
                                {
                                    Console.WriteLine($"Designation id : {dr1["Designation_Id"]}   Employee id : {dr1["Employee_Id"]}  Employee_Designation : {dr1["Employee_Designation"]}   Employee_Level : {dr1["Employee_Level"]} ");
                                }

                            }
                            else if (choice_inner == 2)
                            {
                                Console.WriteLine("Displying one Attendances id : ");


                                Console.WriteLine("Enter Employee Id");
                                int temp_emp_id = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Enter Designation id");
                                int temp_desigantion_id = Convert.ToInt32(Console.ReadLine());
                                cmd = new SqlCommand(query5, con);
                                con.Open();
                                dr1 = cmd.ExecuteReader();

                                while (dr1.Read())
                                {
                                    if (temp_emp_id == Convert.ToInt32(dr1["Employee_Id"]) && temp_desigantion_id == Convert.ToInt32(dr1["Designation_Id"]))
                                    {
                                        e.employeeid = Convert.ToInt32(dr1["Employee_Id"]);
                                        e.EmpDesignation.EmpDes = Convert.ToString(dr1["Employee_Designation"]);
                                        e.EmpDesignation.Level = Convert.ToInt32(dr1["Employee_Level"]);

                                        Console.WriteLine("Employee Id: " + e.employeeid + " " + "Employee Designation : " + e.EmpDesignation.EmpDes + " " + "Employee Level : " + e.EmpDesignation.Level);
                                        //Console.WriteLine("Employee Designation : " + e.EmpDesignation.EmpDes);
                                        //Console.WriteLine("Employee Level : " + e.EmpDesignation.Level);

                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                catch (SqlException s)
                {
                    Console.WriteLine(s.Message);
                }
            }*/


        }
        public class Program
        {
            public static void Main()
            {

            ////  DYNAMIC INPUT TAKING FROM USER
            Line_m1:
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Available Options");
                    Console.WriteLine("1.Payslip Generation with data insertion in database");
                    Console.WriteLine("2.Operations on database");
                    //Console.WriteLine("3.Exit");
                    int option = int.Parse(Console.ReadLine());

                    if (option == 1)
                    {
                    Line_m2:
                        try
                        {
                            Console.WriteLine("Enter Employee ID");
                            int emp_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the Employee Name");
                            string emp_name = Console.ReadLine();
                            Console.WriteLine("Enter date of Joining of employee");
                            string emp_date = Console.ReadLine();
                            Console.WriteLine("Enter the level of designation");
                            int level = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the no of paid leaves taken");
                            int emp_paid_leaves = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the no of extra leaves taken");
                            int emp_extra_leaves = Convert.ToInt32(Console.ReadLine());

                            Attendance atn = new Attendance(emp_paid_leaves, emp_extra_leaves);
                            Designation ds = new Designation(level);
                            salary s = new salary();
                            Allowances al = new Allowances();
                            employee e = new employee(emp_id, emp_name, emp_date, s, al, ds, atn);
                            e.Designation_Set_By_Lvl(e);
                            e.SetSalaryByLevel(e);
                            e.AllowanceSetByLevel(e);
                            e.ExecuteDeduction(e);


                            //e.Handle_Insertion(e);
                            e.DisplayPaySlip(e);
                            goto Line_m1;
                        }
                        catch (Exception e2)
                        {
                            Console.WriteLine(e2.Message);
                            goto Line_m2;
                        }
                    }
                    if (option == 2)
                    {

                        Console.WriteLine("Avaialable Options");
                        Console.WriteLine("1.Selection");
                        Console.WriteLine("2.Delete");
                        Console.WriteLine("3.Updation");

                        Console.WriteLine("Enter your choice");
                        int option1 = int.Parse(Console.ReadLine());
                        employee e = new employee();
                        //if (option == 1) { e.Handle_Insertion(e); }
                        /*if (option1 == 1) { e.Select_From_Tables(e); }
                        if (option1 == 2) { e.DELETE_RECORD(); }
                        if (option1 == 3) { e.Handle_Updation(e); }*/

                        goto Line_m1;

                    }
                    //if(option == 3)
                    //{

                    // System.Environment.Exit(0);

                    //}

                    //e.DisplayPaySlip(e);
                    ////e.TakeInput(e);
                    // employee e = new employee();
                    //
                    //
                    //

                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("PLEASSE CHECK THE INPUTS YOU HAVE GIVEN");
                    goto Line_m1;
                }
            }
        }

    }
}
