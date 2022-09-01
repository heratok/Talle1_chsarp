using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Datos
{
    public class Archivos
    {
        string ruta = "BITACORA.TXT";
        public void Guardar(string datos)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine(datos);
            sw.Close();
        }
        
    }
}
