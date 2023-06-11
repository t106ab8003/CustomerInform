using CustomerInform.Models;
using CustomerInformRepository.EFDbContext;
using CustomerInformService;
using CustomerInformService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerInform.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _CustomerService;
        public CustomerController(ICustomerService customerService)
        {
            _CustomerService = customerService;
        }

        public IActionResult Index()
        {
            var model = _CustomerService.GetAll().Select(x =>
            new CustomerViewModel
            {
                custid = x.custid,
                custnm = x.custnm,
                contactnum = x.contactnum,
                perosnalid = x.perosnalid
            }).ToList();
            return View(model);
        }

        public IActionResult Create(CustomerViewModel customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var model = new CustomerModel
                {
                    custid = Guid.NewGuid(),
                    contactnum = customerViewModel.contactnum,
                    custnm = customerViewModel.custnm,
                    perosnalid = customerViewModel.perosnalid
                };
                _CustomerService.AddCustomer(model);
                ModelState.Clear();
            }
            return View();
        }
    }
}
