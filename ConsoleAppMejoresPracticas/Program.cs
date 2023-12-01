using ConsoleAppMejoresPracticas.Entities;
using ConsoleAppMejoresPracticas.Modelos;
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
                Log.Escribir(1, "INFO", "I" +
                    "nicio a cargar articulo");
                Articulo articuloAAgregarALaDB = new Articulo();
                articuloAAgregarALaDB.Nombre = "HArina 0000";
                articuloAAgregarALaDB.Categoria = "Alimentos";
                articuloAAgregarALaDB.Precio = 1000.9987m;

                
                //agrego el articulo
                db.Articulos.Add(articuloAAgregarALaDB);
                //guardo en la DB
                Log.Escribir(1, "INFO", "Termine cargar datos articulo voy a guardar en la DB");
                db.SaveChanges();
                Log.Escribir(1, "INFO", "Articulo Guardado en la DB");
               // throw new Exception("Error personalizado");
            }
            catch (Exception ex)
            {
                Log.Escribir(1, "EXCEPCION", "Error guardando articulo en la base de datos " + ex.Message.ToString());
                //AppLog appLog = new AppLog();
                //appLog.Usuario = 1;
                //appLog.Tipo = "EXCEPCION";
                //appLog.Descripcion = "Error guardando articulo en la base de datos " + ex.Message.ToString();

                //db.AppLogs.Add(appLog);
                //db.SaveChanges();

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
