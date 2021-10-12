using System;
 
namespace FactoryMethodRealExample
{
    class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("e-mail отправлен");
        }
    }
}