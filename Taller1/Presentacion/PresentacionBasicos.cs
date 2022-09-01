using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class PresentacionBasicos
    {
        public void suma()
        {
            int a,b, r;
            Console.Clear();
            Console.WriteLine("Suma de dos Numeros: ");
            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.suma(a,b);       
            Console.WriteLine("La suma es --> "+ r.ToString());
            Console.ReadKey();
        }
        public void resta()
        {
            int a, b, r;
            Console.Clear();
            Console.WriteLine("Resta de dos Numeros: ");
            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.resta(a, b);
            Console.WriteLine("La resta es --> " + r.ToString());
            Console.ReadKey();

        }
        public void multi()
        {
            int a, b, r;
            Console.Clear();
            Console.WriteLine("Multiplicaion  de dos Numeros: ");
            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.multi(a, b);
            Console.WriteLine("La multiplicacion es --> " + r.ToString());
            Console.ReadKey();

        }
        public void divi()
        {
            int a, b, r;
            Console.Clear();
            Console.WriteLine("Division de dos Numeros: ");
            Console.Write("digite A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("digite B: ");
            b = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.divi(a, b);
            Console.WriteLine("La division es --> " + r.ToString());
            Console.ReadKey();

        }
        public void ParImpar()
        {
            int a,r;
            Console.Clear();
            Console.WriteLine("Par o Impar: ");
            Console.Write("digite un Numero: ");
            a = int.Parse(Console.ReadLine());

            Logica.EjeciciosBasicos ejeciciosBasicos = new Logica.EjeciciosBasicos();
            r = ejeciciosBasicos.parImpar(a);
            Console.ReadKey();
        }

    }
}
