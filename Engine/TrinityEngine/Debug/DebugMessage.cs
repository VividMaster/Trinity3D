using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Debug
{
    /// <summary>
    /// DebugMessage is a singular debug/info class containing
    /// various metrics of a given message/problem.
    /// </summary>
    public class DebugMessage
    {
        /// <summary>
        /// Gets or sets the type of error/message being generated.
        /// </summary>
        /// <value>
        /// The type of error/message.
        /// </value>
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the actual debug error or message.
        /// </summary>
        /// <value>
        /// The textual message of the debug error or message.
        /// </value>
        public string Msg
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the time at which this debug error or message was generated.
        /// </summary>
        /// <value>
        /// The time of which this debug error or message was generated.
        /// </value>
        public DateTime Time
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the extra information that may or may not exist, 
        /// to do with the debug error or message.
        /// </summary>
        /// <value>
        /// The extra textual information for the debug error or message.
        /// </value>
        public string Extra
        {
            get;
            set;
        }
    }
}
