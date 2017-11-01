using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSiteMVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "What were the dates of your travel?")]
        public DateTime DatesOfTravel { get; set; }

        [Display(Name = "How many travelers were in your party?")]
        public int NumofTravelers { get; set; }

        [Display(Name = "Where did you stay while traveling?")]
        public string Lodging { get; set; }

        [Display(Name = "Did you travel to a specific event or to celebrate an occasion? n/If so, please let us know:")]
        public string Event { get; set; }

        [Display(Name = "Please check the box if you would return to this destination.")]
        public bool TravelAgain { get; set; }

        [MaxLength(1000), Display(Name = "Thank you for providing the information above. Now, Tell Us More!")]
        public string UserReview { get; set; }

        [ForeignKey("Destination")]
        public int DestinationID { get; set; }
        public virtual Destination Destination { get; set; }

    }

    internal class KeyAttribute : Attribute
    {
    }
}