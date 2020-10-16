using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ADETQ2_Eclair.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<NewGrpMember> tblGrpMember {get; set;} // <NewGrpMember.cs> Grpmember (table)
    }
}
