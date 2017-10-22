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

        [StringLength(250)]
        public string Content { get; set; }

        //using two annotations! 
        [DisplayName("Stars")]
        [Range(1,5)]
        public int NumStars { get; set; }

        //Using a ?next to DateTime allows the field to be void
        [DisplayName("Review Year")]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public DateTime? PublishDate { get; set; } 

       [ForeignKey("Category")]
       public int CategoryID { get; set; } 
       public Category Category {get; set;}
        //the CategoryID is the primary key in model Category

        
    }
}