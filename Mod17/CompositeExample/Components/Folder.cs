using System;
using System.Collections.Generic;
 
namespace CompositeExample.Components
{
    /// <summary>
    /// Представляет папку - компонент, который может содержать другие компоненты
    /// Здесь реализован механизм для добавления / удаления новых компонентов
    /// </summary>
    class Folder : Component
    {
        private readonly List<Component> _subFolders = new();
        public Folder(string name)
            : base(name)
        {}
        // Метод для добавления новых подкомпонентов
        public override void Add(Component component)
        {
            _subFolders.Add(component);
            Console.WriteLine($"В {Name} добавлено: {component.Name} ");
        }
        // Метод для удаления
        public override void Remove(Component component)
        {
            _subFolders.Remove(component);
            Console.WriteLine($"Из {Name} удалено: {component.Name} ");
        }
        // Метод для отображения нижестоящих компонентов
        public override void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"{Name} содержит:");
            foreach (Component component in _subFolders)
                component.Display();
        }
    }
}