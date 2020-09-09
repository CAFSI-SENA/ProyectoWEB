using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MITienda2.Models
{
    public class Category
    {
        [ScaffoldColumn(false)]
        public int CategoryID { get; set; }
        [Required, StringLength(100), Display(Name = "Nombre")]

        public string CategoryName { get; set; }
        [Display(Name = "Descripcion del producto")]

        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}