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

        public DbSet<ToDo> TodoItems { get; set; }

        public DbSet<Album> Actor { get; set; }

        public DbSet<Artist> Actrice { get; set; }

        public DbSet<Song> Director { get; set; }
        public object Artist { get; set; }
    }
}