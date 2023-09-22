using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Models
{
    public class EventModel
    {
        public string UserId { get; set; }
        public int EventId { get; set; }  

        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Event Date")]
        [DataType(DataType.Date)]
        /*[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]*/
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please Enter Location")]
        public string Location { get; set; }

        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

       
        public string Type { get; set; }

        [Display(Name = "Duration (in hours)")]
        [Range(0, 4)]
        public int? Duration { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(500)]
        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }

        [Display(Name = "Invite Others")]
        public string InviteByEmail { get; set; }

        public int Count { get; set; }


        [Display(Name = "Add a Comment")]
        public string CommentAdded { get; set; }
    }
}
