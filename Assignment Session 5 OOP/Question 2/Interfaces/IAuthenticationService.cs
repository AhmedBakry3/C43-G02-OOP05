using Assignment_Session_5_OOP.Question_2.enums;

namespace Assignment_Session_5_OOP.Interfaces
{
    internal interface IAuthenticationService
    {
        //Signature For Methods
        public bool AuthenticateUser(string username , string password);
        public bool AuthorizeUser(string username, Roles requiredRole);
    }
}
