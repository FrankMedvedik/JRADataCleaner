using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataClean.Interfaces;
using DataClean.Models;

namespace DataClean.DataCleaner
{
    public class DataCleanEventFactory
    {
        private DataCleaner _dataCleaner;
        private Repository.Mgr.DataCleanRespository _dataCleanRepository;

        public DataCleanEventFactory(DataCleaner dataCleaner, Repository.Mgr.DataCleanRespository dataCleanRepository)
        {
            _dataCleaner = dataCleaner;
            _dataCleanRepository = dataCleanRepository;

        }

        public  DataCleanEvent ValidateAddress(InputStreetAddress input, bool forceValidation = false)
        {

            DataCleanEvent e;
            OutputStreetAddress output;
            if (forceValidation == false)
            {
                e = _dataCleanRepository.GetEvent(input.ID);
                if (e != null) return e;
            }
            var b = _dataCleaner.VerifyAndCleanAddress(input, out output);
            e = new DataCleanEvent() {Input = input, DataCleanDate = DateTime.Now, Output = output};
            if (b) _dataCleanRepository.SaveEvent(e);
            return e;
        }

        public List<DataCleanEvent> ValidateAddresses(List<InputStreetAddress> inputAddressList,
            bool forceValidation = false)
        {
            List<InputStreetAddress> toBeCleaned = new List<InputStreetAddress>();
            List<DataCleanEvent> results = new List<DataCleanEvent>();
            foreach (var i in inputAddressList)
            {
                if (forceValidation == false)
                {
                    var e = _dataCleanRepository.GetEvent(i.ID);
                    if (e != null) results.Add(e);
                    else toBeCleaned.Add(i);
                }
                else
                {
                    toBeCleaned.Add(i);
                }
            }
            var outArray = _dataCleaner.VerifyAndCleanAddress(toBeCleaned.ToArray());
            List<DataCleanEvent> newEvents = CombineOutputsAndInputs(toBeCleaned, outArray);
            foreach (var e in newEvents)
            {
                /* ONLY SAVE PERFECT OUTPUT */
                if(e.Output.OkComplete)
                    _dataCleanRepository.SaveEvent(e);
            }
            results.AddRange(newEvents);
            return results;
        }

        private List<DataCleanEvent> CombineOutputsAndInputs(List<InputStreetAddress> toBeCleaned,OutputStreetAddress[] outArray)
        {

            var convertedList = new List<DataCleanEvent>();

            foreach (var i in toBeCleaned)
            {
                var e = new DataCleanEvent();
                //find related output assign to local var
                var oc = outArray.First(obj => obj.ID == i.ID);
                if (oc != null)
                {
                    e.DataCleanDate = DateTime.Now;
                    e.Input = i;
                    e.Output = oc;
                    convertedList.Add(e);
                }
            }
            return convertedList;
        }
    }
}

 