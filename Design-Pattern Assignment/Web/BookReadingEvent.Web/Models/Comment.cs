using System;

namespace BookReadingEvent.Web.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Comment1 { get; set; }
        public Nullable<int> EventID { get; set; }
        public string Email{ get; set; }
    }
}
