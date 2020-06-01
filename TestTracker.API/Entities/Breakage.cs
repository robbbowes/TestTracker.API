using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTracker.API.Entities
{
    public class Breakage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Reason { get; set; }
        [ForeignKey("TestId")]
        public Test Test { get; set; }
        public int TestId { get; set; }
    }
}
