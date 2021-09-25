using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class HostingCostController : ApiController
    {
        //In order to answer this question I would first create some varables to calculate the amount owed.
        //Then I would use those variables to create the appropriate messages for each line.
        //Finally I would return the messages so the page brings up the correct pieces of information
        public string Get(int id)
        {
            double fortnightamount = id * (1 / 14);
            double subtotal = fortnightamount * 5.50;
            double taxamount = subtotal * 0.13;
            double total = subtotal + taxamount;


            string messageone= fortnightamount.ToString() + " fortnights at $5.50/FN = $" + subtotal.ToString() + " CAD";
            string messagetwo = "HST at 13% = $" + taxamount.ToString();
            string messagethree = "Total = $" + total.ToString() + " CAD";

            return messageone;
            return messagetwo;
            return messagethree;

        }
    }
}
