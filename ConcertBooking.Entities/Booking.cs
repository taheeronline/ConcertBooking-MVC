﻿namespace ConcertBooking.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        public string UserId { get; set; }
        public ICollection<Ticket> Tickets { get; set; }

    }
}
