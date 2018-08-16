using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class LowResDriverFactory : DriverFactory
    {
        public override IDisplayDriver CreateDisplayDriver()
        {
            return LowResDisplayDriver.Instance;
        }

        public override IPrintDriver CreatePrinterDriver()
        {
            return LowResPrintDriver.Instance;
        }
    }
}