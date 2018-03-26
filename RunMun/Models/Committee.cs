using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RunMun.Models
{
    public class Committee
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public bool Cloned { get; set; } = false;

        public Committee BaseCommittee { get; set; }

        public ICollection<Position> Positions { get; set; }

        public ICollection<Chair> Chairs { get; set; }

        public string Image { get; set; }

        public ICollection<Document> PaperURL { get; set; }

        public Committee()
        {

        }
    } 
}
