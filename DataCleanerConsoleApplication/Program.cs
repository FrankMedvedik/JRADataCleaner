using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using log4net;
using log4net.Config;
using DataClean;
using DataClean.Models;
using DumpCleaner;
using MoreLinq;
using Respondent.Repository;

namespace ConsoleApplication1
{
    class Program
    {
        private static readonly ILog Logger =
        LogManager.GetLogger(typeof (Program));

        private static void Main(string[] args)
        {
            var db = new Respondent.Repository.respondentEntities();
            DataCleanCriteria criteria = new DataCleanCriteria();
            criteria.AutoFixCity = true;
            criteria.AutoFixState = true;
            criteria.AutoFixPostalCode = true;
            criteria.AutoFixAddressLine1 = true;
            criteria.ForceValidation = true;
            int cnt = 0;

            var a = (from s in db.dr_sunshine_dump where(!db.fjm_sunshine_dump.Any(es => (es.tran_id == s.tran_id))) select s);

            //var a = db.dr_sunshine_dump.Where(x=>x.tran_id in (select tran_id from fjm_sunshine_dump). ToList();
            foreach (var dirtyVouchers in a.Batch(50).ToList())
            {
                var cleanVouchers = DataCleanDumpSvc.CleanAddresses(dirtyVouchers.ToList(), criteria);
                foreach (var c in cleanVouchers.ToList())
                {
                    var existingone = db.fjm_sunshine_dump.Find(c.tran_id);
                    if(existingone != null)
                        Console.WriteLine("{0} already on file {1}", c.tran_id, DateTime.Now.ToLongTimeString());
                    else
                        db.fjm_sunshine_dump.Add(c);
                }
                cnt += cleanVouchers.Count;
                try
                {
                    db.SaveChanges();

                    Console.WriteLine("{0} batch saved {1}", DateTime.Now.ToLongTimeString(), cnt);
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} batch save failed {1}", DateTime.Now.ToLongTimeString(), e.Message) ;
                    var z = db.GetValidationErrors();
                    Console.WriteLine("{0} batch save failed {1} {2}", DateTime.Now.ToLongTimeString(), e.Message, e.InnerException.Message ?? "");
                }
            }
            Console.WriteLine("DONE! {0} processed", cnt);
        }

     }
}

