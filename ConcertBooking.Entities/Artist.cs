﻿namespace ConcertBooking.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Concert> Concerts { get; set; } = new List<Concert>();

    }
}
