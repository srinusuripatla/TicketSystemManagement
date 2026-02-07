namespace TicketSystem.API.Models
{
    public class CreateTicket
    {
        
        public string? Subject { get; set; }
        public string? Description { get; set; }
       
        public int CreatedBy { get; set; }
                
    }
}
