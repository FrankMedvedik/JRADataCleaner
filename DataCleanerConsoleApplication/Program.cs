using System;
using System.Configuration;
using log4net;
using log4net.Config;
using DataClean;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly ILog Logger =
        LogManager.GetLogger(typeof (Program));

        private static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            PrintAllMessages();
            Console.ReadKey();
            //var i = new InputStreetAddress()
            //{
            //    AddressLine1 = "502 grant ave",
            //    //City = "Willow Grove",
            //    Country = "USA",
            //    PostalCode = "190452",
            //    FullName = "frank medvedik",
            //    //State = "PA"
            //};
            //var c = ConfigurationManager.AppSettings;
            //var w = new DataCleaner(c);

            ///* 
            // * process one record             
            // */
            //try
            //{
            //    OutputStreetAddress o;
            //    var b = w.VerifyAndCleanAddress(i, out o);
            //    {
            //        Logger.Debug("status: " + b);
            //        foreach (var pe in o.Results)
            //        {
            //            Logger.Debug("Error " + pe.ToString());
            //        }
            //    }

            //    i.PostalCode = "";
            //    var inArray = new[] { i };

            //    /* 
            //    * process arrary of records             
            //    */

            //    var outArray = w.VerifyAndCleanAddress(inArray);
            //    foreach (var oRec in outArray)
            //    {
            //        Logger.Debug("Output Record: " + oRec.ToString());
            //        foreach (var r in outArray)
            //        {
            //            Logger.Debug("output Record: " + r.ToString());
            //            foreach (var pe in r.Results)
            //            {
            //                Logger.Debug("Error " + pe.ToString());
            //            }
            //        }
            //    }
            //}
            //catch(Exception e)
            //{
            //    Logger.Error(e.ToString());
            //}
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
        public static void PrintAllMessages()
        {
            var p = new ParseResultDictionary();
            Console.WriteLine("List all parse response messages");
            foreach (var a in p.GetAllMessages())
                Console.WriteLine(a.ToString());
        }

    }
}
