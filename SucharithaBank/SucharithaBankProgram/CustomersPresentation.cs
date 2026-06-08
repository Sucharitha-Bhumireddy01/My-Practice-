using System;
using System.Collections.Generic;
using SucharithaBank.Exceptions;
using SucharithaBank.Entities;
using SucharithaBank.BusinessLogicLayer;
using SucharithaBank.BusinessLogicLayer.BALContracts;

namespace SucharitBank.Presentation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                //create an object of custome
                Customer customer = new Customer();

                //read all details from the user
                Console.WriteLine("\n**********ADD CUSTOMER**********");
                Console.Write("Customer Name: ");
                customer.CustomerName = Console.ReadLine();
                Console.Write("Address: ");
                customer.Address = Console.ReadLine();
                Console.Write("Landmark: ");
                customer.Landmark = Console.ReadLine();
                Console.Write("City: ");
                customer.City = Console.ReadLine();
                Console.Write("Country: ");
                customer.Country = Console.ReadLine();
                Console.Write("Mobile: ");
                customer.Mobile = Console.ReadLine();

                //Create BL object
                ICustomersBusinessLogicLayer customerBusinessLogicLayer = new CustomersBusinessLogicLayer();
                Guid newGuid = customerBusinessLogicLayer.AddCustomer(customer);


                List<Customer>matchingCustomers=customerBusinessLogicLayer.GetCustomersByCondition(item => item.CustomerID == newGuid);
                if(matchingCustomers.Count>=1)
                {
                    Console.WriteLine("New Customer Code: " + matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Customer Added.\n");
                }
                else
                {
                    Console.WriteLine("Customer Not Added");
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
            
        }

        internal static void ViewCustomers()
        {
            try
            {
                //Create BL object
                ICustomersBusinessLogicLayer customersBusinessLogicLayer = new CustomersBusinessLogicLayer();

                List<Customer> allCustomers = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n**********ALL CUSTOMERS**********");
                //read all customers
                foreach(var item in allCustomers)
                {
                    Console.WriteLine("Customer Code:"+item.CustomerCode);
                    Console.WriteLine("Customer Name:"+item.CustomerName);
                    Console.WriteLine("Address:"+item.Address);
                    Console.WriteLine("Landmark:"+item.Landmark);
                    Console.WriteLine("City:"+item.City);
                    Console.WriteLine("Country:"+item.Country);
                    Console.WriteLine("Mobile:"+item.Mobile);
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
