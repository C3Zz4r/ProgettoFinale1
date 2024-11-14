namespace PogettoFinale.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public int Capacity { get; set; }
        public int HotelId { get; set; }

        // Зв'язок із готелем
        public Hotel Hotel { get; set; }
    }
}
