using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE04.Models
{
    public class Calculadora
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }
        public int Soma(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Soma(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
}