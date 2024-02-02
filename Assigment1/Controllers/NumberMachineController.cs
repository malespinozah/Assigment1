using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public int Get(int id) 
        {
            int matematics = ((id + 4) * (10 / 2)) - 80;
            return matematics;

            /// <summary>
            /// Receives an input number and returns that number plus 4, the result is multiplied by the result of the division, and finally, substracted by 80.
            /// </summary>
            /// <param name="id">The input number</param>
            /// <returns>
            /// The result of 4 mathematic operations.
            /// </returns>
            /// <examples>
            /// GET : localhost:xx/api/NumberMachine/-5 => -85
            /// GET : localhost:xx/api/NumberMachine/53 => 205
            /// GET : localhost:xx/api/NumberMachine/16 => 20
            /// </examples>
        }
    }
}
