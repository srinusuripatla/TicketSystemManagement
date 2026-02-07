using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;
using TicketSystem.API.Models;

namespace TicketSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketesController : ControllerBase
    {
        private readonly TicketDbContext _Context;

        public TicketesController(TicketDbContext context)
        {
            _Context = context;
        }
        [HttpPost("create")]
        public IActionResult creteticket(CreateTicket model)
        {
            var tickte = new Ticket
            {
                TicketNumber = "TKt" + DateTime.Now.Ticks,
                Subject = model.Subject,
                Description = model.Description,
                Status = "open",
                CreatedDate = DateTime.Now,
                CreatedBy = model.CreatedBy

            };
            _Context.Tickets.Add(tickte);

            _Context.SaveChanges();

            return Ok("Ticket Created Successfully");
        }

        [HttpGet("list")]
        public IActionResult GetTickets(int UserId, string Role)
        {


            if (Role == "Admin")
            {
                return Ok(_Context.Tickets.ToList());
            }

            return Ok(
                _Context.Tickets
                        .Where(t => t.CreatedBy == UserId)
                        .ToList()
            );

        }
        [HttpPut("assign")]
        
        public IActionResult AssignTicket([FromBody] AssignTicketRequest request)
        {
            var ticket = _Context.Tickets.FirstOrDefault(t => t.TicketId == request.TicketId);

            if (ticket == null)
                return NotFound("Ticket not found");

            ticket.AssignedTo = request.AssignedTo;
           
            _Context.SaveChanges();

            return Ok("Ticket assigned successfully");
        }
        [HttpPut("status")]
        public IActionResult UpdateStatus(int ticketId, string newStatus, string updatedBy)
        {
            var ticket = _Context.Tickets
                                 .FirstOrDefault(t => t.TicketId == ticketId);

            if (ticket == null)
                return NotFound("Ticket not found");

           
            if (ticket.Status == "Closed")
                return BadRequest("Closed ticket cannot be modified");

            var history = new Ticketstatushistory
            {
                TicketId = ticketId,
                OldStatus = ticket.Status,
                NewStatus = newStatus,
                UpdatedBy = updatedBy,
                UpdatedDate = DateTime.Now
            };

            ticket.Status = newStatus;

            _Context.Ticketstatushistories.Add(history);
            _Context.SaveChanges();

            return Ok("Status updated successfully");
        }
        [HttpPost("comment")]
        public IActionResult AddComment([FromBody] AddCommentRequest request)
        {
            var ticket = _Context.Tickets
                .FirstOrDefault(t => t.TicketId == request.TicketId);

            if (ticket == null)
                return NotFound("Ticket not found");

            var comment = new Ticketcomment
            {
                TicketId = request.TicketId,
                Comment = request.Comment,
                CommentedBy = request.CommentedBy,
                CommentDate = DateTime.Now
            };

            _Context.Ticketcomments.Add(comment);
            _Context.SaveChanges();

            return Ok("Comment added successfully");
        }

        [HttpGet("comments/{ticketId}")]
        public IActionResult GetComments(int ticketId)
        {
            var comments = _Context.Ticketcomments
                .Where(c => c.TicketId == ticketId)
                .OrderByDescending(c => c.CommentDate)
                .ToList();

            return Ok(comments);
        }


    }

} 
