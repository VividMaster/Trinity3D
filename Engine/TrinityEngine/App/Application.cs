using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.Windows;
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
        /// The internal SharpDX - RenderForm class.
        /// </summary>
        protected RenderForm RenForm = null;

        /// <summary>
        /// The intenral SharpDX - RenderLoop class.
        /// </summary>
        protected RenderLoop RenLoop = null;
         
        public Application(int width,int height,string title,bool fullscreen)
        {

        }


    }
}
