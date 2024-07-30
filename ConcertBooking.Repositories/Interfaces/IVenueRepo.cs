using ConcertBooking.Entities;

namespace ConcertBooking.Repositories.Interfaces
{
    public interface IVenueRepo
    {
        Task<IEnumerable<Venue>> GetAll();
        Task<Venue> GetById(int id);
        Task Save(Venue venue);
        Task Edit(Venue venue);
        Task RemoveData(Venue venue);

    }
}
