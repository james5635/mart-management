namespace mart_management
{
    /// <summary>
    /// Singleton Pattern: Ensures a single DatabaseManager instance
    /// controls all DbContext creation throughout the application.
    /// </summary>
    public sealed class DatabaseManager
    {
        private static DatabaseManager? _instance;
        private static readonly object _lock = new object();

        // Private constructor prevents external instantiation
        private DatabaseManager() { }

        /// <summary>
        /// Thread-safe singleton accessor using double-checked locking.
        /// </summary>
        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseManager();
                        }
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Creates a new MartManagementContext instance.
        /// All database access should go through this method.
        /// </summary>
        public MartManagementContext CreateContext()
        {
            return new MartManagementContext();
        }
    }
}
