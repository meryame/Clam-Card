using Xunit;
using Rhino.Mocks;
using ClamCard.Interfaces;
using ClamCard.Models;
using ClamCard.Repositories;

namespace Clam_Card_Test
{
    public class ClamCardTest
    {
        private Card card;
        private IClamCardRepository _clamRepository;
        private double price;
        private ITrainCard trainCard;
        private ClamCardRepository _clamCardRepository;
        [Fact]
        public void Michael_has_a_clam_card()
        {
            _clamRepository = MockRepository.GenerateMock<IClamCardRepository>();
            _clamRepository.Stub(c => c.BeginingOfTrip(Arg<string>.Is.Anything));
            card = new Card(_clamRepository, "Michael");
        }
        [Fact]
        public void Travel_from_aldgate()
        {
            card.TouchIn("Aldgate");
        }
        [Fact]
        public void clam_card_in_aldgate_station()
        {
            var station = _clamRepository.GetArgumentsForCallsMadeOn(c => c.BeginingOfTrip(Arg<string>.Is.Anything))[0][0];
            station.Equals("Aldgate");
        }
        [Fact]
        public void Michaeel_has_a_clam_card()
        {
            _clamRepository = MockRepository.GenerateMock<IClamCardRepository>();
            _clamRepository.Stub(c => c.EndOfTrip(Arg<string>.Is.Anything));
            card = new Card(_clamRepository, "Michael");
        }
        [Fact]
        public void end_travel_in_balham()
        {
            card.TouchOut("Balham");
        }
        [Fact]
        public void clam_card_in_balham_destination()
        {
            var destination = _clamRepository.GetArgumentsForCallsMadeOn(c => c.EndOfTrip(Arg<string>.Is.Anything))[0][0];
            destination.Equals("Balham");
        }
        [Fact]
        public void start_travel_from_zoneA()
        {
            trainCard = MockRepository.GenerateStub<ITrainCard>();
            trainCard.Stub(t => t.GetZones("Asterisk")).Return(Zone.A);
            _clamCardRepository = new ClamCardRepository(trainCard);
            _clamCardRepository.BeginningOfTrip("Asterisk");
        }
        [Fact]
        public void end_travel_from_zoneA()
        {
            trainCard.Stub(t => t.GetZones("Aldgate")).Return(Zone.A);
            price = _clamCardRepository.EndOfTrip("Aldgate");

        }
        [Fact]
        public void paye_2_50_for_travel()
        {
            price.Equals(2.50);
        }
        [Fact]
        public void start_travele_from_zoneA()
        {
            trainCard = MockRepository.GenerateStub<ITrainCard>();
            trainCard.Stub(t => t.GetZones("Aldgate")).Return(Zone.A);
            _clamCardRepository = new ClamCardRepository(trainCard);
            _clamCardRepository.BeginningOfTrip("Aldgate");
        }
        [Fact]
        public void end_travel_from_zoneB()
        {
            trainCard.Stub(t => t.GetZones("Balham")).Return(Zone.B);
            price = _clamCardRepository.EndOfTrip("Balham");

        }
        [Fact]
        public void paye_3_00_for_travel()
        {
            price.Equals(3.00);
        }
    }
}