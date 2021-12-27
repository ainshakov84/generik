using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generik__ввод_данных_с_класса
{
    class BankAccount<T>
    {
        public T NumAccoun { get; set; }
        public double SumAccoun { get; set; }
        public string UserName { get; set; }

        public string GetInfo()
        {
            return $"номер банковского счета {NumAccoun}\nсумма на счете {SumAccoun}\nсчет принадлежит {UserName}";
        }
        public void Input()
        {
            Console.WriteLine("Введите  номер счета в банке");
            string numAccoun = Console.ReadLine();
            NumAccoun = (T)Convert.ChangeType(numAccoun, typeof(T));
            Console.WriteLine("Введите номер счета");
            SumAccoun = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя");
            UserName = (Console.ReadLine());
        }
    }
}
