using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealCustomer(Customer customer)
        {
            //simulasyon için aşağıdaki kodlar kullanıldı
            if (customer.FirstName == "Ahmet" && customer.LastName == "Barçın" && customer.NationalId == "11111111111" && customer.DateOfBirth.Year == 1990)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
