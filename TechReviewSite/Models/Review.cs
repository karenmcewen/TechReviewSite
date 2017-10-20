using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechReviewSite.Models
{
    public class Review
    {
        //required - at least 5 reviews
        //stretch task - unique images for reviews

        [Key]
        public int ID { get; set; } //this is the primary key for the Review Model
        public string Reviewer { get; set; } //additional property - not going to create a model at this time
        public string Title { get; set; } 
        public string Content { get; set; } 
        [DisplayName("Rate from 1 to 5 stars")]
        public int NumStars { get; set; }

        //using two annotations!
        [DisplayName("Enter review date MM/dd/yyyy")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime PublishDate { get; set; } 

       [ForeignKey("Category")]
       public int CategoryID { get; set; } //the CategoryID is the primary key in model Category
       public Category Category {get; set;}

        //example from bridge project - may not be needed here
        //public ICollection<Course_Student> Course_Students { get; set; }
    }
}