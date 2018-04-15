using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityHAL
{
    /// <summary>
    /// The HALResult class informs the user/developer if a an attempt
    /// procedure was successful or not.
    /// </summary>
    public class HALResult
    {
        /// <summary>
        /// The outcome of the call/procedure.
        /// </summary>
        public Result Outcome;

        /// <summary>
        /// Gets or sets the information/reason of the result.
        /// </summary>
        /// <value>
        /// The information to rely to the end-user/developer.
        /// </value>
        public string Info
        {
            get;
            set;
        }
        /// <summary>
        /// Returns a generic successful result instance.
        /// </summary>
        /// <value>
        /// A successful result.
        /// </value>
        public static HALResult Success
        {
            get
            {

                HALResult res = new HALResult();
                res.Outcome = Result.Succesfull;
                return res;
            }
        }
        /// <summary>
        /// Returns a generic failed result instance.
        /// </summary>
        /// <value>
        /// A failed result.
        /// </value>
        public static HALResult Fail
        {

            get
            {
                HALResult res = new HALResult();
                res.Outcome = Result.Failed;
                return res;
            }
        }

    }
    /// <summary>
    /// The enumeration that defines in general 
    /// if an attempted procedure was successful
    /// </summary>
    public enum Result
    {
        /// <summary>
        /// The procedure was successful.
        /// </summary>
        Succesfull,
        /// <summary>
        /// The procedure failed.
        /// </summary>
        Failed
    }
}
