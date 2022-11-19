namespace Singleton
{
    /// <summary>
    /// Default way not thread safe 
    /// We should use Lazy that guarantees thread safe
    /// </summary>
    public class Logger
    {
        // private static Logger? _instance;

        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());


        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;

                // if (_instance == null)
                // {
                //     _instance = new Logger();
                // }

                // return _instance;
            }
        }



        /// <summary>
        /// Client cannot instantiated  but 
        /// it can be sub classed
        /// </summary>
        protected Logger()
        {

        }


        public void Log(string message)
        {
            Console.WriteLine($"Message to log:{message}");
        }
    }
}