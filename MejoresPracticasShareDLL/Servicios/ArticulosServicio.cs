using MejoresPracticasShareDLL.Entities;
using MejoresPracticasShareDLL.Modelos;
using MejoresPracticasShareDLL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MejoresPracticasShareDLL.Servicios
{
    public class ArticulosServicio
    {
        ArticulosRepository _repository = new ArticulosRepository();
        public string AgregarArticulo(Articulo articuloAAgregar)
        {
            try
            {
                Log.Escribir(1, "INFO", "Inicio a agregar articulo, valido si existe");

                //valido si ya existe
                var articuloAux = _repository.GetArticuloPorNombre(articuloAAgregar.Nombre);

                if (articuloAux != null)
                {
                    return "Ya existe articulo con el nombre " + articuloAAgregar.Nombre;
                }
                Log.Escribir(1, "INFO", "No existe articulo lo voy a agregar");
                int r = _repository.AgregarABase(articuloAAgregar);
                if (r == 1)
                {

                    return "Se Agrego Articulo a la base";
                }

                return "No se pudo agregar a la base de datos";
            }
            catch (Exception ex)
            {
                Log.Escribir(1, "ERROR", "Error en AgregarArticulo, dando de alta articulo. " + ex.Message);
                return "Ocurrio un error. Reintente";
                
            }
            
        }

        public List<Articulo> GetArticulos()
        {
            var articulos = _repository.GetArticulos();

            return articulos;
        }
    }
}
