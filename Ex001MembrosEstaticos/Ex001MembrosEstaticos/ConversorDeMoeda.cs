using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001MembrosEstaticos
{
    internal class ConversorDeMoeda
    {
        static double Iof = 0.6;

        public static double Conversor(double d, double r)
        {
            double cotacao = d * r;
            return cotacao + cotacao * 6 / 100;
        }

    }
}
