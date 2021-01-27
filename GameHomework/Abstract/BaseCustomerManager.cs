using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted :" + customer.FirstName);
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved :" + customer.FirstName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Updated :" + customer.FirstName);
        }
    }
}
