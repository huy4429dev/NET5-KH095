using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KH095.Models
{
    public class Tag
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is not null")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Name is not null")]
        [MaxLength(150, ErrorMessage = "Name is toso long")]
        public string Description { get; set; }
        public string Color { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }


    
    public class ProductTag
    {
        public int ProductId { get; set; }
        public int TagId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("TagId")]
        public virtual Tag Tag { get; set; }

    }
}