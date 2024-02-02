using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment1.Controllers
{
    public class SquareController : ApiController
    {
        public int Get(int id) 
        {
            int square = id * id;
            return square;

            /// <summary>
            /// Receives an input number and returns that number multiplied by itself.
            /// </summary>
            /// <param name="id">The input number</param>
            /// <returns>
            /// The number multiplied by itself.
            /// </returns>
            /// <examples>
            /// GET : localhost:xx/api/Square/-45 => 2025
            /// GET : localhost:xx/api/Square/12 => 144
            /// GET : localhost:xx/api/Square/30 => 900
            /// </examples>
        }
    }
}
