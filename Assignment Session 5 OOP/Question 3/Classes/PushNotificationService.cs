namespace Assignment_Session_5_OOP.Question_3.Classes
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine($"Sending a push notification to {recipient}: {message}");

        }
    }
}
