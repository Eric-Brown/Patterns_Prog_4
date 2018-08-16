using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class HighResPrintDriver : IPrintDriver
    {
        private static readonly Lazy<HighResPrintDriver> instance = new Lazy<HighResPrintDriver>(() => new HighResPrintDriver());
        public static HighResPrintDriver Instance
        {
            get => instance.Value;
        }
        private HighResPrintDriver()
        {
        }

        public void Print()
        {
            Console.WriteLine("with a High Resolution Printer Driver.");
        }
    }
}