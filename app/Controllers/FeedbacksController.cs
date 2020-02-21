using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbacksController : ControllerBase
    {
        private readonly FeedbackContext _context;

        public FeedbacksController(FeedbackContext context)
        {
            _context = context;
        }

        //GET: api/Feedbacks
        [HttpGet]
        public async Task<ActionResult<Message>> GetFeedback()
        {
            var feedback = await _context.Messages.FirstOrDefaultAsync(x => x.ID == _context.Messages.Max(p => p.ID));

            return feedback;
        }


        // POST: api/Feedbacks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Feedback>> PostFeedback(Feedback feedback)
        {
            // _context.Feedback.Add(feedback);
            // Customer ID
            int IdC = 0;

            _context.SaveChanges();
            if (null != _context.Customers.FirstOrDefault(x => x.PhoneNumber == feedback.PhoneNumber &&
            x.Mail == feedback.Mail && 0 < x.ID))
            {
                IdC = _context.Customers.FirstOrDefault(x => x.PhoneNumber == feedback.PhoneNumber &&
            x.Mail == feedback.Mail && 0 < x.ID).ID;
            }
            else
            {
                _context.Customers.Add(new Customer(feedback.Surname, feedback.Mail, feedback.PhoneNumber));

                _context.SaveChanges();
                var Cont = _context.Customers.FirstOrDefault(x => x.ID == _context.Customers.Max(p => p.ID));
                IdC = Cont.ID;

            }
            // Theme ID
            int IdT = _context.ThemeList.FirstOrDefault(x => x.ThemeName == feedback.Theme).ID;
            _context.Messages.Add(new Message(feedback.Message, IdC, IdT));
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetFeedback", new { id = feedback.ID }, feedback);
        }
    }
}
