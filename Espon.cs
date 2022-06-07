using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class Espon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Espon Display dimension : 10*11");
        }
        public override void Printing()
        {
            Console.WriteLine("Espon printer printing....");
        }
    }
}
