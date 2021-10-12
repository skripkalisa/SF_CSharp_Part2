namespace FactoryMethodRealExample
{
    /// <summary>
    /// Класс для рассылки SMS
    /// </summary>
    class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string @from) : base(@from)
        { }
        public override Message Send(string text)
        {
            return new SmsMessage();
        }
    }
}