using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrinityEngine.Debug;
using TrinityHAL;
namespace TrinityEngine.App
{
    /// <summary>
    /// The central application class you must inherit.
    /// Inheriting this class allows you to create a modern/3D application,
    /// using TrinityEngine to power it's graphical output.
    /// </summary>
    public class Application
    {


        /// <summary>
        /// Gets or sets the Hal used to define this app's
        /// platform support.
        /// </summary>
        /// <value>
        /// The Hal(Hardware-Abstraction-Layer)
        /// </value>
        public HALBase Hal
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the debug output.
        /// </summary>
        /// <value>
        /// The debug output.
        /// </value>
        /// 
        public DebugLog DebugOut
        {
            get;
            set;
        }
     
        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// The Application class is the entry into using Trinity3D to create your application.
        /// The desired Hal should be given, and it can not be the base(HALBase) class
        /// as this provides form, not functionality.
        /// </summary>
        /// <param name="metrics">The metrics.</param>
        /// <param name="hal">The Hal(Hardware-Abstraction-Layer)</param>
        public Application(AppMetrics metrics, HALBase hal)
        {
            Globals.Metrics = metrics;
            Hal = hal;
            DebugOut = new DebugLog();
            DebugOut.OutputPath = metrics.Title + ".AppLog";
            DebugOut.LogMsg("App", "Application created.", "W:" + metrics.Width + " H:" + metrics.Height + " Full:" + metrics.Fullscreen.ToString());
        }

        /// <summary>
        /// Begins 'running' of your application.
        /// The 'application' class will maintain and run your application,
        /// calling logic/render/other method as defined/needed.
        /// </summary>
        public void Run()
        {

            while (true)
            {

            }

        }


    }
}