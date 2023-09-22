using DP_Notification.User_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Notification
{
    internal class Email:IChannel
    {
        public void SendMessage(string subject, string messageBody, User user)

        {

            Console.WriteLine($"sending Email to {user.Name} \n subject: {subject} \n message :{messageBody} \n");

        }
    }
}
