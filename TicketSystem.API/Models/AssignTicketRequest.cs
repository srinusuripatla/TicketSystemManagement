namespace TicketSystem.API.Models
{
    public class AssignTicketRequest
    {
        public int TicketId { get; set; }
        public int AssignedTo { get; set; }
        public int AssignedBy { get; set; }
    }
}
