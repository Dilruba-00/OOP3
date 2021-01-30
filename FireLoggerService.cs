using System;

namespace OOP3
{
    class FireLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya logandı");
        }
    }
}
