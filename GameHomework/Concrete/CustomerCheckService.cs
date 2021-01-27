using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    class CustomerCheckService : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            return true;
        }
    }
}
