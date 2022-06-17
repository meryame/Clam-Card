using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClamCard.Interfaces;

namespace ClamCard.Models
{
    public class Card
    {
        private readonly IClamCardRepository _clamCardRepository;
        private readonly string Traveler;
        public Card(IClamCardRepository clamCardRepository, string traveler)
        {
            _clamCardRepository = clamCardRepository;
            Traveler = traveler;
        }
        public void TouchIn(string station)
        {
            _clamCardRepository.BeginingOfTrip(station);
        }
        public void TouchOut(string station)
        {
            _clamCardRepository.EndOfTrip(station);
        }
    }
}
