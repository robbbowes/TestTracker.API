using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTracker.API.Entities
{
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [ForeignKey("PackageId")]
        public Package Package { get; set; }
        public int PackageId { get; set; }
        [Required]
        public bool IsBroken { get; set; }
        public int TimesBroken { get; set; }
        public ICollection<Breakage> Breakages { get; set; }
            = new List<Breakage>();
    }
}
