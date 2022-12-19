using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerLib
{
    public class TaskManager
    {

        public TaskManager()
        {
            controller = new ReferenceListController();
            _processesList = controller.ProcesssList;   // получаем список процессов
        }

        Dictionary<string, string> _processesList;      

        /// <summary>
        /// Список процессов
        /// </summary>
        /// <returns></returns>
        public List<string> GetProcessesList()
        {
            List<string> list = new List<string>();

            Process[] processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                list.Add($"{process.Id} \t{process.ProcessName}");
            }
            return list;
        }


        ReferenceListController controller;

        /// <summary>
        /// Запуска процесса
        /// </summary>
        public void ExecuteProcess(string processName, string arg)
        { 
            ProcessStartInfo procInfo = new ProcessStartInfo();

            string path = _processesList[processName];

            if (path == "")
            {
                Process.Start(processName);
            }
            else
            {
                if (File.Exists(path))
                {
                    if (arg != "")
                    {
                        Process.Start(path, arg);
                    }
                    else
                    {
                        Process.Start(path);
                    }
                }
                else
                {
                    throw new Exception("Не удалось запустить процесс!");
                }
            }            
        }

        /// <summary>
        /// Метод удаления процесса по ID
        /// </summary>
        /// <param name="id"></param>
        public void KillProcess(int id)
        {
            Process.GetProcessById(id).Kill();
        }

        /// <summary>
        /// Метод удаления процесса по Имени
        /// </summary>
        /// <param name="name"></param>
        public void KillProcess(string name)
        {
            Process[] processes = Process.GetProcesses(name);
            
            foreach(Process process in processes)
            {
                process.Kill();
            }
        }
    }
}
