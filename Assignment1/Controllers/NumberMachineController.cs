using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        //GET api/NumberMachine/{id}
        //OUTPUT: (id + 10) * 2 + 50 / 2;
        public int Get(int id)
        {
            return (id + 10) * 2 + 50 / 2;
        }
    }
}
