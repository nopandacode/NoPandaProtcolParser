using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoPandaProtcolParser
{
    public class ProtocolInfo
    {
        public ProtocolInfo(string protocolName, string[] protocolArgs)
        {
            ProtocolName = protocolName;
            ProtocolArgs = protocolArgs;
        }

        // myapp://connect/8bkxa221a
        public string ProtocolName { get; set; }
        public string[] ProtocolArgs { get; set; }

        /// <summary>
        /// Parse a protocol call to a protocol info
        /// </summary>
        /// <param name="n">The protocol call</param>
        /// <returns></returns>
        public static ProtocolInfo Parse(string n)
        {
            string name = n.Split(":")[0];
            string rawArgs = n.Substring(name.Length + 3);
            string[] args = rawArgs.Split("/");
            return new ProtocolInfo(name, args);
        }
    }
}
