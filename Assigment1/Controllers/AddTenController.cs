using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Assigment1.Controllers
{
    public class AddTenController : ApiController
    {
        public int Get(int id) 
        {
            int add = id + 10;
            return add;

            /// <summary>
            /// Receives an input number and returns that number plus 10.
            /// </summary>
            /// <param name="id">The input number</param>
            /// <returns>
            /// The number plus 10.
            /// </returns>
            /// <examples>
            /// GET : localhost:xx/api/AddTen/28 => 38
            /// GET : localhost:xx/api/AddTen/-14 => -4
            /// GET : localhost:xx/api/AddTen/95 => 105
            /// </examples>
        }
    }
}
