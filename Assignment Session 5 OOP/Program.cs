using Assignment_Session_5_OOP.Classes;
using Assignment_Session_5_OOP.Interfaces;
using Assignment_Session_5_OOP.Question_2.enums;
using Assignment_Session_5_OOP.Question_3.Classes;


namespace Assignment_Session_5_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01: Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.

            //Creating Instance of Circle Class
            Circle circle = new Circle() { Radius = 10 };
            Console.WriteLine($"Area of Circle = {circle.DisplayShapeInfo()}"); //Area of Circle = 314.1592653589793

            //Creating Instance of Rectangle Class
            Rectangle rectangle = new Rectangle() { Length = 10, Width = 20 };
            Console.WriteLine($"Area of Rectangle = {rectangle.DisplayShapeInfo()}"); //Area of Rectangle = 200
            #endregion

            #region Question 2
            //In this example, 
            //1 - We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            //2-In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.It returns true if the user is authorized and false otherwise.
            //3-In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference..
            //This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            //Creating instance of BasicAuthenticationService
            IAuthenticationService authService = new BasicAuthenticationService("Ahmed", "Password", Roles.Admin);

            // Test authentication
            string username = "Ahmed";
            string password = "Password";

            if (authService.AuthenticateUser(username, password))
            {
                Console.WriteLine("User authenticated successfully"); //User authenticated successfully

                // Test authorization 
                Roles requiredRole = Roles.Admin;
                if (authService.AuthorizeUser(username, requiredRole))
                {
                    Console.WriteLine($"{username} is authorized as {requiredRole}");//Ahmed is authorized as Admin
                }
                else
                {
                    Console.WriteLine($"{username} is not authorized as {requiredRole}");
                }
            }
            else
            {
                Console.WriteLine("Authentication failed");
            }


            #endregion
            #region Question 3
            //1 - we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.
            //2-We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.
            //3-In each implementation, we provide the logic to send notifications through the respective communication channel:
            //4-The EmailNotificationService class simulates sending an email by outputting a message to the console.
            //5-The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            //6-The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            //7-In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            //This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel.



            //Creating instance of EmailNotificationService
            EmailNotificationService emailNotificationService = new EmailNotificationService();
            emailNotificationService.SendNotification("Ahmed@gmail.com", "Hello Ahmed"); //Sending email to Ahmed@gmail.com: Hello Ahmed

            //Creating instance of SmsNotificationService
            SmsNotificationService smsNotificationService = new SmsNotificationService();
            smsNotificationService.SendNotification("01155325382", "Hello Number [01155325382] [Mr Ahmed]"); //Sending SMS to 01155325382: Hello Number [01155325382] [Mr Ahmed]


            //Creating instance of PushNotificationService
            PushNotificationService pushNotificationService = new PushNotificationService();
            pushNotificationService.SendNotification("Ahmed", "Push notification for Ahmed"); //Sending a push notification to Ahmed: Push notification for Ahmed


            #endregion

        }
    }
}
