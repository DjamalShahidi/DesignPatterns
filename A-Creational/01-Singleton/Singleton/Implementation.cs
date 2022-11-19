namespace Singleton
{
    public class Logger
    {
        private static Logger? _instance;

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
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