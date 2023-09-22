using System;



namespace  DP_Notification

{
    class Program

    {
        static void Main(string[] args)

        {

            Console.WriteLine(" Notification Channel Number");
            Console.WriteLine(" Press 1 for Email");
            Console.WriteLine(" Press 2 for SMS");
            int channelCode = int.Parse(Console.ReadLine());

            string channel = "";

            switch (channelCode)

            {

                case 1:

                    channel = "Email";

                    break;

                case 2:

                    channel = "SMS";

                    break;

                default:

                    Console.WriteLine("Invalid channel code.");

                    return;

            }

            Console.WriteLine(" Subject:");

            string subject = Console.ReadLine();

            Console.WriteLine("Body of Message :");

            string messageBody = Console.ReadLine();

            DP_Notification.Facade facade = new DP_Notification.Facade();

            facade.SendNotification(channel, subject, messageBody);

         
            

            Console.WriteLine("Notification sent successfully!");

            // Create instances of observers
            IObserver emailObserver = new EmailObserver();
            IObserver smsObserver = new SmsObserver();

            // Create the notification system
            NotificationSystem notificationSystem = new NotificationSystem();

            // Register observers with the notification system
            notificationSystem.RegisterObserver(emailObserver);
            notificationSystem.RegisterObserver(smsObserver);

            // Notify observers
            string message = "Mail or SMS MORE PROIRITY!";
            notificationSystem.NotifyObservers(message);

            // Unregister one observer
            notificationSystem.RemoveObserver(smsObserver);

            // Notify observers again
            string message2 = "Another notification!";
            notificationSystem.NotifyObservers(message2);
        }

    }

}


