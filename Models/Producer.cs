using System.ComponentModel.DataAnnotations;

namespace TicketingApp.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilePictureURL { get; set; }
        public string? Fullname { get; set; }
        public string? Bio { get; set; }
    }
}