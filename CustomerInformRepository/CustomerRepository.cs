using CustomerInformRepository.EFDbContext;
using CustomerInformRepository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerInfoContext _CustomerInfoContext;
        public CustomerRepository(CustomerInfoContext customerInfoContext)
        {
            _CustomerInfoContext = customerInfoContext;
        }

        public List<CustomerData> GetAll()
        {
            var model = _CustomerInfoContext.Customers.Select(x =>
            new CustomerData
            {
                custid = x.custid,
                custnm = x.custnm,
                contactnum = x.contactnum,
                perosnalid = x.perosnalid
            }).ToList();
            return model;
        }

        public bool Insert(CustomerData data) //>0代表異動的筆數
        {
            var model = new Customers
            {
                custid = data.custid,
                custnm = data.custnm,
                contactnum = data.contactnum,
                perosnalid = data.perosnalid
            };
            _CustomerInfoContext.Customers.Add(model);
            var numOfInsert = _CustomerInfoContext.SaveChanges();
            return numOfInsert > 0;
        }

    }
}
