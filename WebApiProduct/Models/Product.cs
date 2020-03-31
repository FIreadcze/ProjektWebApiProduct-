using System;
using System.Collections.Generic;
//doinstalovano!! pro required
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiProduct.Models
{
    public class Product
    {
        private int id;
        private string name;
        private decimal price;
        private string description;
        private string ImgUri;

        [Key]
        [Column(TypeName = "int")]
        [Required]
        public int Id { get => id; set => id = value; }
        [Column(TypeName = "nvarchar(30)")]

        [Required]
        public string Name { get => name; set => name = value; }

       
        
        [Required]
        [Column(TypeName = "decimal(8,2)")]
       
        public decimal Price { get => price; set => price = value; }
        [Column(TypeName = "nvarchar(250)")]

        [Required]
        public string ImgUri1 { get => ImgUri; set => ImgUri = value; }
        [Column(TypeName = "nvarchar(300)")]


        public string Description { get => description; set => description = value; }

    }
}
