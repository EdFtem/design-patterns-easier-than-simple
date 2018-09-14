using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class SkiFacade
    {
        private SkiRent _skiRent = new SkiRent();
        private RentSkiTicketSystem _rentSkiTicketSystem = new RentSkiTicketSystem();
        private HotelBookingSystem _hotelBookingSystem = new HotelBookingSystem();

        public int HaveGoodRest(int height, int weight, int feetSize, int skierLevel, int roomQuality)
        {
            int skiPrice = _skiRent.RentSki(weight, skierLevel);
            int rentSkiTicketSystem = _rentSkiTicketSystem.BuyOneDayTicket();
            int hotelBookingSystem = _hotelBookingSystem.BookRoom(roomQuality);

            return skiPrice + rentSkiTicketSystem + hotelBookingSystem;
        }
    }
}
