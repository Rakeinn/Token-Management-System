using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Model
{
    internal class Comment: BaseModel
    {
        public int CommentId { get; set; }
        public string? Comments { get; set; }
        public string? RoleId { get; set; }



    }
}
