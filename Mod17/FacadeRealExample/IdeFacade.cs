using FacadeRealExample.Components;
 
namespace FacadeRealExample
{
    /// <summary>
    /// Фасад, скрывающий механизм работы IDE с компонентами,
    /// Использующимися при разработке
    /// </summary>
    class IdeFacade
    {
        readonly Editor _editor;
        readonly Compiller _compiler;
        readonly Runtime _runtime;
        public IdeFacade(Editor editor, Compiller compiler, Runtime runtime)
        {
            _editor = editor;
            _compiler = compiler;
            _runtime = runtime;
        }
      
        // Вы ввели код, IDE выполняет с ним примерно следующие действия перед запуском:
        public void Start(string sourceCode)
        {
            // Пишет в текстовый файл
            _editor.Write(sourceCode);
          
            // Сохраняет текстовый файл
            _editor.Save();
          
            // Вызывает компилятор
            _compiler.Compile();
          
            // Запускает выполнение скомпилированного приложения в среде CLR
            _runtime.Execute();
        }
      
        // в конце IDE может остановить выполнение, вызвав команду в среде выполнения
        public void Stop()
        {
            _runtime.Finish();
        }
    }
}