using DP_Notification.User_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DP_Notification
{
    internal class Facade
    {
        Database userDatabase = Database.GetInstance();

        private List<User> users { get; set; }

        public Facade()
        {
            users = userDatabase.GetUserList();

        }

        public void SendNotification(string channel, string subject, string messageBody)
        {

            foreach (var user in users)
            {

                // NotificationChannelFactory channelType=new NotificationChannelFactory();

                IChannel channelType = new Channel_Factory_DP().CreateChannel(channel);

                if (channel.ToUpper() == "EMAIL" && user.Channel.Contains("@"))
                {

                    channelType.SendMessage(subject, messageBody, user);

                }
                else if (channel.ToUpper() == "SMS" && user.Channel.All(char.IsDigit))
                {
                    channelType.SendMessage(subject, messageBody, user);
                }
                else
                {
                  continue;
                }
            }
        }
    }
}


