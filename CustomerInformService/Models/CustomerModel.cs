﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformService.Models
{
    public class CustomerModel
    {
        public Guid custid { get; set; }
        public string custnm { get; set; }
        public string contactnum { get; set; }
        public string perosnalid { get; set; }
    }
}
