using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Model
{
    public class BaseModel
    {
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; } = DateTime.MinValue;
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
