

using MejoresPracticasShareDLL;
using MejoresPracticasShareDLL.Entities;
using MejoresPracticasShareDLL.Modelos;
using MejoresPracticasShareDLL.Servicios;
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

                Log.Escribir(1, "INFO", "Inicio a cargar articulo");
                
                Articulo articuloAAgregarALaDB = new Articulo();
                articuloAAgregarALaDB.Nombre = "Arroz";
                articuloAAgregarALaDB.Categoria = "Alimentos";
                articuloAAgregarALaDB.Precio = 1000.9987m;

                ArticulosServicio articulosServicio = new ArticulosServicio();

                string mensaje = articulosServicio.AgregarArticulo(articuloAAgregarALaDB);
                Console.WriteLine(mensaje);

                ////agrego el articulo
                //db.Articulos.Add(articuloAAgregarALaDB);
                ////guardo en la DB
                //Log.Escribir(1, "INFO", "Termine cargar datos articulo voy a guardar en la DB");
                //db.SaveChanges();
                //Log.Escribir(1, "INFO", "Articulo Guardado en la DB");
                //throw new Exception("Error personalizado");

                Persona persona = new Persona();
                persona.Nombre = "Juan";
                persona.Apellido = "Perez";
                persona.Documento = "23232323";

                 

                Console.WriteLine(persona.Nombre + " " + persona.Apellido);
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
