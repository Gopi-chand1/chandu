using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.Data
{
    public class Invitation
    {
        public int InvitationId { get; set; }
        public string Email { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

    }
}
