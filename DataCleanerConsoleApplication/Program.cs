using System;
using log4net;
using log4net.Config;
using JRAMelissaWrapper;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly ILog Logger =
        LogManager.GetLogger(typeof (Program));

        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();

            var i = new InputStreetAddress()
            {
                AddressLine1 = "502 grant ave",
                City = "Willow Grove",
                Country = "USA",
                //PostalCode = "190452",
                FullName = "frank medvedik",
                //State = "PA"
            };

            var w = new DataCleaner();
            w.ActionVerify = true;
            w.ActionCheck = true;

            /* 
             * process one record             
             */
            try
            {
                OutputStreetAddress o;
                var b = w.VerifyAndCleanAddress(i, out o);
                {
                    Logger.Debug("status: " + b);
                    Logger.Debug("Result Codes: " + o.Results.ToString());
                    Logger.Debug("Errors: " + o.Errors.ToString());
                    Logger.Debug("Output Address: " + o.ToString());
                }

                i.PostalCode = "";
                var inArray = new[] { i };

                /* 
                * process arrary of records             
                */

                var outArray = w.VerifyAndCleanAddress(inArray);
                foreach (var r in outArray)
                {
                    Logger.Debug("Result Codes: " + r.Results.ToString());
                    Logger.Debug("Errors: " + r.Errors.ToString());
                    Logger.Debug("Output Address: " + r.ToString());
                }
            }
            catch(Exception e)
            {
                Logger.Error(e.ToString());
            }
        }

        public void PrintAllPossibleErrors()
        {
            /*
             * dictionary utilities 
             */

            var p = new ParseResultDictionary();

            Console.WriteLine(
                "List all parse response fatal errors where the address is not good enough to send mail to");
            foreach (var a in p.GetAllFatalErrors())
                Console.WriteLine(a.ToString());
    
        }
        public void PrintAllMessages()
        {
            var p = new ParseResultDictionary();
            Console.WriteLine("List all parse response messages");
            foreach (var a in p.GetAllMessages())
                Console.WriteLine(a.ToString());
        }

    }
}
