namespace ConcertBooking.Repositories.Interfaces
{
    public interface ITicketRepo
    {
        Task<IEnumerable<int>> GetBookedTickets(int concertId);

    }
}
