using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Properties.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo> Todo { get; set; }

        public DbSet<Album> Album { get; set; }

        public DbSet<Artist> Artist { get; set; }

        public DbSet<Song> Song { get; set; }
    }
}