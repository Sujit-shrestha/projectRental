using System.ComponentModel.DataAnnotations;

namespace SemesterPorject.Models
{
    public class RoomData
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public string Location { get; set; }

        public int Length { get; set; }
        public int breadth { get; set; }
        public int height { get; set; }
        public string color { get; set; }
        public bool waterFacility { get; set; }
        //electricity
        //rating of room acc to facility
        //transportation
        //consumer review
    }
}
