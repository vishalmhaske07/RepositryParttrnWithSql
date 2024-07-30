using Microsoft.EntityFrameworkCore;
using RepositryParttrnWithSql.Models;

namespace RepositryParttrnWithSql.Data
{
    public class StudentDBContext: DbContext
    {
        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options) { 
        
        
        }
          public virtual DbSet<StdentModel> StdentModels { get; set; }  

    }
    
}
