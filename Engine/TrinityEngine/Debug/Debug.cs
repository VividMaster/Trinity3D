using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinityEngine.Debug
{
    /// <summary>
    /// The debug class can created and then used, to log both pyhsical output and more 
    /// traditional text(log) based output.
    /// it features both the ability to generate debug errors, or just plain useful information
    /// to both console and file.
    /// </summary>
    public class DebugLog
    {
        /// <summary>
        /// Gets or sets the logs list, which contains an active list
        /// of the messages generated, for later viewing or outputting to file.
        /// </summary>
        /// <value>
        /// The log collection.
        /// </value>
        public List<DebugMessage> Logs
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or sets a value indicating whether any messages
        /// should immediately be sent to the console display.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [to console]; otherwise, <c>false</c>.
        /// </value>
        public bool ToConsole
        {
            get;
            set;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Debug"/> class.
        /// No parameters are required, simply create the class
        /// and then begin to use it when and how needed.
        /// </summary>
        public DebugLog()
        {
            Logs = new List<DebugMessage>();
            ToConsole = true;
            OutputPath = "genericlogs.dump";

        }

        /// <summary>
        /// Gets or sets the output path(Filename) if used.
        /// </summary>
        /// <value>
        /// The output path(Filename)
        /// </value>
        public string OutputPath
        {
            get;
            set;
        }

        /// <summary>
        /// Logs the MSG to screen and or disk.
        /// </summary>
        /// <param name="type">The type of message.</param>
        /// <param name="msg">The actual full message.</param>
        /// <param name="ext">Any extra information.</param>
        public void LogMsg(string type, string msg, string ext = "")
        {
            DebugMessage m = new DebugMessage()
            {
                Type = type,
                Msg = msg,
                Extra = ext,
                Time = DateTime.Now
            };
            Logs.Add(m);
            if (ToConsole) SendToConsole(m);
        }
        /// <summary>
        /// Sends to console the content of a debug message.
        /// </summary>
        /// <param name="msg">The MSG.</param>
        public void SendToConsole(DebugMessage msg)
        {

            Console.WriteLine("DebugMessage@" + msg.Time.ToLocalTime());
            Console.WriteLine("Type:" + msg.Type + " Msg:" + msg.Msg);
            Console.WriteLine("Extra:" + msg.Extra);
            
        }
    }

}