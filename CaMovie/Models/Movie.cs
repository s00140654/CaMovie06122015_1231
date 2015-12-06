using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int ReleaseYear { get; set; }
        public IList<Casting> Castings { get; set; }
    }
}