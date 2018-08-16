using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class HighResDisplayDriver : IDisplayDriver
    {
        private static readonly Lazy<HighResDisplayDriver> instance = new Lazy<HighResDisplayDriver>(() => new HighResDisplayDriver());
        public static HighResDisplayDriver Instance
        {
            get => instance.Value;
        }
        private HighResDisplayDriver()
        {

        }
        public void Display()
        {
            Console.WriteLine("with a High Resolution Display Driver.");
        }
    }
}