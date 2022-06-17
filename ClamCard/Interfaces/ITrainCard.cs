using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClamCard.Interfaces
{
    public interface ITrainCard
    {
        public Zone GetZones(string station);
    }
    public enum Zone
    {
        A, B
    }
}

