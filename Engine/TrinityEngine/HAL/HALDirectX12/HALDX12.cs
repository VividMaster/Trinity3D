using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityHAL;
/// <summary>
/// The haldirectx12 name-space contains the dx12 Hal plug-in.
/// </summary>
namespace HALDirectX12
{
    /// <summary>
    /// /This is the DirectX12 HAL main-class.
    /// </summary>
    /// <seealso cref="TrinityHAL.HALBase" />
    public class HALDX12 : HALBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HALDX12"/> class.
        /// </summary>
        public HALDX12()
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
        public override HALResult CreateOutput(int width,int height,bool fullscreen)
        {
            var res = HALResult.Success;


            return res;


        }
    }
}
