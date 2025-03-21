using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage ="Category id is required.")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="category name is required.")]
        public string CategoryName { get; set; }

        public virtual ICollection<Products> products { get; set; }
    }
}