using CustomerInformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformService
{
    public interface ICustomerService
    {
        List<CustomerModel> GetAll();
        bool AddCustomer(CustomerModel model);


    }
}
