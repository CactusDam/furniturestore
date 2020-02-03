using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace furniturestore.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int id { set; get; }
        [DisplayName("Item: ")]
        public string name { set; get; }
        [DisplayName("Price: ")]
        public double price { set; get; }
        [DisplayName("Item Description: ")]
        public string description { set; get; }
        [DisplayName("Manufacturer: ")]
        public string manufacturername { set; get; }
        [DisplayName("Length: ")]
        public int length { set; get; }
        [DisplayName("Height: ")]
        public int height { set; get; }
        [DisplayName("Width: ")]
        public int width { set; get; }
        [DisplayName("What it looks like: ")]
        public string fooditem { set; get; }

        [DisplayName("Quantity: ")]
        public int qty { set; get; }

        [DisplayName("Item Image URL")]
        [StringLength(1024)]
        public string itemURL { set; get; }

        public int FoodGroupID { set; get; }
    }
}