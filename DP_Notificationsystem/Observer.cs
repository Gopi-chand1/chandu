using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DP_Notification

{
    // Observer interface
    public interface IObserver
    {
        void Update(string message);
    }

    // Concrete observers
    public class EmailObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Sending email notification: " + message);
        }
    }

    public class SmsObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Sending SMS notification: " + message);
        }
    }

    // Subject interface
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers(string message);
    }

    // Concrete subject
    public class NotificationSystem : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

}
