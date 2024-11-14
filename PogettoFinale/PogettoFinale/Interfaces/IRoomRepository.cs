using PogettoFinale.Models;

namespace PogettoFinale.Interfaces
{
    public interface IRoomRepository
    {
        Task<List<Room>> GetAll();
        Task<Room> GetById(int id);
        Task<List<Room>> GetRoomsByHotelId(int hotelId);
    }
}
