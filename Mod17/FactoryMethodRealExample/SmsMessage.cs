using System;
 
namespace FactoryMethodRealExample
{
    class SmsMessage : Message
    {
        public SmsMessage()
        {
            Console.WriteLine("SMS отправлено");
        }
    }
}