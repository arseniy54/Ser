using Microsoft.EntityFrameworkCore;
using Rubicon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Rubicon.Conext
{
    public class UsersContext : DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
    }
}
