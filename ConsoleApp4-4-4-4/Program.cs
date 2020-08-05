using System;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Threading.Tasks;


namespace ConsoleApp4_4_4_4
{
    class Myfile
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Myclass
    {
        public int namber;
        public string NameBox;

        public void Show()
        {
            Console.WriteLine($" Мне {namber} лет");
            Console.WriteLine($"Напиши {NameBox}");
        }
    }
    class Person  
    {
        public string name;
        public int age = 20;

        public void Get()
        {
            Console.WriteLine($"Имя {name} возраст {age}");
        }
    }
    class Program
    {
        static void Nattext()
        {
            WebClient web = new WebClient();
            web.DownloadFile("", "banner.jpeg");
            Console.WriteLine("Файл загружен");
        }


        
        static void Main(string[] args)
        {
            Myfile fred = new Myfile { Name = "Tom", Age = 35 };
            string json = JsonSerializer.Serialize<Myfile>(fred);
            Console.WriteLine(json);



            int result = Sum(100, 15);
            Console.WriteLine(result);
            Console.ReadKey();

            static int Sum(int x, int y)
            {
                return x + y;
            }

            static int NNam() // метод со значение int
            {
                int a = 5;
                return a;
            }

            Console.WriteLine(NNam());
            string txt = "Мой текст ";
            txt += "Новый текст";

            Myclass Bi = new Myclass(); // создание обьекта 
            Person tom = new Person();
            tom.Get();

            
            Bi.namber = 12; // Обращение к переменным в классе 
            Bi.NameBox = "Покажет текс который я написал";
            Bi.Show();

            tom.name = "Tom";
            tom.age = 34;
            tom.Get();
            Console.WriteLine(txt.Length + "Стока символов в предложении " );


            Console.WriteLine("Нажмите Enter для запроса!");
            Console.WriteLine("Введите ИНН");
            string INN = Console.ReadLine();
            
            string link = "https://api-fns.ru/api/egr?req="+INN+"&key=20f0f808f3c7bdbcba5460e10f5068684e484ceb";
            

            WebRequest request = WebRequest.Create(link); //2722083578
            WebResponse response = request.GetResponse();
           using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    line = reader.ReadLine();

                    /*while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        
                    }*/
                }
            }

            

            response.Close();
            Console.WriteLine("Запрос выполнен");
            /*
            string text = Console.ReadLine();
            using (FileStream fstream = new FileStream($"note.txt", FileMode.OpenOrCreate))
            {
                // преобразуем строку в байты
               byte[] array = System.Text.Encoding.Default.GetBytes(text);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }*/
            
                // сохранение данных
               
            
            Console.Read();
            
        }
    }
    

}
