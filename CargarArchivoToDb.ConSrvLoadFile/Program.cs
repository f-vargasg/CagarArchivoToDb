using CargarArchivoToDb.ConSrvLoadFile.LoadFileWcfSrvRef;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarArchivoToDb.ConSrvLoadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CargarAsignaSrvClient cargarAsignaSrvClient = new CargarAsignaSrvClient();
                string dataStr = string.Empty;
                string wPath = Path.Combine(@"C:\Users\garfi\source\repos\CagarArchivoToDb\CargarArchivoToDb.ConSrvLoadFile\Miscelaneo",
                                             "asignaciones.json");
                dataStr = File.ReadAllText(wPath);

                cargarAsignaSrvClient.CargarAsignacion(dataStr);
            }
            catch (Exception ex )
            {
                Console.WriteLine("Excepcion: " + ex.Message);
                Console.ReadKey();
            }
            
        }
    }
}
