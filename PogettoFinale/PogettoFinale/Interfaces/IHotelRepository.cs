using PogettoFinale.Models;

namespace PogettoFinale.Interfaces
{
    public interface IHotelRepository
    {
        Task<List<Hotel>> GetAll();
        Task<Hotel> GetById(int id);
        Task<IEnumerable<Hotel>> SearchHotels(string query);
    }
}
