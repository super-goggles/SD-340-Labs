using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab_2.Models
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
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }
        public Section Section { get; set; }

        public Client CurrentClient { get; set; }

        [ForeignKey("CurrentClient")]
        public int CurrentClientId { get; set; }


        public Client PreviousClient { get; set; }

        [ForeignKey("PreviousClient")]
        public int PreviousClientId { get; set; }
    }
}
