using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClamCard.Interfaces;

namespace ClamCard.Repositories
{
    public class ClamCardRepository : IClamCardRepository
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

        public double EndOfTripSingle(string station)
        {
            var StartZone = TrainCard.GetZones(station);
            var DestinationZone = TrainCard.GetZones(station);
            return StartZone == Zones.A && DestinationZone == Zones.B ? 2.50 : 3.00;
        }
        public double EndOfTripDay(string station)
        {
            var StartZone = TrainCard.GetZones(station);
            var DestinationZone = TrainCard.GetZones(station);
            return StartZone == Zones.A && DestinationZone == Zones.B ? 7.00 : 8.00;
        }

        public double EndOfTripWeek(string station)
        {
            var StartZone = TrainCard.GetZones(station);
            var DestinationZone = TrainCard.GetZones(station);
            return StartZone == Zones.A && DestinationZone == Zones.B ? 40.00 : 47.00;
        }

        public double EndOfTripMonth(string station)
        {
            var StartZone = TrainCard.GetZones(station);
            var DestinationZone = TrainCard.GetZones(station);
            return StartZone == Zones.A && DestinationZone == Zones.B ? 145.00 : 165.00;
        }
    }
}
