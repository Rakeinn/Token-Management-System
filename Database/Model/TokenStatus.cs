using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Model
{
    public class TokenStatus: BaseModel
    {
        public int StatusId { get; set; }
        public string? StatusName { get; set; }
        public bool IsActive { get; set; }
    }
}
