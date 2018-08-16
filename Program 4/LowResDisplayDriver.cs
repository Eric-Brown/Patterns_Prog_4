using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class LowResDisplayDriver : IDisplayDriver
    {
        private static readonly Lazy<LowResDisplayDriver> instance = new Lazy<LowResDisplayDriver>(() => new LowResDisplayDriver());
        public static LowResDisplayDriver Instance
        {
            get => instance.Value;
        }
        private LowResDisplayDriver()
        {

        }
        public void Display()
        {
            Console.WriteLine("with a Low Resolution Display Driver.");
        }
    }
}