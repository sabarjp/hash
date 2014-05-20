using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hash
{
    class Program
    {
        static void Main(string[] args)
        {
            /* find compute platforms */
            var platforms = Cloo.ComputePlatform.Platforms;

            if(platforms.Count == 0){
                Console.WriteLine("Error: No valid compute platforms on system.");
                return;
            }

            foreach (var p in platforms)
            {
                Console.WriteLine("{0} - {1}", p.Name, p.Vendor);
            }

            /* find devices for the first platform */
            var devices = platforms.First().Devices;

            if (devices.Count == 0) {
                Console.WriteLine("Error: No compute devices found.");
                return;
            }

            foreach (var d in devices)
            {
                Console.WriteLine("{0} ({1}) - v{2}", d.Name, d.Type, d.Version);
            }

            /* create compute context */

            return;
        }
    }
}
