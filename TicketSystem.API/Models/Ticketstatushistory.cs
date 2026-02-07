using System;
using System.Collections.Generic;

namespace TicketSystem.API.Models
{
    public partial class Ticketstatushistory
    {
        public int HistoryId { get; set; }
        public int? TicketId { get; set; }
        public string? OldStatus { get; set; }
        public string? NewStatus { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
