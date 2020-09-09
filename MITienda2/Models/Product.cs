using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MITienda2.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]

        public int ProductID { get; set; }
        [Required, StringLength(100), Display(Name = "Nombre")]

        public string ProductName { get; set; }
        [Required, StringLength(10000), Display(Name = "Descripcion del producto"),
         DataType(DataType.MultilineText)]

        public string Description { get; set; }
        public string ImagePatch { get; set; }
        [Display(Name = "Precio")]

        public double? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}