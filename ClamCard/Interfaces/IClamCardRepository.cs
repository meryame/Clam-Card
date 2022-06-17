using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClamCard.Interfaces
{
    public interface IClamCardRepository
    {
        public void BeginingOfTrip(string station);
        public double EndOfTrip(string station);
    }
}
