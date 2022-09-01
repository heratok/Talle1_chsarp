using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EjeciciosBasicos
    {
        public int suma(int a,int b)
        {
            int r = 0;
            r = a + b;
            string bitacora = String.Format("{0} --> f(suma) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a,b, r);
            new Datos.Archivos().Guardar(bitacora);
            return r;
        }
        public int resta(int a,int b)
        {
            int r = 0;
            r = a - b;
            string bitacora = String.Format("{0} --> f(resta) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, b, r);
            new Datos.Archivos().Guardar(bitacora);
            return r;
        }
        public int multi(int a, int b)
        {
            int r = 0;
            r = a * b;
            string bitacora = String.Format("{0} --> f(multiplicacion) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, b, r);
            new Datos.Archivos().Guardar(bitacora);
            return r;
        }
        public int divi(int a, int b)
        {
            int r = 0;
            r = a / b;
            string bitacora = String.Format("{0} --> f(division) --> in1: {1} -- OUT :{2}", DateTime.Now.ToString(), a, b, r);
            new Datos.Archivos().Guardar(bitacora);
            return r;

        }
        public int  parImpar(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }


            new Datos.Archivos().Guardar(DateTime.Now.ToString() + "--->" + " Par o Impar--->" + "IN-1: " + a.ToString());
            return a;
        }


    }
}
