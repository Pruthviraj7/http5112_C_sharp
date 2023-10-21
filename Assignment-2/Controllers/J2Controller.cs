using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    /// <summary>
    /// 2011 J2 Question: Who Has Seen The Wind
    /// </summary>
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Calculate the time at which a balloon touches the ground given the height 'h' and maximum time 'M'.
        /// </summary>
        /// <param name="h">The initial height of the balloon (in meters).</param>
        /// <param name="M">The maximum time (in hours) to calculate.</param>
        /// <returns>
        /// A string indicating when the balloon touches the ground or if it doesn't touch the ground within the given time.
        /// </returns>
        /// <example>
        /// Example: Making a GET request to 'api/J2/CalculateBalloonLandingTime/100/10' will return
        /// "The balloon first touches ground at hour: 6" because the calculation shows that the
        /// balloon touches the ground after 6 hours when the initial height is 100 meters.
        /// 
        /// Example: Making a GET request to 'api/J2/CalculateBalloonLandingTime/50/5' will return
        /// "The balloon does not touch ground in the given time" because the balloon does not touch
        /// the ground within 5 hours when the initial height is 50 meters.
        /// </example>
        [HttpGet]
        [Route("api/J2/CalculateBalloonLandingTime/{h}/{M}")]
        public string CalculateBalloonLandingTime(int h, int M)
        {
            for (int t = 1; t <= M; t++)
            {
                double A = -6 * Math.Pow(t, 4) + h * Math.Pow(t, 3) + 2 * Math.Pow(t, 2) + t;

                if (A <= 0)
                {
                    return $"The balloon first touches ground at hour: {t}";
                }
            }

            return "The balloon does not touch ground in the given time.";
        }
    }
}
