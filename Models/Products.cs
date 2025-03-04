using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Product Name Required.")]
        public String ProductName { get; set; }


        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

    } 
}