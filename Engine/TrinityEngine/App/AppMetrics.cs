using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.App
{
    /// <summary>
    /// AppMetrics provide the desired 'Metrics' for a given app.
    /// Such things as width/height and fullscreen or not.
    /// </summary>
    public class AppMetrics
    {
        /// <summary>
        /// The width of the application's visual output.
        /// </summary>
        public int Width;
        /// <summary>
        /// The height of the appliction's visual output.
        /// </summary>
        public int Height;

        /// <summary>
        /// Weather the app should be run Fullscreen or not.
        /// </summary>
        public bool Fullscreen;

        /// <summary>
        /// The name/title of the application.
        /// </summary>
        public string Title;

        /// <summary>
        /// The requested level of debugging information.
        /// </summary>
        public DebugLevel Debug;
    }
}
