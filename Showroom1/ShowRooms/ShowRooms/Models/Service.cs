namespace ShowRooms.Models
{
    public class Service
    {
        public int Id { get; set; }
        public int StoreID { get; set; }
        public string? inurance { get; set; }
        public string? aotomotive_parts { get; set; }
        public string? service_about_car { get; set; }
        public Store? Store { get; set; }

    }
}
