using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace umbrella.Models
{
    public class Role
    {
        public long RoleId { get; set; }
      
        [Required]
        public string Description { get; set; }
    }
}
