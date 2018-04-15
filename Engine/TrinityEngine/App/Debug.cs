using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.App
{
   
    /// <summary>
    /// The enumeration for deciding which level of debug reporting
    /// your application should give.
    /// </summary>
    public enum DebugLevel
    {
        /// <summary>
        /// In release-mode, little to no debug information will be generated.
        /// </summary>
        Release,
        /// <summary>
        /// A general(normal) level debug information will be generated.
        /// </summary>
        Debug,
        /// <summary>
        /// The most intense(Info-heavy) form of debug information will be generated.
        /// </summary>
        DebugVerbose
    }
}
