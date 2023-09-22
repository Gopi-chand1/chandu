using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Data
{
    public class Event
    {
        public string UserId { get; set; }
        public int EventId { get; set; }  /* int? */
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public string Type { get; set; }
        public int? Duration { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public string InviteByEmail { get; set; }

        /* public virtual User User { get; set; }*/
        public int Count { get; set; }


        public virtual ICollection<Invitation> Invitations { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }


    }
}
