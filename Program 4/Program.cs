using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4
{
    /// <summary>
    /// Main Driver of the program.
    /// </summary>
    static class Program
    {
        private const string LOW_RES_DUM_VAL = "L";
        private const string HIGH_RES_DUM_VAL = "H";
        private static Widget TestWidget = new Widget();
        private static Document TestDocument = new Document();
        private static DriverFactory Factory;

        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                try
                {
                    ReadConfigFile(args[0]);
                    Test();
                }
                catch(Exception ex)
                {
                    Console.WriteLine("This would actually be used if I were doing an actual config file processing.");
                }
            }
            bool quit = false;
            do
            {
                Console.WriteLine("Leave the input blank if you wish to quit.");
                Console.WriteLine("Please enter a value that you'd like our fake drivers to be:");
                Console.WriteLine($"{LOW_RES_DUM_VAL} for a Low Res Driver\nOr {HIGH_RES_DUM_VAL} for a High Res Driver.");
                string result = Console.ReadLine();
                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        ReadConfigFile(result.ToUpper()[0].ToString());
                        Test();
                        Console.WriteLine("\n");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    quit = true;
                }
            } while (!quit);
        }

        /// <summary>
        /// If I were actually going to read from a file, I would put that logic here, but the program prompt doesn't say that we have to actually do that,
        /// so I'm going to be lazy and just pass in a dummy value that will determine which version of the "drivers" is given to the Test Widget and Document.
        /// </summary>
        /// <param name="dummyVal">"L" for lowRes and "H" for highRes</param>
        public static void ReadConfigFile(string dummyVal)
        {
            if(dummyVal == LOW_RES_DUM_VAL)
            {
                Factory = new LowResDriverFactory();
            }
            else if(dummyVal == HIGH_RES_DUM_VAL)
            {
                Factory = new HighResDriverFactory();
            }
            //This shouldn't happen.
            else
            {
                throw new ArgumentException("Value was not appropriate.");
            }
        }

        public static void Test()
        {
            if(Factory != null)
            {
                TestWidget.Driver = Factory.CreateDisplayDriver();
                TestDocument.Driver = Factory.CreatePrinterDriver();
                TestWidget.Draw();
                TestDocument.Print();
            }
        }
    }
}
