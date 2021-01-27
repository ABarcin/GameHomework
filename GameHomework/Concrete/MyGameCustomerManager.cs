using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Concrete
{
    public class MyGameCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public MyGameCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealCustomer(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a Valid Person");
            }
        }

    }
}
