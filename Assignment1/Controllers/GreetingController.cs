using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class GreetingController : ApiController
    {
        //POST 
        //OUTPUT: "Hello World"
        public string POST()
        {
            return "Hello World";
        }

        //GET appi/Greeting/{id}
        //OUTPUT: "Greetings to {id} people"
        public string Get(int id)
        {
            string message = "Greetings to " + id.ToString() + " people";
            return message;
        }
    }
}
