using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    public class Calculadora
    {
        public decimal Num1;
        public decimal Num2;
        public  static decimal suma(decimal Num1, decimal Num2)
        {
           return Num1 + Num2;
        }
        public static decimal  resta(decimal num1 , decimal num2)
        {
            return num1 - num2;
        }
        public static decimal multiplicar(decimal num1, decimal num2)
        {
            return (num1 * num2);
        }
        public static decimal dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public static decimal modulo(decimal num1, decimal num2)
        {
            return  num1 % num2;
        }
        public static decimal? Operacion(OperacionAritmeticas operacionAritmeticas)
        {
            decimal? result;
            if (operacionAritmeticas.Oper == tipoOperacion.sumar)
            {
                 result = suma(operacionAritmeticas.Num1, operacionAritmeticas.Num2);
                Console.WriteLine("LA SUMA ES  " + result);
                Console.ReadKey();
            }
            else if (operacionAritmeticas.Oper == tipoOperacion.restar)
            {
                 result = resta(operacionAritmeticas.Num1, operacionAritmeticas.Num2);
                Console.WriteLine("LA RESTA ES " + result);
                Console.ReadKey();
            }
            else if(operacionAritmeticas.Oper == tipoOperacion.multiplicar)
            {
                 result = multiplicar(operacionAritmeticas.Num1,operacionAritmeticas.Num2);
                Console.WriteLine("LA MULTIPLICACION ES  " + result);
                Console.ReadKey();
            }
            else if (operacionAritmeticas.Oper == tipoOperacion.dividir)
            {
                 result = dividir(operacionAritmeticas.Num1, operacionAritmeticas.Num2);
                Console.WriteLine("LA DIVICION ES  " + result);
                Console.ReadKey();
            }
            else if (operacionAritmeticas.Oper == tipoOperacion.modulo)
            {
                 result = modulo(operacionAritmeticas.Num1, operacionAritmeticas.Num2);
                Console.WriteLine("EL MODULO ES  " + result);
                Console.ReadKey();
            }
            else 
                result = null;
               return result;
        }
        public static Resultado  Simultaneas(decimal Num1 , decimal Num2) {
            Resultado result = new Resultado();

            Console.WriteLine("Simultaneas");

            result.S = suma(Num1, Num2);
            Console.WriteLine("SUMO: "+ result.S);
            result.R = resta(Num1, Num2);
            Console.WriteLine("RESTA: " + result.R);
            result.M = multiplicar(Num1, Num2);
            Console.WriteLine("MULTIPLICACION : " + result.M);
            result.D = dividir(Num1, Num2);
            Console.WriteLine("dIVICION: " + result.D);
            result.P = modulo(Num1, Num2);
            Console.WriteLine("MODULO: " + result.P);

            Console.ReadKey();
            return result;
        }

        public static void Presentacion()
        {
            Console.WriteLine("Operaciones a realisar ");
            Console.WriteLine("0-.suma");
            Console.WriteLine("1.-resta");
            Console.WriteLine("2-.multioplicacion ");
            Console.WriteLine("3-. division");
            Console.WriteLine("4.-modulo");
            Console.WriteLine("5.- todas");

            Console.WriteLine("Selecione Operaciones a relisar");
            int ope = int.Parse(Console.ReadLine());
            Console.WriteLine("NUMERO 1");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("NUMERO 2");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());


            OperacionAritmeticas ops = new OperacionAritmeticas();
            ops.Oper = (tipoOperacion)ope;
            ops.Num1 = num1;
            ops.Num2 = num2;

            if (ope <= 4)
            {
                decimal? fi = Operacion(ops);
                Console.WriteLine(fi);
            }
            else if (ope == 5)
            {
                Resultado Re = new Resultado();
                Re = Simultaneas(num1, num2);
                Console.WriteLine(Re.S);
                //Console.WriteLine($"{Re.S} { Re.R } {Re.M} {Re.D} { Re.P}");
            }
            else
            {
                Console.WriteLine("no se puede");
                Console.ReadKey();
            }
        }

    }
}
