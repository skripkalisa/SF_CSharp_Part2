namespace FactoryMethodRealExample
{
    /// <summary>
    /// Абстрактный класс для рассылок
    /// </summary>
    abstract class MessageSender
    {
        public string From { get; set; }
        public MessageSender (string @from)
        {
            From = @from;
        }
      
        // Фабричный метод
        abstract public Message Send(string text);
    }
}