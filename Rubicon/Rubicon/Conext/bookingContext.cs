using Microsoft.EntityFrameworkCore;
using Rubicon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ser.Conext
{
    public class bookingContext : DbContext
    {
        public bookingContext(DbContextOptions<bookingContext> options) : base(options)
        {

        }
        public DbSet<booking> Bookings { get; set; }
    }
}
