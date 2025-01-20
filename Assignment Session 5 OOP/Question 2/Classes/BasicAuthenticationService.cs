using Assignment_Session_5_OOP.Interfaces;
using Assignment_Session_5_OOP.Question_2.enums;


namespace Assignment_Session_5_OOP.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        #region Properites
        public string? Username { get; set; }
        public string? Password { get; set; }
        public Roles Role { get; set; }

        #endregion

        #region Constructor
        public BasicAuthenticationService(string username, string password , Roles role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
        #endregion

        #region Methods
        public bool AuthenticateUser(string username, string password)
        {
            if (Username == username && Password == password)
                return true;
            else 
                return false;
        }

        public bool AuthorizeUser(string username, Roles requiredRole)
        {
            if (Username == username)
                return Role == requiredRole;
            else
                return false;
        }

        #endregion
    }
}
