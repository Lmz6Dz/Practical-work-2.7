using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Иванов Иван Иванович";

            byte age = 33;

            string email = "ivan.ivanov@skillbox.ru";

            float balprog = 66.6f;

            float balmat = 99.9f;

            float balfiz = 77.7f;

            string pattern = "Ф.И.О: {0}\nВозраст: {1}\ne-mail: {2}\nБаллы по программированию: {3}\nБаллы по математике: {4}\nБаллы по физике: {5}";

            Console.WriteLine(pattern, 
                                FullName,
                                age,
                                email,
                                balprog,
                                balmat,
                                balfiz);

            Console.ReadKey();

        }
    }
}
