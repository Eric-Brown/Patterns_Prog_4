using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class LowResPrintDriver : IPrintDriver
    {
        private static readonly Lazy<LowResPrintDriver> instance = new Lazy<LowResPrintDriver>(() => new LowResPrintDriver());
        public static LowResPrintDriver Instance
        {
            get => instance.Value;
        }
        private LowResPrintDriver()
        { }
        public void Print()
        {
            Console.WriteLine("with a Low Resolution Printer Driver.");
        }
    }
}