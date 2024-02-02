using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment1.Controllers
{
    public class HostingCostController : ApiController
    {
        public string[] Get(int id)
        {
            double fortnightFee = 5.50; // CAD
            int fortnightOne = (id / 14) + 1; // days
            double hstFee = 0.13;
            double subtotal = fortnightOne * fortnightFee;
            double hst = subtotal * hstFee;
            double total = subtotal + hst;

            string messageOne = $"{fortnightOne} fortnights at $" + fortnightFee + "F/N = $" + subtotal + "CAD";
            string messageTwo = "HST 13% = $" + hst + "CAD";
            string messageThree = "Total = $" + total + "CAD";

            return new string[] {messageOne,messageTwo,messageThree};

            /// <summary>
            /// Receives an input number and returns the fee for each fortnight, the hst and the total price.
            /// </summary>
            /// <param name="id">The input number</param>
            /// <returns>
            /// The input number multiplied per each fortnight withing the string message in the first line.
            /// The second and third line are the result of the operations.
            /// </returns>
        }
    }
}
