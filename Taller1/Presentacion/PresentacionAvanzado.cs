using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    internal class PresentacionAvanzado
    {
        //Saber Mayor de una matrix
        private int[,] mat;
        public void Cargar()
        {
            Console.Clear();
            Console.Write("Cuantas fila tiene la matriz:");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.Write("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            mat = new int[filas, columnas];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void ImprimirMayor()
        {
            Console.Clear();
            int mayor = mat[0, 0];
            int filamay = 0;
            int columnamay = 0;
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    if (mat[f, c] > mayor)
                    {
                        mayor = mat[f, c];
                        filamay = f;
                        columnamay = c;
                    }
                }
            }
            Console.WriteLine("El elemento mayor es:" + mayor);
            Console.WriteLine("Se encuentra en la fila:" + filamay + " y en la columna: " + columnamay);
            Console.ReadLine();
        }
        //imprimir serie binaria
        private int[,] serie;
        public void Cargar1()
        {
            Console.Clear();
            serie = new int[10, 10];
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (j % 2 == 0)
                    {
                        serie[i, j] = 0;
                    }
                    else
                    {
                        serie[i, j] = 1;
                    }
                }
            }
        }
        public void visualizar()
        {
            Console.Clear();
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write(serie[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
        //suma matrix 3x3
        private int[,] MatrizA;
        private int[,] MatrizB;
        private int[,] MatrizC;
        public void Cargar2()
        {
            Console.Clear();
            MatrizA = new int[10, 10];
            MatrizB = new int[10, 10];
            MatrizC = new int[10, 10];
            Console.WriteLine("Ingresando datos al matriz A");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizA[i, j] = int.Parse(linea);
                }
            }
            Console.WriteLine("Ingresando datos al matriz B");
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write("Ingrese posicion [" + i + "," + j + "]: ");
                    string linea;
                    linea = Console.ReadLine();
                    MatrizB[i, j] = int.Parse(linea);
                }
            }
            //Sumamos la matrizA y la MatrizB
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    MatrizC[i, j] = MatrizA[i, j] + MatrizB[i, j];
                }
            }
        }
        // visualizamos la suma de las matrices
        public void visualizar1()
        {
            Console.Clear();
            Console.WriteLine("La suma de la MatrizA y MatrizB es :");
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write(MatrizC[i, j] + "  ");
                }
            }
            Console.ReadKey();
        }
        //Obtener el nombre del operario que tuvo el mayor ingreso acumulado
        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldostot;
        public void Cargar3()
        {
            Console.Clear();
            empleados = new String[4];
            sueldos = new int[4, 3];
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del operario " + (f + 1) + ": ");
                empleados[f] = Console.ReadLine();
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    Console.Write("Ingrese sueldo " + (c + 1) + ": ");
                    string linea;
                    linea = Console.ReadLine();
                    sueldos[f, c] = int.Parse(linea);
                }
            }
        }
        public void CalcularSumaSueldos()
        {
            Console.Clear();
            sueldostot = new int[4];
            for (int f = 0; f < sueldos.GetLength(0); f++)
            {
                int suma = 0;
                for (int c = 0; c < sueldos.GetLength(1); c++)
                {
                    suma = suma + sueldos[f, c];
                }
                sueldostot[f] = suma;
            }
        }
        public void ImprimirTotalPagado()
        {
            Console.Clear();
            Console.WriteLine("Total de sueldos pagados por Operario.");
            for (int f = 0; f < sueldostot.Length; f++)
            {
                Console.WriteLine(empleados[f] + " - " + sueldostot[f]);
            }
        }
        public void EmpleadoMayorSueldo()
        {
            Console.Clear();
            int may = sueldostot[0];
            string nom = empleados[0];
            for (int f = 0; f < sueldostot.Length; f++)
            {
                if (sueldostot[f] > may)
                {
                    may = sueldostot[f];
                    nom = empleados[f];
                }
            }
            Console.WriteLine("El operario con mayor sueldo es " + nom + " que tiene un sueldo de " + may);
        }


    }
}
