using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Notification.User_Data
{
    internal class User
    {
        public string Name { get; set; }

        public string Channel { get; set; }

        public string ChannelType { get; set; }

        public User(string name, string channel, string channelType)

        {

            this.Channel = channel;

            this.Name = name;

            this.ChannelType = channelType;

        }
    }
}
