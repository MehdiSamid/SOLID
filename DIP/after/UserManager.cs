namespace DIP.after
{
    public class UserManager
    {
        private ILogger logger;

        public UserManager(ILogger logger)
        {
            this.logger = logger;
        }

        public void RegisterUser(string username)
        {
            // Register user logic...

            // Log the registration
            logger.Log($"User '{username}' registered successfully.", LogLevel.Info);
        }
    }

}
