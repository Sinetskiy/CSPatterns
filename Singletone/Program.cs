using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Singletone
{
    class Program
    {
        static void Main(string[] args)
        {

            // Призван упростить владение, инициализацию, контроль времени жизни и доступ к элементам глобального состояния программы
            // Альтернатива глобальным переменным
            // Применяеться для работы с файлами конфигураций (чтение / запись) , для работы с соединением БД.

            var s1 = SingletonDoubleCheck.Instance;
            var s2 = SingletonNested.Instance;
            var s3 = SingletonLazy.Instance;
        }
    }

}
