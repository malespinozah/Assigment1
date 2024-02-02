using Antlr.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment1.Controllers
{
    public class GreetingController : ApiController
    {
        public string Post()
        {
            string greetings = "Hello World";
            return greetings;
        }
        /// <summary>
        /// Returns the string not in the api, but in the terminal.
        /// </summary>
        /// <param>There is no parameter in this method</param>
        /// <returns>
        /// The string
        /// </returns>
        /// 
        public string Get(int id)
        {
            string greetingNumber = "Greetings to " + id + " people!";
            return greetingNumber;

            /// <summary>
            /// Returns the string message including the input number.
            /// </summary>
            /// <param name="id">The input number</param>
            /// <returns>
            /// The number from the input.
            /// </returns>
            /// <examples>
            /// GET : localhost:xx/api/Greeting/34 => Greeting to 34 people!
            /// GET : localhost:xx/api/Greeting/1 => Greeting to 1 people!
            /// GET : localhost:xx/api/Greeting/20 => Greeting to 20 people!
            /// </examples>
        }
    }
}
