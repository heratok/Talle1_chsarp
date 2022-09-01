using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class PresentacionIntermedio
    {
        public void BuscarNumerosPositivosNegativos()
        {
            Console.Clear();
            int total = 10;
            float[] numeros = new float[total];

            float totalPositivos = 0.0f, totalNegativos = 0.0f;
            int contadorPositivos = 0, contadorNegativos = 0;
            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for (int i = 0; i < total; i++)
            {
                numeros[i] = Convert.ToSingle(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                if (numeros[i] < 0) // Negativo
                {
                    totalNegativos = totalNegativos + numeros[i];
                    contadorNegativos++;
                }

                if (numeros[i] > 0) // Positivo
                {
                    totalPositivos = totalPositivos + numeros[i];
                    contadorPositivos++;
                }
            }

            Console.WriteLine("La media de numeros negativos es {0}", totalNegativos / contadorNegativos);
            Console.WriteLine("La media de numeros positivos es {0}", totalPositivos / contadorPositivos);
        }
        public void BuscarNumerosPares()
        {
            Console.Clear();
            int total = 10;
            int[] numeros = new int[total];
            Console.WriteLine("Ingrese 10 numeros: ");
            for (int i = 0; i < total; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < total; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.Write("{0} ", numeros[i]);
                }

            }
        }
        public void EstadisticaVector()
        {
            Console.Clear();
            int total = 1000;
            float[] numeros = new float[total];
            int contador = 0;

            float maxValor = float.MinValue;
            float minValor = float.MaxValue;
            float totalValores = 0.0f;

            int opcion;

            do
            {
                Console.WriteLine("1. AÃ±adir");
                Console.WriteLine("2. Ver");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. EstadÃ­sticas");
                Console.WriteLine("5. Salir");

                Console.WriteLine();
                Console.Write("Introduzca una opciÃ³n (1-5): ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1: // AÃ±adir

                        if (contador < total)
                        {
                            numeros[contador] = Convert.ToSingle(Console.ReadLine());

                            if (maxValor < numeros[contador])
                            {
                                maxValor = numeros[contador];
                            }

                            if (minValor > numeros[contador])
                            {
                                minValor = numeros[contador];
                            }

                            totalValores += numeros[contador];
                            contador++;
                        }
                        else
                        {
                            Console.WriteLine("La base de datos estÃ¡ llena");
                        }

                        break;

                    case 2: // Ver

                        if (contador > 0)
                        {
                            for (int i = 0; i < contador; i++)
                            {
                                Console.Write("{0} ", numeros[i]);
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Datos no disponibles");
                        }

                        break;

                    case 3: // Buscar

                        if (contador > 0)
                        {
                            float searchNumber = Convert.ToSingle(Console.ReadLine());

                            bool foundNumber = false;
                            for (int i = 0; i < contador; i++)
                            {
                                if (numeros[i] == searchNumber)
                                {
                                    foundNumber = true;
                                }
                            }

                            if (foundNumber)
                            {
                                Console.WriteLine("NÃºmero {0} encontrado", searchNumber);
                            }
                            else
                            {
                                Console.WriteLine("Datos no disponibles");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Datos no disponibles");
                        }

                        break;

                    case 4: // EstadÃ­sticas

                        if (contador > 0)
                        {
                            Console.WriteLine("Total datos: {0}", contador);
                            Console.WriteLine("Suma: {0}", totalValores);
                            Console.WriteLine("Media: {0}", totalValores / contador);
                            Console.WriteLine("Valor mÃ­nimo: {0}", minValor);
                            Console.WriteLine("Valor mÃ¡ximo: {0}", maxValor);
                        }
                        else
                        {
                            Console.WriteLine("Datos no disponibles");
                        }

                        break;

                    default:
                        Console.WriteLine("Opciones vÃ¡lidas (1-5)");
                        break;
                }
            }
            while (opcion != 5);
        }
        public void CircunferenciaPantalla()
        {
            Console.Clear();
            double x, y;
            double radio;

            for (int i = 0; i < 360; i += 5)
            {
                radio = i * Math.PI / 180.0;

                x = 35 + 8 * Math.Cos(radio);
                y = 10 + 8 * Math.Sin(radio);

                Console.SetCursorPosition((int)x, (int)y);
                Console.Write("X");
            }
            Console.SetCursorPosition(1, 20);
        }
        struct Coche
        {
            public string Modelo;
            public int AnyoFabricacion;
        }
        public void RegistroCoches()
        {
            Console.Clear();
            int total = 3;
            Coche[] coches = new Coche[total];

            for (int i = 0; i < total; i++)
            {
                coches[i] = new Coche()
                {
                    Modelo = Console.ReadLine(),
                    AnyoFabricacion = int.Parse(Console.ReadLine())
                };
            }

            // OrdenaciÃ³n
            for (int i = 0; i < total - 1; i++)
            {
                for (int j = i + 1; j < total; j++)
                {
                    if (coches[i].AnyoFabricacion > coches[j].AnyoFabricacion)
                    {
                        var aux = coches[i];

                        coches[i] = coches[j];
                        coches[j] = aux;
                    }
                }
            }

            // Muestra
            for (int i = 0; i < total; i++)
            {
                var coche = coches[i];
                Console.WriteLine("Modelo: " + coche.Modelo + ", " +
                    "AÃ±o of fabricaciÃ³n: " + coche.AnyoFabricacion);
            }
        }

    }
}
