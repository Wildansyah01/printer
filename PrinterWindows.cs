using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class PrinterWindows
    {

        public virtual void Show() 
        {
            Console.WriteLine("printing");
        }
        public virtual void Printing()
        {
            Console.WriteLine("Canon display dimension : 9.5*12");
        }
    }
}
