using System;
using System.Collections.Specialized;
using System.Configuration;

namespace DataClean
{
    public interface IDataCleaner
    {

        Boolean VerifyAndCleanAddress(InputStreetAddress inA, out OutputStreetAddress outA);
        OutputStreetAddress[] VerifyAndCleanAddress(InputStreetAddress[] inputAddressArray);
    }
}