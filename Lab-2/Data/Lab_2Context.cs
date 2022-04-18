#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab_2.Models;

namespace Lab_2.Data
{
    public class Lab_2Context : DbContext
    {
        public Lab_2Context (DbContextOptions<Lab_2Context> options)
            : base(options)
        {
        }

        public DbSet<Lab_2.Models.Room> Room { get; set; }
    }
}
