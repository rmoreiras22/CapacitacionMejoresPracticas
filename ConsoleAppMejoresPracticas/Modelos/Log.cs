using ConsoleAppMejoresPracticas.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMejoresPracticas.Modelos
{
    public class Log
    {
        public static void Escribir(int usuario, string tipo, string descripcion)
        {
            try
            {
                LogDBEntities db = new LogDBEntities();
                AppLog appLog = new AppLog();
                appLog.Usuario = usuario;
                appLog.Tipo = tipo;
                appLog.Descripcion = descripcion;

                db.AppLogs.Add(appLog);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter("C:\\Users\\rmore\\OneDrive\\Projects\\Time_Solution\\Capacitacion\\MEjoresPracticas\\LogAPP.txt"))
                    {

                        sw.WriteLine(ex.Message);
                        sw.WriteLine(ex.InnerException);

                        sw.WriteLine(ex.StackTrace);
                        sw.WriteLine(ex.Source);

                      
                    }
                }
                catch (Exception)
                {

                }

            }
            
        }
    }
}
