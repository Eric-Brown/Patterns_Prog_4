using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program_4
{
    public class Widget
    {
        private IDisplayDriver driver;
        public IDisplayDriver Driver
        {
            get=>driver;
            set
            {
                driver = value;
            }
        }

        public void Draw()
        {
            System.Console.Write($"{this.GetType().Name} is being drawn...");
            Driver.Display();
        }
    }
}