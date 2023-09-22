using DP_Notification.User_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Notification
{
    internal interface IChannel
    {
        void SendMessage(string subject, string messageBody, User user);
    }
}
