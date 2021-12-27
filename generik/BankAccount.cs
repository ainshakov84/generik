using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generik
{
    class BankAccount<T>
    {
        public T NumAccoun { get; set; }
        public double SumAccoun { get; set; }
        public string UserName { get; set; }
    
        public BankAccount(T numAccount, double sumAccount, string userName)
        {
            this.NumAccoun = numAccount;
            this.SumAccoun = sumAccount;
            this.UserName = userName;

        }


        public string GetInfo()
        {
            return $"{NumAccoun} {SumAccoun} {UserName}";
        }
    }
}


