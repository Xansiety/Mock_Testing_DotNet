using Mock_Testing_DotNet.Models;

namespace Mock_Testing_DotNet.Servicios
{
    public class ArticuloRepository : IArticuloRepository
    {
        public Articulo GetArticulo(int id)
        {
            throw new NotImplementedException();
        }

        public int InsertarArticulo(string Contenido, string Titulo, int AutorId)
        {
            throw new NotImplementedException();
        }
    }
}
