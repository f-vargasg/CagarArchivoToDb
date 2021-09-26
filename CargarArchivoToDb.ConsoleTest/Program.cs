using CagarArchivoToDb.BE;
using CagarArchivoToDb.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargarArchivoToDb.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AllocationFileVoBE allocationFileVoBE = new AllocationFileVoBE
                {
                    Filename = "ArchPrueba",
                    Crc1 = Convert.ToDecimal(1),
                    Crc2 = Convert.ToDecimal(1),
                    Crc3 = Convert.ToDecimal(1),
                    Entity = 501,
                    FecIngreso = DateTime.Now,
                    FecRegistro = DateTime.Now,
                    IndCarga = "S",
                    UsuIngreso = "AUTO"
                };
                AllocationFileVoBL allocationFileVoBL = new AllocationFileVoBL();

                // allocationFileVoBL.Insertar(allocationFileVoBE);
                allocationFileVoBL.Borrar("ArchPrueba");

                Console.WriteLine("Archivo Insertado Correctamente");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ex :" + ex.Message);
                Console.ReadLine();
            }



        }
    }
}
