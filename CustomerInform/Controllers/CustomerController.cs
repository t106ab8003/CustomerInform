using CustomerInform.Models;
using CustomerInformService;
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
    }
}
