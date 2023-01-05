namespace ShowRooms.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public string? CarName { get; set; }
        public string? exterior_color { get; set; }  //mau ngoai that 
        public string? work_productivity { get; set; }
        public float? cylinder_number { get; set; }

        public Car? Car { get; set; }
    }
}
