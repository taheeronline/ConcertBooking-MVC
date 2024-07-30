using ConcertBooking.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using ConcertBooking.Repositories;

namespace ConcertBooking.Repositories.Implementations
{
    public class TicketRepo : ITicketRepo
    {
        private readonly ApplicationDbContext _context;

        public TicketRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<int>> GetBookedTickets(int id)
        {
            var bookedTickets =await  _context.Tickets.Where(t=>t.ConcertId==id && t.IsBooked)
                .Select(t=>t.SeatNumber).ToListAsync();
            return bookedTickets;
        }
    }
}
