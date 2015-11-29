using System;
using System.Collections.Generic;
using DataClean.Models;

namespace DataClean.Interfaces
{
    public interface IDataCleaner
    {
        // the dataclean event passed in is updated with the results the input address is not updated
   
        List<DataCleanEvent> VerifyAndCleanAddress(List<InputStreetAddress> inputAddresses);

        Boolean VerifyAndCleanAddress(InputStreetAddress inA, out OutputStreetAddress outA);
        OutputStreetAddress[] VerifyAndCleanAddress(InputStreetAddress[] inputAddressArray);
    }
}