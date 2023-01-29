using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public struct Person
    {
        /// <summary>
        /// ФИО
        /// </summary>
        public string Name;
        /// <summary>
        /// адрес человека
        /// </summary>
        public Adres Adres;
        /// <summary>
        /// номера телефонов
        /// </summary>
        public PhoneNumber PNumber;
        public Person(string Name, Adres Adres, PhoneNumber PNumber)
        {
            this.Name = Name;
            this.Adres = Adres;
            this.PNumber = PNumber;
        }
    }
}
