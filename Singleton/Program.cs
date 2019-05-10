using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Begin();

            PrintMessage(InitializeStraightAway.Instance);

            PrintMessage(LazilyInitialize.Instance);
            
            PrintMessage(LazilyInitializeIdiomatically.Instance);
        }

        private static void Begin()
        {
            Console.WriteLine("Players ready?");
            Console.WriteLine();
            Console.WriteLine($"{InitializeStraightAway.Name} ready!");
            Console.WriteLine($"{LazilyInitialize.Name} ready!");
            Console.WriteLine($"{LazilyInitializeIdiomatically.Name} ready!");
            Break();
        }

        private static void PrintMessage(Speak speaker)
        {
            speaker.GetMessage();
            Break();
        }

        private static void Break()
        {
            Console.WriteLine("-------------------------");
        }
    }
    
    class InitializeStraightAway : Speak
    {
        private static readonly InitializeStraightAway instance;
        
        private InitializeStraightAway() { }

        static InitializeStraightAway()
        {
            instance = new InitializeStraightAway();
            Console.WriteLine($"Initialized {Name}");
        }

        public static string Name => nameof(InitializeStraightAway);

        public static InitializeStraightAway Instance
        {
            get
            {
                Console.WriteLine($"Getting instance of {Name}");
                return instance;
            }
        }

        public void GetMessage()
        {
            Console.WriteLine($"Hello from {Name}!");
        }
    }

    class LazilyInitialize : Speak
    {
        private static LazilyInitialize instance;
        
        private LazilyInitialize() { }

        public static string Name => nameof(LazilyInitialize);

        public static LazilyInitialize Instance
        {
            get
            {
                // if there must only be one, see: https://csharpindepth.com/articles/singleton
                if (instance is null)
                {
                    Console.WriteLine($"Initialized {Name}");
                    instance = new LazilyInitialize();
                }
                
                Console.WriteLine($"Getting instance of {Name}");
                return instance;
            }
        }
        
        public void GetMessage()
        {
            Console.WriteLine($"Hello from {Name}!");
        }
    }

    class LazilyInitializeIdiomatically : Speak
    {
        private static LazilyInitializeIdiomatically instance;
        
        private LazilyInitializeIdiomatically() { }
        
        public static string Name => nameof(LazilyInitializeIdiomatically);

        public static LazilyInitializeIdiomatically Instance
        {
            get
            {
                Console.WriteLine($"Getting instance of {Name}");
                
                return LazyInitializer.EnsureInitialized(ref instance, () =>
                {
                    Console.WriteLine($"Initialized {Name}");
                    return new LazilyInitializeIdiomatically();
                });
                // Alternatively, use the Lazy<T> type
            }
        }
        
        public void GetMessage()
        {
            Console.WriteLine($"Hello from {Name}!");
        }
    }
    
    interface Speak
    {
        void GetMessage();
    }
}