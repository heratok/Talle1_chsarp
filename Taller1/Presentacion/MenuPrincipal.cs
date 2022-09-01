using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion
{
    public class MenuPrincipal
    {
        public MenuPrincipal()
        {

        }
        public void VerPrincipal(int l, int t)
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l, t - 2); Console.WriteLine("M E N U   P R I N C I P A L");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. BASICOS");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("2. INTERMEDIOS");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("3. AVANZADOS");
                Console.SetCursorPosition(l, t + 8); Console.WriteLine("4. salir");
                Console.SetCursorPosition(l, t + 10); Console.WriteLine("digite opcion ...");

                Console.SetCursorPosition(l + 20, t + 10);
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        MenuBasicos(15, 5);
                        break;
                    case 2:
                        MenuIntermedio(15, 5);
                        break;
                    case 3:
                        MenuAvanzado(15, 5);
                        break;
                    case 4:
                        Console.Clear();
                        Console.SetCursorPosition(l, t - 2); Console.WriteLine("GRACIAS POR USAR...");
                        Console.ReadKey();
                        break;
                }

            } while (op != 4);
        }
        public void MenuBasicos(int l, int t)
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l, t - 2); Console.WriteLine("M E N U   B A S I C O S");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Suma de dos Numeros");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("2. Resta de dos numeros");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("3. Multiplicaion de dos numeros");
                Console.SetCursorPosition(l, t + 8); Console.WriteLine("4. Division de dos numeros");
                Console.SetCursorPosition(l, t + 10); Console.WriteLine("5. Saber si es par o no");
                Console.SetCursorPosition(l, t + 12); Console.WriteLine("Volver..");
                Console.SetCursorPosition(l, t + 14); Console.WriteLine("digite opcion ...");
                Console.SetCursorPosition(l + 20, t + 14); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        new PresentacionBasicos().suma();

                        break;
                    case 2:
                        new PresentacionBasicos().resta();
                        break;
                    case 3:
                        new PresentacionBasicos().multi();
                        break;
                    case 4:
                        new PresentacionBasicos().divi();
                        break;
                    case 5:
                        new PresentacionBasicos().ParImpar();
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }
        public void MenuIntermedio(int l, int t)
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l, t - 2); Console.WriteLine("M E N U   I N TE R M E D I O");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Buscar Numeros Positivos o Negativos");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("2. Buscar Numeros Pares");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("3. Estadisitica");
                Console.SetCursorPosition(l, t + 8); Console.WriteLine("4. Circunferencia en Pantalla");
                Console.SetCursorPosition(l, t + 10); Console.WriteLine("5. Registro Coches");
                Console.SetCursorPosition(l, t + 12); Console.WriteLine("Volver..");
                Console.SetCursorPosition(l, t + 14); Console.WriteLine("digite opcion ...");
                Console.SetCursorPosition(l + 20, t + 14); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        new PresentacionIntermedio().BuscarNumerosPositivosNegativos();

                        break;
                    case 2:
                        new PresentacionIntermedio().BuscarNumerosPares();
                        break;
                    case 3:
                        new PresentacionIntermedio().EstadisticaVector();
                        break;
                    case 4:
                        new PresentacionIntermedio().CircunferenciaPantalla();
                        break;
                    case 5:
                        new PresentacionIntermedio().RegistroCoches();
                        break;
                    default:
                        break;
                }
            } while (op != 6);
        }
        public void MenuAvanzado(int l, int t)
        {
            PresentacionAvanzado ejercicio = new PresentacionAvanzado();
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(l, t - 2); Console.WriteLine("M E N U   A V A N Z A D O");
                Console.SetCursorPosition(l, t + 2); Console.WriteLine("1. Saber Mayor de una matrix");
                Console.SetCursorPosition(l, t + 4); Console.WriteLine("2. imprimir serie binaria");
                Console.SetCursorPosition(l, t + 6); Console.WriteLine("3. suma matrix 3x3");
                Console.SetCursorPosition(l, t + 8); Console.WriteLine("4. Saber empleado mejor pagado");
                Console.SetCursorPosition(l, t + 10); Console.WriteLine("5. Volver..");
                Console.SetCursorPosition(l, t + 12); Console.WriteLine("digite opcion ...");
                Console.SetCursorPosition(l + 20, t + 12); op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        ejercicio.Cargar();
                        ejercicio.ImprimirMayor();

                        break;
                    case 2:
                        ejercicio.Cargar1();
                        ejercicio.visualizar();
                        break;
                    case 3:
                        ejercicio.Cargar2();
                        ejercicio.visualizar1();
                        break;
                    case 4:
                        ejercicio.Cargar3();
                        ejercicio.CalcularSumaSueldos();
                        ejercicio.ImprimirTotalPagado();
                        ejercicio.EmpleadoMayorSueldo();
                        break;
                    default:
                        break;
                }
            } while (op != 5);
        }
    }
}
