using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JRAMelissaWrapper.Personator;

namespace JRAMelissaWrapper
{
    interface IDataClean
    {

        Boolean VerifyAndCleanAddress(InputStreetAddress inputAddress, out OutputStreetAddress outputAddress);
        OutputStreetAddress[] VerifyAndCleanAddress(InputStreetAddress[] inputAddressArray);

    }
}
