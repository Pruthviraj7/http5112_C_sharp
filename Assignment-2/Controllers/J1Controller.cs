using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    /// <summary>
    /// 2020 J1 Question: Dog Treats
    /// </summary>
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculate happiness score based on input values and return "Sad" or "Happy."
        /// </summary>
        /// <param name="S">Value for 'S' factor.</param>
        /// <param name="M">Value for 'M' factor.</param>
        /// <param name="L">Value for 'L' factor.</param>
        /// <returns>A string, either "Sad" or "Happy," based on the calculated score. </returns>
        /// <example>
        /// Example: Making a GET request to 'api/J1/3/2/1' will return "Sad" because the
        /// calculated score is (1*3) + (2*2) + (3*1) = 3 + 4 + 3 = 10, which is not less
        /// than 10.
        /// 
        /// Example: Making a GET request to 'api/J1/2/2/2' will return "Happy" because the
        /// calculated score is (1*2) + (2*2) + (3*2) = 2 + 4 + 6 = 12, which is greater than 10.
        /// </example>
        [HttpGet]
        [Route("api/J1/{S}/{M}/{L}")]
        public string Get(int S, int M, int L)
        {
            // Calculating the happiness score based on input factors.
            int score = (1 * S) + (2 * M) + (3 * L);

            if (score < 10)
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
