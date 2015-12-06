using CaMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaMovie.DAL
{
    public class MovieInitialiser : System.Data.Entity.DropCreateDatabaseIfModelChanges<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {

            var movies = new List<Movie>()
        {

            new Movie {Name  = "Jaws", ReleaseYear = 1978},
            new Movie {Name  = "ET", ReleaseYear = 1982},
            new Movie {Name  = "AI", ReleaseYear = 2001},
            new Movie {Name  = "It", ReleaseYear = 1980},
            new Movie {Name  = "She", ReleaseYear = 1982}
        };


            movies.ForEach(m => context.Movies.Add(m));
            context.SaveChanges();
            List<Actor> actors = new List<Actor>()
        {
            new Actor {Name = "Robert Shaw", Dob = DateTime.Parse("01/01/1960")},
            new Actor {Name = "Roy Schnider",Dob = DateTime.Parse("01/01/1960") },
            new Actor {Name = "Drew Barrymore",Dob = DateTime.Parse("01/01/1960" ) },
            new Actor {Name = "Harry Anderson" ,Dob = DateTime.Parse("01/01/1960") },
            new Actor {Name = "Brendan Glesson" ,Dob = DateTime.Parse("01/01/1960") },
            new Actor {Name = "William Hurt",Dob = DateTime.Parse("01/01/1960" ) },
            new Actor {Name = "David Goss",Dob = DateTime.Parse("01/01/1960" ) },
            new Actor {Name = "Richard Dreyfuss",Dob = DateTime.Parse("01/01/1960" ) },
            new Actor {Name = "Robert Shaw",Dob = DateTime.Parse("01/01/1960" ) },
            new Actor {Name = "Jude Law",Dob = DateTime.Parse("01/01/1960")  },
            new Actor {Name = "Tommy Lee Wallace" ,Dob = DateTime.Parse("01/01/1960") },
            new Actor {Name = "Tommy Lee" ,Dob = DateTime.Parse("01/01/1960") }
        };

            actors.ForEach(a => context.Actors.Add(a));
            context.SaveChanges();
        

        var casting = new List<Casting>(){

            new Casting {MovieID = 1, ActorID = 1 },
             new Casting {MovieID = 2, ActorID = 3 },
              new Casting {MovieID = 1, ActorID = 4 },
               new Casting {MovieID = 3, ActorID = 5 },
                new Casting {MovieID = 3, ActorID = 6 },
                 new Casting {MovieID = 3, ActorID = 10 },
                  new Casting {MovieID = 5, ActorID = 11 },
                   new Casting {MovieID = 4, ActorID = 7 }
            };
            
            casting.ForEach(c=> context.Castings.Add(c));
            context.SaveChanges();

        }
    }
}

