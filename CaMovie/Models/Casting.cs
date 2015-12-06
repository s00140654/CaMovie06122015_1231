using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaMovie.Models
{
    public class Casting

    {
        public int ID { get; set; }
        public int ActorID { get; set; }
        public int MovieID { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }

    }
}