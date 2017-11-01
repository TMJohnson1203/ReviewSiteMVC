using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteMVC.Models
{
    public class Destination
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Destination")]
        public string UserDestination { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}