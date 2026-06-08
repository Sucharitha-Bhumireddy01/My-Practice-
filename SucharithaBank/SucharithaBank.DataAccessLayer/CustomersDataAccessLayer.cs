using System;
using System.Collections.Generic;
using SucharithaBank.Entities;
using SucharithaBank.Exceptions;
using SucharithaBank.DataAccessLayer.DALContracts;

namespace SucharithaBank.DataAccessLayer
{
    /// <summary>
    /// Represents DAL for bank customers
    /// </summary>
    public class CustomersDataAccessLayer:ICustomersDataAccessLayer
    {
        #region Fields
        private static List<Customer> _customers;
        #endregion

        #region Constructors
        static CustomersDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Represents source customers collection
        /// </summary>
        private static List<Customer>Customers
        {
            set => _customers = value;
            get => _customers;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns all existing customers
        /// </summary>
        /// <returns>Customer list</returns>
        public List<Customer>GetCustomers()
        {
            try
            {
                //create a new customer list
                List<Customer> customersList = new List<Customer>();

                //copy all customers from the source collection to the new Customer list
                Customers.ForEach(item => customersList.Add(item.Clone() as Customer));
                return customersList;
            }
            catch(CustomerException)
            {
                throw;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        /// <summary>
        /// Returns list of customers that are matching with the specified criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try 
            {
                //create a new customer list
                List<Customer> customersList = new List<Customer>();

                //filter the colection
                List<Customer> filterdCustomers = Customers.FindAll(predicate);

                //copy all customers from the source collection to the new Customer list
                filterdCustomers.ForEach(item => customersList.Add(item.Clone() as Customer));
                return customersList;
            }
            catch(CustomerException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
            
        }

       /// <summary>
       /// Adds a new customer to the existing list
       /// </summary>
       /// <param name="customer">Customer object to add</param>
       /// <returns>Returns Guid of newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //generate new guid
                customer.CustomerID = Guid.NewGuid();

                //add customer
                Customers.Add(customer);

                return customer.CustomerID;
            }
            catch(CustomerException)
            {
                throw;
            }
            catch(Exception)
            {
                throw;
            }
           
        }

        /// <summary>
        /// updates an existing customer's details
        /// </summary>
        /// <param name="customer">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //find existinfg customer by CustomerID
                Customer existingCustomer = Customers.Find(item => item.CustomerID == customer.CustomerID);

                //update all the details of customer
                if (existingCustomer != null)
                {
                    existingCustomer.CustomerCode = customer.CustomerCode;
                    existingCustomer.CustomerName = customer.CustomerName;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.Landmark = customer.Landmark;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.Mobile = customer.Mobile;

                    return true;//indicates the customer is updated
                }
                else
                {
                    return false;//no object is updated
                }
            }
            catch(Exception)
            {
                throw;
            }
            
        }
        
        /// <summary>
        /// Deletes an existing customer based on CustomerID
        /// </summary>
        /// <param name="customeID">CustomerID to delete</param>
        /// <returns>Indicated whether the customer id delted or not</returns>
        public bool DeleteCustomer(Guid customeID)
        {
            try
            {
                //delete customer by CustomerUD
                if (Customers.RemoveAll(item => item.CustomerID == customeID) > 0)
                {
                    return true;//Indicates one or more customers are deleted
                }
                else
                {
                    return false;//Indicates no customers deleted.
                }
            }
            catch(Exception)
            {
                throw;
            }
            

        }
        #endregion
    }
}
