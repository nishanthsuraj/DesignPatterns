namespace CodingInterviewSolutions.DesignPatterns.SingletonPattern
{
    internal class SingletonDemo
    {
        private int data;

        private SingletonDemo()
        {
        }

        private static readonly Lazy<SingletonDemo> lazy
            = new Lazy<SingletonDemo>(() => new SingletonDemo());

        public static SingletonDemo Instance
        {
            get
            {
                return lazy.Value;
            }
        }

        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                if (data != value)
                {
                    data = value;
                }
            }
        }
    }
}
