using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class FeedbackContext:DbContext
    {
        public FeedbackContext(DbContextOptions<FeedbackContext> options):base(options)
        {

        }

     //   public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Theme> ThemeList { get; set; }
    }
}
