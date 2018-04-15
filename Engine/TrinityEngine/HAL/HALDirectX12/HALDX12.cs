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
       
        public HALDX12()
        {

        }

        public HALResult CreateOutput(int width,int height,bool fullscreen)
        {
            var res = HALResult.Success;



        }
    }
}
