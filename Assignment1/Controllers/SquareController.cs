﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class SquareController : ApiController
    {
        //GET api/Square/{id}
        //OUTPUT: id *id
        public int GET(int id)
        {
            return id * id;

        }

    }
}
