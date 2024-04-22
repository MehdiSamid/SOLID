namespace DIP.before
{
    public class UserManager
    {
        private Logger logger;

        public UserManager()
        {
            this.logger = new Logger();
        }

        public void RegisterUser(string username)
        {
            // Register user logic...

            // Log the registration
            logger.Log($"User '{username}' registered successfully.", LogLevel.Info);
        }
    }

}
