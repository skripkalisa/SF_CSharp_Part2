namespace CompositeExample.Components
{
    /// <summary>
    /// Общий интерфейс для всех компонентов древовидной структуры
    /// </summary>
    abstract class Component
    {
        public readonly string Name;
 
        protected Component(string name)
        {
            Name = name;
        }
      
        #region Методы для добавления / удаления подкомпонентов
      
        public abstract void Display();
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
      
        #endregion
    }
}