using MejoresPracticasShareDLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejoresPracticasShareDLL.Repositories
{
    public class ArticulosRepository
    {
        LogDBEntities db = new LogDBEntities();

        public int AgregarABase(Articulo articulo)
        {
            db.Articulos.Add(articulo);

            int r = db.SaveChanges();

            return r;
        }

        public Articulo GetArticuloPorNombre(string nombre)
        {
            var articuloAux = db.Articulos.Where(x=> x.Nombre == nombre).FirstOrDefault();
            return articuloAux;
        }

        public List<Articulo> GetArticulos()
        {
            return db.Articulos.ToList();
        }
    }
}
