namespace ShowRooms.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string? Fullname { get; set; }
        public DateTime Year { get; set; }
        public float Length { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string? Maximum_weight { get; set; }
        public float Top_speed { get; set; }
        public string? Interior_color { get; set; }
        public int number_of_seat { get; set; }
        public float Price { get; set; }

        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<Car_store>? Car_stores { get; set; }

    }
}
