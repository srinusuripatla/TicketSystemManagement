using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models
{
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public string? TicketNumber { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? AssignedTo { get; set; }
    }
}
