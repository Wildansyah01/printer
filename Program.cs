using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrinterWindows printer;

            Console.WriteLine("pilih Printer: ");
            Console.WriteLine("1.Espon");
            Console.WriteLine("2.Canon");
            Console.WriteLine("3.LasetJet");

            Console.WriteLine("Nomor Printer [1..3]: ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Espon();

            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Printing();

            Console.ReadKey();
        }
    }
}
