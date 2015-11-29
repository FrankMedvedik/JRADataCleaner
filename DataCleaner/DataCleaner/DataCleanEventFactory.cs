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

        public DataCleanEvent ValidateAddress(InputStreetAddress input, bool forceValidation = false)
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
    }
}
