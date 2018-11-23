using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
 public   class Role
    {
     [Key]
     public string F_Id { get; set; }
     [MaxLength(35)]
     public string Name { get; set; }
    }
}
