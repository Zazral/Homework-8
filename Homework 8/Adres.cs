using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    public struct Adres
    {
        /// <summary>
        /// улица
        /// </summary>
        public string Street;
        /// <summary>
        /// номер дома
        /// </summary>
        public int House;
        /// <summary>
        /// номер квартиры
        /// </summary>
        public int Flat;
        /// <summary>
        /// создание адреса
        /// </summary>
        /// <param name="Street">название улицы</param>
        /// <param name="House">номер дома</param>
        /// <param name="Flat">номер квартиры</param>
        public Adres(string Street, int House, int Flat)
        {
            this.Street = Street;
            this.House = House;
            this.Flat = Flat;
        }
    }
}
