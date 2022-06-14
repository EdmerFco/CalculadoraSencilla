using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    public struct Resultado
    {
          public  Resultado(decimal suma, decimal resta, decimal multiplicacion, decimal division, decimal modulo)
        {
            S = suma;
            R = resta;
            M = multiplicacion;
            D = division;
            P = modulo;

        }
        public decimal S { get; set; }
        public decimal R { get; set; }
        public decimal M { get; set; }
        public decimal D { get; set; }
        public decimal P { get; set; }  

    }
}
