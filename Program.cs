using System.IO;
using System.Collections.Generic;
using System.Text;
namespace HomeWork6
{
    class Programm
    {

        static void Main(string[] args)
        {
         
            
                
                Console.WriteLine("Выберете что нужно сделать с файлом: Записать(введите з), Прочитать(введите ч)");
                if(Console.ReadLine() == "1")
                {
                    Write();
                }
                else
                {
                    Read();
                }
            
        }

        static private void Write() 
        {
            int id = 0;
            char key = 'Д';
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Public\Documents\Workers.txt", true, Encoding.Unicode))
            {
                do
                {
                    string info = string.Empty;
                    id += 1;
                    Console.WriteLine($"Id создаваемого сотрудника: {id}");
                    info += $"{id}#";

                    string now = DateTime.Now.ToString();
                    Console.WriteLine($"Время добавления записи: {DateTime.Now.ToShortDateString()}");
                    info += $"{now}#";

                    Console.WriteLine("Введите Фамилию Имя и Отчествро");
                    info += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите возраст сотрудника");
                    info += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите рост сотрудника");
                    info += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите дату рождения в формате день.месяц.год");
                    info += $"{Console.ReadLine()}#";

                    Console.WriteLine("Введите место рождения");
                    info += $"{Console.ReadLine()}";
                    streamWriter.WriteLine(info);
                    Console.WriteLine("Продожить н/д"); key = Console.ReadKey(true).KeyChar;

                } while (char.ToLower(key) == 'д');
                streamWriter.Close();
            }
            

        }

        static private void Read()
        {
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Public\Documents\Workers.txt", Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"{"id",15} {"дата записи",15} {"Ф.И.О",30} {"Возраст",15} {"Рост",15} {"Дата рождения",15} {"Место рождения",15}");

                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0],15} {data[1],15} {data[2],30} {data[3],15} {data[4],15} {data[5],15} {data[6],15}");
                }
                streamReader.Close();
            }
        }

        
    }
}