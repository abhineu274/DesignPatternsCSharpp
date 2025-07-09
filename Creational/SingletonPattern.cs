namespace DesignPatternsCSharpp.Creational
{
    //Singleton Pattern
    public sealed class Logger
    {
        public static readonly Logger Instance = new Logger();
        private Logger() // Private constructor to prevent instantiation
        {
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log: {message}");
        }
    }

    public class SingletonPattern
    {
        public static void Run()
        {
            Console.WriteLine("Running Singleton Pattern Example:");
            Logger logger = Logger.Instance;
            logger.Log("Running Singleton Pattern!");
        }
    }
}

