using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public abstract class DriverFactory
    {
        abstract public IPrintDriver CreatePrinterDriver();

        abstract public IDisplayDriver CreateDisplayDriver();
    }
}