namespace design_patterns.Singleton
{
    // Sealed class is defined to prevent inheriting this class
    // from other classes
    public sealed class SingletonPattern
    {
        public static SingletonPattern SingletonInstance;
        public static object padLock = new object();


        private SingletonPattern()
        {
            // private constructor is used to prevent other classes to make
            // object of this class
        }

        public static SingletonPattern GetSingleInstance()
        {
            // Double checking lock
            if (SingletonInstance == null)
            {
                // applying lock so that only one thread can access the 
                // critical section of code at a time
                lock (padLock)
                {
                    if (SingletonInstance == null)
                    {
                        SingletonInstance = new SingletonPattern();
                    }
                }
            }
            return SingletonInstance;
        }
    }
}
