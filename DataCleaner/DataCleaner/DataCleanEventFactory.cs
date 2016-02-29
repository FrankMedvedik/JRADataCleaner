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
        private DataCleanCriteria _criteria;

        public DataCleanEventFactory(DataCleaner dataCleaner, Repository.Mgr.DataCleanRespository dataCleanRepository, DataCleanCriteria criteria)
        {
            _dataCleaner = dataCleaner;
            _dataCleanRepository = dataCleanRepository;

            // if we get bad data clean criteruia use the defaults (no fixes and no force) 
            if (criteria != null) _criteria = criteria;
            _criteria = new DataCleanCriteria()
            {
                AutoFixAddressLine1 = false,
                AutoFixCity = false,
                AutoFixPostalCode = true,
                AutoFixState = false,
                ForceValidation = false
            };

        }

        public  DataCleanEvent ValidateAddress(InputStreetAddress input)
        {

            DataCleanEvent e;
            OutputStreetAddress output;
            if (_criteria.ForceValidation == false)
            {
                e = _dataCleanRepository.GetEvent(input.ID);
                if (e != null) return e;
            }
            //if (_datacleaner == null)
            //    _dataCleaner = new DataCleaner();
            var b = _dataCleaner.VerifyAndCleanAddress(input, out output);
            e = new DataCleanEvent() {Input = input, DataCleanDate = DateTime.Now, Output = output};
            if (b) _dataCleanRepository.SaveEvent(e);
            return e;
        }

        public DataCleanEvent GetExistingEvent(int id)
        {
                return _dataCleanRepository.GetEvent(id);
        }
        public List<DataCleanEvent> ValidateAddresses(List<InputStreetAddress> inputAddressList)
        {
            List<InputStreetAddress> toBeCleaned = new List<InputStreetAddress>();
            List<DataCleanEvent> results = new List<DataCleanEvent>();
            foreach (var i in inputAddressList)
            {
                if (_criteria.ForceValidation == false)
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
            if (toBeCleaned.Any())
            {
                var outArray = _dataCleaner.VerifyAndCleanAddress(toBeCleaned.ToArray());
                List<DataCleanEvent> newEvents = CombineOutputsAndInputs(toBeCleaned, outArray);
                foreach (var e in newEvents)
                {
                    /* ONLY SAVE PERFECT OUTPUT */
                    if (e.Output.OkComplete)
                        _dataCleanRepository.SaveEvent(e);
                }
                results.AddRange(newEvents);
            }
            return ApplyAutomaticFixes(results);
        }

        private List<DataCleanEvent> ApplyAutomaticFixes(List<DataCleanEvent> results)
        {
            AutoFixer A = new AutoFixer(_criteria);
            A.DataCleanEvents = results;
            A.ApplyFixes();
            return A.DataCleanEvents;
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

 