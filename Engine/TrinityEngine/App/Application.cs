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
        /// The internal SharpDX - RenderLoop class.
        /// </summary>
        protected RenderLoop RenLoop = null;


        /// <summary>
        /// Initializes a new instance of the <see cref="Application"/> class.
        /// The application class should be referenced(Via base(...)) when constructing
        /// your upper level class that inherits the <see cref="Application"/> class.
        /// </summary>
        /// <param name="metrics">The desired application <see cref="AppMetrics"/> metrics.</param>
        public Application(AppMetrics metrics)
        {
            Globals.Metrics = metrics;
            RenForm = new RenderForm(metrics.Title);

        }


    }
}
