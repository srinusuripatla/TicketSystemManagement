using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models
{
    public partial class Ticketcomment
    {
        public int CommentId { get; set; }
        public int? TicketId { get; set; }
        public string? Comment { get; set; }
        public int CommentedBy { get; set; }
        public DateTime? CommentDate { get; set; }
    }
}
