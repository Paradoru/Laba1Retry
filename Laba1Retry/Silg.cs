using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab1Retry
{
    internal class Silg
    {
        public double R { get; set; } // Скорость м/сек
        public double T { get; set; } //Время в минутах
        public Silg(double r, double t)
        {
            R = r;
            T = t;
        }
        public double Rashet()
        {
            return R * 60 * T;
        }
    }

}