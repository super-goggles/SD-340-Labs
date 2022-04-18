using System.ComponentModel.DataAnnotations;

namespace Lab_1.Models
{
    public enum Section
    {
        First,
        Second,
        Third
    }
    public class Room
    {
        [Key]
        [Display(Name ="Room Number")]
        public int RoomNumber { get; set; }
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }
        public Section Section { get; set; }
    }
}
