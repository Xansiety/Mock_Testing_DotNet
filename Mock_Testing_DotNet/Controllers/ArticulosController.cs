using Microsoft.AspNetCore.Mvc;
using Mock_Testing_DotNet.Models;
using Mock_Testing_DotNet.Servicios;

namespace Mock_Testing_DotNet.Controllers
{
    public class ArticulosController : ControllerBase
    {
        private readonly ArticulosServicio articulosServicio;

        public ArticulosController(ArticulosServicio articulosServicio)
        {
            this.articulosServicio = articulosServicio;
        }

        [HttpPost]
        [Route("Articulo")]
        public Articulo InsertarArticulo(string contenido, string titulo, int autor)
        {
            var resultado = articulosServicio.InsertarArticulo(contenido,titulo,autor);
            return resultado;
        }


        [HttpGet]
        [Route("Articulo/{id}")]
        public Articulo ConsultarArticulo(int id)
        {
            var resultado = articulosServicio.ConsultarArticulo(id);
            return resultado;
        }


    }
}
