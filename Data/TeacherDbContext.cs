using eagle_hometeach.src.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eagle_hometeach.src.Data
{
    public class TeacherDbContext : DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options) { }
        public DbSet<TeacherDetail> TeacherDetails { get; set; }
    }
}
