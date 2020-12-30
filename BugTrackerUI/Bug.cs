using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BugTrackerUI
{
    public class Bug
    {
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
        public int Id { get; set; }
        [Required]
        [Range(1, 5)]
        public int Priority { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
