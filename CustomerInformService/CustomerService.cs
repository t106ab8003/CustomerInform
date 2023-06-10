using CustomerInformRepository;
using CustomerInformRepository.Models;
using CustomerInformService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _CustomerRepository = customerRepository;
        }

        public bool AddCustomer(CustomerModel model)
        {
            var customerData = new CustomerData
            {
                custid = model.custid,
                contactnum = model.contactnum,
                custnm = model.custnm,
                perosnalid = model.perosnalid
            };
            return _CustomerRepository.Insert(customerData);
        }

        public List<CustomerModel> GetAll()
        {
            var model = _CustomerRepository.GetAll().Select(x =>
            new CustomerModel
            {
                custid = x.custid,
                custnm = x.custnm,
                contactnum = x.contactnum,
                perosnalid = x.perosnalid
            }).ToList();
            return model; 
        }
    }
}
