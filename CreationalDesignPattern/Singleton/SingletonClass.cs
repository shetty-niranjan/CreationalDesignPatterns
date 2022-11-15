namespace CreationalDesignPattern.Singleton
{
    public class SingletonClass
    {
        private static int count = 0;
        private volatile static SingletonClass uniqueInstance;
        private static object syncRoot = new Object();

        private double currentValue =
            0.015;

        public double CurrentValue
        {
            get
            {
                return currentValue;
            }
            set
            {
                currentValue = value;
            }
        }

        private SingletonClass()
        { }

        public static SingletonClass GetInstance()
        {
            try
            {
                if (uniqueInstance == null)
                {
                    lock (syncRoot)
                    {
                        count++;
                        uniqueInstance ??= new SingletonClass();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return uniqueInstance;
        }

        public int GetInstanceCount()
        {
            return count;
        }
    }
}
