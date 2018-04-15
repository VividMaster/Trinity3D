#using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityHAL
{

    /// <summary>
    /// The HALWindow class creates and maintains 
    /// the graphical out-put of the application, even if Full-screen.
    /// </summary>
    public class HALWindow
    {
        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="HALWindow"/> is full-screen.
        /// </summary>
        /// <value>
        ///   <c>true</c> if full-screen; otherwise, <c>false</c>.
        /// </value>
        public bool Fullscreen
        {
            get;
            set;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="HALWindow"/> class.
        /// This is the graphical entry point.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fullscreen">if set to <c>true</c> [fullscreen].</param>
        public HALWindow(int width,int height,bool fullscreen)
        {
            Width = width;
            Height = height;
            Fullscreen = Fullscreen;
        }
    }
}
