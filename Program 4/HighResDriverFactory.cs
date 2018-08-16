using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class HighResDriverFactory : DriverFactory
    {
        public override IDisplayDriver CreateDisplayDriver()
        {
            return HighResDisplayDriver.Instance;
        }

        public override IPrintDriver CreatePrinterDriver()
        {
            return HighResPrintDriver.Instance;
        }
    }
}