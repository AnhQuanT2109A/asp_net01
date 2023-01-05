namespace ShowRooms.Models
{
    public class Store
    {
        public int ID { get; set; }
        public int StoreID { get; set; }
        public string? Service { get; set; }
        public string? Contact { get; set; }

        public Contact? Contacts { get; set; }
        public Service? Services { get; set; }
        public ICollection<Car_store>? Car_store { get; set; }


    }
}
