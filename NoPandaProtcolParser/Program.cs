using System;

namespace NoPandaProtcolParser
{
    class Program
    {
        static void Main(string[] args)
        {
            ProtocolInfo info = ProtocolInfo.Parse("myapp://connect/1281238");

            Console.WriteLine($"Name: {info.ProtocolName}; Args: {string.Join(" | ", info.ProtocolArgs)}");
            Console.ReadKey();
        }
    }
}
