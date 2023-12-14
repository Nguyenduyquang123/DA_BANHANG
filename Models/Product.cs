using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DO_AN_PTUD.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public long ProductID { get; set; }
        public string? Title { get; set; }
        public string? Images { get; set; }
        public string? Price { get; set; }
        public string? Discount { get; set; }
        public string? Quantity { get; set; }
        public string? Describe { get; set;}
        public string? Detail { get; set; }
        public string? Contact { get; set; }
        public int PostOrder { get; set; }
        public int Status { get; set;}
        public int MenuID { get; set; }
        public bool? IsActive { get; set;}

        
      
    }
}
