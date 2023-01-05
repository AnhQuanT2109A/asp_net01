namespace ShowRooms.Models
{
    public class Car_store
    {
        public int Id { get; set; }

        public int CarID { get; set; }
        public int StoreID { get; set; }

        public Car? Car { get; set; }

        public Store? Store { get; set; }
    }
}
