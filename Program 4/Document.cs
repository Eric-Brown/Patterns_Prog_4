using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class Document
    {
        public IPrintDriver Driver
        {
            get;set;
        }

        public void Print()
        {
            System.Console.Write($"{this.GetType().Name} is being printed...");
            Driver.Print();
        }
    }
}