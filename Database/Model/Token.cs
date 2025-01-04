using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database.Model
{
    public class Token:BaseModel
    {
        [Key]
        public string TokenId { get; set; } = Guid.NewGuid().ToString();
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Mobile { get; set; }
        [Required]
        public string? Priority { get; set; }
        [Required]
        public string? CategoryId { get; set; }
        [Required]
        public string? SubCategoryId { get; set; }
       
        public string? Description { get; set; }
        [Required]
        public string? RoleId { get; set; }

        public string? CommentId { get; set; }
        [Required]
        public string? StatusId { get; set; }
        //File


    }
}
