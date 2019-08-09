using System;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            {
            }
    }
}