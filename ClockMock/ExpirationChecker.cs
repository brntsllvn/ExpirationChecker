using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClockMock
{
    public class ExpirationChecker
    {
        public bool HasExpired(DateTime dateTime)
        {
            if (DateTime.Now < dateTime)
                return false;
            return true;
        }
    }
}
