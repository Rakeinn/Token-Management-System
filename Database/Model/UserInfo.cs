using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Model
{
   
        public class UserInfo: BaseModel
        {
            [Key]
            public string UserId { get; set; } = Guid.NewGuid().ToString();
            [Required]
            public string? Name { get; set; }
            [Required]
            public string? Mobile { get; set; }
            [Required]
            public string? Email { get; set; }
            [Required]
            public string? PasswordHash { get; set; }

            public int? RoleId { get; set; } 
            
            
          


        }
    
}
