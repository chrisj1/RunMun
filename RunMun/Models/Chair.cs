using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunMun.Models
{
    public enum ChairType {
        Chair,
        Cochair
    }

    public class Chair
    {
        [Key]
        public string Id { get; set; }

        public ApplicationUser User { get; set; }
        
        public ChairType Type { get; set; }
        
        public Committee Committee;

        public Chair()
        {

        }
    }
}
