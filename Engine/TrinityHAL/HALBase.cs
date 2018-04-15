using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityHAL
{

    /// <summary>
    /// The base HAL(Hardware Abstraction Layer)
    /// Any given inherited version of this class
    /// allows Trinity3D to interface with any given number of
    /// GPU/platforms. 
    /// </summary>
    public class HALBase
    {
        public HALBase()
        {

        }
        /// <summary>
        /// When overridden,this method should create the graphical output 
        /// of the HAL - be it a window, or full-screen display.
        /// Provided to it are the required parameters.
        /// </summary>
        /// <param name="width">The width of the output.</param>
        /// <param name="height">The height of the output.</param>
        /// <param name="fullscreen">if set to <c>true</c> [full-screen].</param>
        /// <returns></returns>
        public virtual HALResult CreateOutput(int width,int height,bool fullscreen)
        {
            return null;
        }
    }
}
