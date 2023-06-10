using CustomerInformRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformRepository
{
    public interface ICustomerRepository
    {
        List<CustomerData> GetAll();
        bool Insert(CustomerData data);
    }
}
