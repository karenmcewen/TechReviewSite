namespace TechReviewSite.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
   
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TechReviewSite.Models.TechReviewSiteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TechReviewSite.Models.TechReviewSiteContext";
        }

        protected override void Seed(TechReviewSite.Models.TechReviewSiteContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );


            // Seeding some data into the Categories Model
            /*public int ID (CATEGORY)
              string ItemName */

            context.Categories.AddOrUpdate(x => x.ID,
                new Category() { ID=1, ItemName="Communicator"},
                new Category() { ID=2, ItemName="Babel Fish"},
                new Category() { ID=3, ItemName="Shoe Phone"},
                new Category() { ID=4, ItemName="TARDIS Phone"}
                );

            //Seeding some data into the Reviews Model
            /*public int ID (REVIEWS)
            string Reviewer 
            string Title
            string Content 
            int NumStars 
            DateTime PublishDate - can't seem to get the format correct to seed this type of data
            */

            context.Reviews.AddOrUpdate(x => x.ID,
            new Review()
            {
                ID = 1, Reviewer = "Captain Kirk",                
                Title = "Beam Me Up, Scotty!",
                Content = "Federation issued, standard communicator. Pro:Matches my shirt. Con:Liable to interstellar interference.",
                NumStars = 4,              
                CategoryID = 1

            },

            new Review()
            {
                ID = 2,
                Reviewer = "Ford Prefect",               
                Title = "Don't Panic!",
                Content = "Amazing! That plaque there says its a Golgafrincham Ark Fleet Ship B Hold 7 Telephone Sanitiser Second Class.",
                NumStars = 5,
                CategoryID = 2
            },

            new Review
            {
                ID = 3,
                Reviewer = "Maxwell Smart",              
                Title = "Are you thinking what I'm thinking?",
                Content = "Oh great, I have gum on the bottom of my new shoes.",
                NumStars = 2,
                CategoryID = 3

            },

             new Review
             {
                 ID = 4,
                 Reviewer = "The Doctor",
                 Title = "Fantastic!",
                 Content = "What am I suupsed to do with a ringing phone? This isn't a real phone. It's not wired up to anything!",
                 NumStars = 5,
                 CategoryID = 4

             },

              new Review
              {
                  ID = 5,
                  Reviewer = "Dr. McCoy",
                  Title = "I'm a doctor, not an engineer!",
                  Content = "It's dead, Jim.",
                  NumStars = 1,
                  CategoryID = 1

              },

               new Review
               {
                   ID = 6,
                   Reviewer = "Arthur Dent",
                   Title = "What do you expect me to do with that?",
                   Content = "You know, it's at times like this, when I'm trapped in a Vogon airlock with a man from Betelgeuse, and about to die of asphyxiation in deep space that I really wish I'd listened to what my mother told me when I was young.",
                   NumStars = 3,
                   CategoryID = 2

               }
            );

            
    }
    }
}
