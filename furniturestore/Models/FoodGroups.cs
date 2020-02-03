using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace furniturestore.Models
{
    public class FoodGroups
    {
        public int id { set; get; }
        [DisplayName("Meal")]
        public string name { set; get; }
    }
}