using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClamCard.Interfaces;

namespace ClamCard.Repositories
{
    public class ClamCardRepository
    {
        private readonly ITrainCard TrainCard;
        public string StartStation { get; set; }
        public ClamCardRepository(ITrainCard trainCard)
        {
            TrainCard = trainCard;
        }

        public void BeginningOfTrip(string station)
        {
            StartStation = station;
        }

        public double EndOfTrip(string station)
        {
            var StartZone = TrainCard.GetZones(station);
            var DestinationZone = TrainCard.GetZones(station);
            if (StartZone == Zones.A && DestinationZone == Zones.B)
            {
                return 2.50;
            }
            return 3.00;
        }
    }
}
