
using System.ComponentModel.DataAnnotations;

namespace RepositryParttrnWithSql.Models
{
    public class StdentModel
    {
        [Key] 
        public int ID { get; set; }
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Standrat { get; set; } = "";
    }

   
}
