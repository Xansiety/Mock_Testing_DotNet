using Mock_Testing_DotNet.Models;

namespace Mock_Testing_DotNet.Servicios
{
    public class ArticulosServicio 
    { 
        private readonly IAutorRepository autorServicio;
        private readonly IArticuloRepository articuloServicio;

        public ArticulosServicio(IAutorRepository autorServicio, IArticuloRepository articuloServicio)
        {
            this.autorServicio = autorServicio;
            this.articuloServicio = articuloServicio;
        }

        public Articulo InsertarArticulo(string Contenido, string Titulo, int AutorId)
        {
            if(!autorServicio.AutorValido(AutorId))
            {
                throw new Exception("Autor not valid");
            }

            var articuloId = articuloServicio.InsertarArticulo(Contenido, Titulo, AutorId);
            return ConsultarArticulo(articuloId);
        }

        public Articulo ConsultarArticulo(int id)
        {
            return articuloServicio.GetArticulo(id);
        }
    }
}
