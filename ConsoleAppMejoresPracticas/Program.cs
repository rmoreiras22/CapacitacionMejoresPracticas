using ConsoleAppMejoresPracticas.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMejoresPracticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar la DB
            LogDBEntities db = new LogDBEntities();
            try
            {
                Articulo articuloAAgregarALaDB = new Articulo();
                articuloAAgregarALaDB.Nombre = "HArina 0000";
                articuloAAgregarALaDB.Categoria = "Alimentos";
                articuloAAgregarALaDB.Precio = 1000.9987m;

                
                //agrego el articulo
                db.Articulos.Add(articuloAAgregarALaDB);
                //guardo en la DB
                db.SaveChanges();

                throw new Exception("Error personalizado");
            }
            catch (Exception ex)
            {
                AppLog appLog = new AppLog();
                appLog.Usuario = 1;
                appLog.Tipo = "EXCEPCION";
                appLog.Descripcion = "Error guardando articulo en la base de datos " + ex.Message.ToString();

                db.AppLogs.Add(appLog);
                db.SaveChanges();

                Console.WriteLine("Error guardando articulo en la base de datos " + ex.Message.ToString());
            }





            //try
            //{
            //    FileInfo file = new FileInfo("c:\\TimeSolution\\Prueba.TXT");
            //    file.Create();
            //}
            //catch(DirectoryNotFoundException ex) 
            //{
            //    Console.WriteLine("No existe el directorio donde se quiere crear el archivo");
            //}
            //catch (Exception ex)//generica
            //{

            //    Console.WriteLine(ex.Message.ToString());
            //}
            Console.Read();

        }
    }
}
