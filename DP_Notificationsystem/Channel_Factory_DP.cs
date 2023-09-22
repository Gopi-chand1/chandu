using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Notification
{
    internal class Channel_Factory_DP
    {
        public IChannel CreateChannel(string channel)
        {

            if (channel.ToLower() == "email")
            {

                return new Email();

            }

            else if (channel.ToLower() == "sms")
            {

                return new SMS();

            }

            else
            {

                return null;

            }

        }
    }
}
