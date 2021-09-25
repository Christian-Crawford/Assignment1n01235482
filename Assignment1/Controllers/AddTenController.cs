using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        //GET api/AddTen/{id}
        //output: {id}+10//
        public int Get(int id)
        {
            return id + 10;
        }
    }
}
