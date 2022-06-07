using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Laserjet display dimension : 12*12");
        }
        public override void Printing()
        {
            Console.WriteLine("Laserjet printer printing....");
        }
    }
}
