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

        [Key]
        public int ID { get; set; } //this is the primary key for the Category Model
        [DisplayName("Which item would you like to review?")]
        public string ItemName { get; set; }

        //example from bridge project - may not be needed here
        //public ICollection<Course_Student> Course_Students { get; set; }
        //might want to be able to list all reviews for a single category?
    }
}