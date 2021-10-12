using System;

namespace FactoryMethodRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string messageText = "Ваш номер заказа - 83456";
 
            // Отправляем заказ по SMS
            MessageSender sender = new SmsMessageSender("+79856455320");
            sender.Send(messageText);
       
            // Отправляем заказ по e-mail
            sender = new EmailMessageSender("orders@myshop.com");
            sender.Send(messageText);
        }
    }
}