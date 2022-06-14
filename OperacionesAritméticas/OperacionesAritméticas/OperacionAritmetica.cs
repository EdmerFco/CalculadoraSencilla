using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
        public struct OperacionAritmeticas

        {
            public OperacionAritmeticas(decimal num1, decimal num2, tipoOperacion oper)
            {
                Num1 = num1;    
                Num2 = num2;
                Oper = oper;
            }
            public decimal Num1 { get; set; }
            public decimal Num2 { get; set; }   
            public tipoOperacion Oper { get; set; }
        }


}
