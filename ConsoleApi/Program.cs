using TaskManagerLib;

class Program
{
    static string commandName = "";
    static void Main()
    {        
        string command = "";

        while(true)
        {
            Console.WriteLine("Введите команду: ");
            command = Console.ReadLine();
        }
    }

    void Execute(string commandString)
    {
        /*
        switch(commandName)
        {
            case:


        } */
    }

    void MyParse(string commandString)
    {
            // разделяете на команду и аргумент
            // start>notepad                        - вызов метода запуска, что запускаем
            // start>google>www.youtube.com         - вызов метода запуска, что запускаем, страничка
            // delref>Winword                       - вызов метода удалить ярлык, что удалить
            // addref>Winword>C:\..\winword.exe     - вызов метода добавить ярлык, что добавить, адрес exe
            // kill>25                              - удалить процесс по ID, ID = 25 (преобразуется в Int?) 
            // kill>notepad                         - удалить процесс по name, (преобразуется в Int?)== False -> name = notepad

            commandName = "какая-то команда";
    }

    // Методы для каждой команды:
    // 1. Запустить процесс
    // 2. Удалить по ID
    // 3. Удалить по имени
    // 4. Добавить ярлык (имя процесса и путь к нему в файл)
    // 5. Удалить ярлык (имя процесса и путь к нему из файла)
}

