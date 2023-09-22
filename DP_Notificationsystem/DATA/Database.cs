using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Notification.User_Data
{
    internal class Database
    {
        private static Database? instance = null;

        private List<User> users;



        private Database()

        {

            // Initialize and populate the user list (mocked data)

            users = new List<User>{

       new User("Gopichand","gopichand@gmail.com","email"),

       new User("Teja","8986879845","sms"),

       new User("Bhaskar","8887776665","sms"),

       new User("Smiley","null","null"),

       new User("Jagan","jagan11@gmail.com","email"),

            };



        }

        public static Database GetInstance()

        {

            if (instance == null)

            {

                instance = new Database();

            }

            return instance;

        }



        public List<User> GetUserList()

        {

            return users;

        }
    }
}
