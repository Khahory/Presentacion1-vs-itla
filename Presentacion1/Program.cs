using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //para hola mundo 
            Console.WriteLine("Hola mundo C#");
            

            int varInt = 10;
            decimal carDec = 0.43m;
            float varF = 3.4f;
            double varD = 0.0d;
            string varS = "Qloq";
            bool varBoolean = false;
            DateTime fecha = DateTime.MinValue;

            //mostra en pantalla video #3
            Console.WriteLine("El valor de varInt es: {0}", varInt );
            Console.WriteLine("El valor de varDec es: {0:C}", carDec);
            Console.WriteLine("El valor de varF es: {0:F2}", varF);
            Console.WriteLine("El valor de varD es: {0:F2}", varD);
            Console.WriteLine("El valor de varS es: " +varS);
            Console.WriteLine("El valor de varBoolean es: " +varBoolean.ToString());
            Console.WriteLine("El valor de varBoolean es: " +fecha.ToShortDateString());

            //conversiones video #4
            varInt = (int)carDec;

            varS = varD.ToString();

            Console.ReadKey();

        }
    }
}
