namespace TicketSystem.API.Models
{
    public class AddCommentRequest
    {
        public int TicketId { get; set; }
        public string? Comment { get; set; }
        public int CommentedBy { get; set; }
    }
}
