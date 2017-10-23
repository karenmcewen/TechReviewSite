using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechReviewSite.Models
{
    public class Category
    {
        //Category includes the items to be reviewed
        //requirement - 3+ categories

        //ID is the primary key for the Category Model
        [Key]
        public int ID { get; set; } 
        [DisplayName("Item")]
        public string ItemName { get; set; }

     
    }
}