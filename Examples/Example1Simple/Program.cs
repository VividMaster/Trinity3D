using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityEngine;
using TrinityHAL;
using HALDirectX12;
using TrinityEngine.App;
namespace Example1Simple
{
    class Program
    {
        static void Main(string[] args)
        {


            AppMetrics metrics = new AppMetrics();
            metrics.Width = 640;
            metrics.Height = 480;
            metrics.Fullscreen = false;
            metrics.Title = "Trinity3D - Example 1 Simple";

            HALDX12 hal = new HALDX12();


            Application myApp = new Application(metrics, hal);

            myApp.Run();

        }
    }
}
