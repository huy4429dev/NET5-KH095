using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace KH095.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is not null")]
        [MaxLength(255, ErrorMessage = "Title is too long")]
        public string Title { get; set; }

        [ForeignKey("ProductTypes"), Required(ErrorMessage = "Required")]
        public int TypeId { get; set; }

        [Required(ErrorMessage = "Required")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Image { get; set; }
        public string Images { get; set; }
        public string Colors { get; set; }
        public string Sizes { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public int Quantity { get; set; }
        public float Rate { get; set; }
        public int CountOrder { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public ProductType ProductTypes { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }

    public class ProductType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is not null")]
        [MaxLength(50, ErrorMessage = "Name is too long")]
        public string Name { get; set; }

        [MaxLength(255, ErrorMessage = "Name is toso long")]
        public string Description { get; set; }
        public int? TypeParentId { get; set; }
        public ProductType ProductTypeParent { get; set; }
        public ICollection<ProductType> ProductTypeChildrens {get;set;}
        public ICollection<Product> Products { get; set; }
    }

}