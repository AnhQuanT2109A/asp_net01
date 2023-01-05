namespace ShowRooms.Models
{
    public class Contact
    {

        public int Id { get; set; }
        public int StoreID { get; set; }
        public string? username { get; set; }
        public string? address { get; set; }
        public string? phone { get; set; }
        public string? mail_address { get; set; }
        public DateTime date { get; set; }
        public Store? Store { get; set; }
    }
}
