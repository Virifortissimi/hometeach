using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eagle_hometeach.src.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext _db;
        private readonly TeacherDbContext _teacherDb;

        public DbInitializer(ApplicationDbContext db, TeacherDbContext teacherDb)
        {
            _db = db;
            _teacherDb = teacherDb;
        }

        public void Initialize()
        {
            try
            {
                if(_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }

                if(_teacherDb.Database.GetPendingMigrations().Count() > 0)
                {
                    _teacherDb.Database.Migrate();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
