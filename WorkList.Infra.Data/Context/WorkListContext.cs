using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkList.Domain.Models;

namespace WorkList.Infra.Data.Context
{
    public  class WorkListContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        
        public WorkListContext(DbContextOptions<WorkListContext> options) : 
            base(options)
        {
            
        }
    }
}
