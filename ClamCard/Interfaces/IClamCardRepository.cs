using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClamCard.Interfaces
{
    public interface IClamCardRepository
    {
        public void BeginningOfTrip(string station);
        public double EndOfTripSingle(string station);
        public double EndOfTripDay(string station);
        public double EndOfTripWeek(string station);
        public double EndOfTripMonth(string station);

    }
}
