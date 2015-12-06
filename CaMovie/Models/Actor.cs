using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CaMovie.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        //[Display(Name = "ScreenName")]
        //public ScreenName screenName { get; set; }
        public DateTime Dob { get; set; }
        public virtual ICollection<Casting> Castings { get; set; }
    }
}