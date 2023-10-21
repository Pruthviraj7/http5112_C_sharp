using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    /// <summary>
    /// 2011 J3 Question:Sumac Sequence
    /// </summary>
    public class J3Controller : ApiController
    {
        /// <summary>
        /// Calculate the length of a Sumac sequence, given the first two terms 't1' and 't2'.
        /// </summary>
        /// <param name="t1">The first term in the sequence.</param>
        /// <param name="t2">The second term in the sequence.</param>
        /// <returns>
        /// An integer representing the length of the Sumac sequence. Returns -1 if invalid input is detected.
        /// </returns>
        /// <example>
        /// Example: Making a GET request to 'api/J3/CalculateSumacSequenceLength/120/71' will return 5
        /// because the Sumac sequence starting with 120 and 71 is: 120, 71, 49, 22, 27, 5.
        /// 
        /// Example: Making a GET request to 'api/J3/CalculateSumacSequenceLength/5/10' will return -1
        /// because the input is invalid; 't2' is greater than or equal to 't1'.
        /// </example>
        [HttpGet]
        [Route("api/J3/CalculateSumacSequenceLength/{t1}/{t2}")]
        public int CalculateSumacSequenceLength(int t1, int t2)
        {
            if (t2 >= t1 || t2 <= 0 || t1 >= 10000)
            {
              
                return -1; // Return -1 to indicate an error.
            }

            int length = 2;  // Starting with 2 terms (t1 and t2) already in the sequence

            while (t2 <= t1)
            {
                int nextTerm = t1 - t2;
                t1 = t2;
                t2 = nextTerm;
                length++;
            }

            return length;
        }
    }
}
