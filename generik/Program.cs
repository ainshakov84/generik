using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета в банке");
            int numAccounInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер счта");
            double sumAccoun = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя");
            string userName = (Console.ReadLine());
            BankAccount<int> BankAccount1 = new BankAccount<int> (numAccounInt, sumAccoun, userName);
            Console.WriteLine(BankAccount1.GetInfo());

            Console.WriteLine("Введите строковый номер счета в банке");
            string numAccounString = Console.ReadLine();
            Console.WriteLine("Введите номер счета");
            sumAccoun = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите имя"); 
            userName = Console.ReadLine();
            BankAccount<string> bankAccount2 = new BankAccount<string>(numAccounString, sumAccoun, userName)  ;
            Console.WriteLine(bankAccount2.GetInfo()); 
        }
    }
}
