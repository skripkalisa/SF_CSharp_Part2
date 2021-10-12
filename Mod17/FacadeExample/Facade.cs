namespace FacadeExample
{
    public class SystemOne
    {
        public void S1Method()
        {}
    }
 
    public class SystemTwo
    {
        public void S2Method()
        {}
    }
 
    public class SystemThree
    {
        public void S3Method()
        {}
    }
    /// <summary>
    /// Фасад, скрывающий от клиентского кода взаимодействие с системами
    /// </summary>
    public class Facade
    {
        private SystemOne _systemOne;
        private SystemTwo _systemTwo;
        private SystemThree _systemThree;
  
        /// <summary>
        ///  Метод-конструктор принимает системы на вход
        /// </summary>
        public Facade(SystemOne systemOne, SystemTwo systemTwo, SystemThree systemThree)
        {
            _systemOne = systemOne;
            _systemTwo = systemTwo;
            _systemThree = systemThree;
        }
  
        // методы для клиента, через которые он взаимодействует с системами
        public void OperationOne()
        {
            _systemOne.S1Method();
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
        public void OperationTwo()
        {
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
    }
    
    
}
