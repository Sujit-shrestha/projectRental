using System.ComponentModel.DataAnnotations;

namespace SemesterPorject.Models
{
    public class RentalSpaceModel
    {
        [Key]
        public int RentalSpaceID { get; set; }
        [Required]
        public string Location { get; set; }
        public int Cost { get; set; }
        public byte[]? SpaceImage { get; set; }
        public string? Description { get; set; }
        public string? Floor { get; set; }

        public int? Length { get; set; }
        public int? Breadth { get; set; }
        public int? Height { get; set; }
        public string? Color { get; set; }
        public bool? WaterFacility { get; set; }
        public DateTime DatePosted { get; set; }
        public string? Lister { get; set; }
        public byte[]? ListerImage { get; set;}
        //rating of room acc to facility
        //transportation
        //consumer review
    }
}
