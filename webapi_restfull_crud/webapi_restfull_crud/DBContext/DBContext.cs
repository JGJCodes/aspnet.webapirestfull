using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi_restfull_crud.Models;

namespace webapi_restfull_crud.DBContext
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext>options):base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
