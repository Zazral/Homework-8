using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public struct PhoneNumber
    {
        /// <summary>
        /// мобильный телефон
        /// </summary>
        public long MPhone;
        /// <summary>
        /// домашний телефон
        /// </summary>
        public long FPhone;
        /// <summary>
        /// создание телефонов
        /// </summary>
        /// <param name="MPhone">мобильный телефон</param>
        /// <param name="FPhone">домашний телефон</param>
        public PhoneNumber(long MPhone, long FPhone)
        {
            this.MPhone = MPhone;
            this.FPhone = FPhone; 
        }
    }
}
