using Mock_Testing_DotNet.Models;

namespace Mock_Testing_DotNet.Servicios
{
    public interface IArticuloRepository
    {
        int InsertarArticulo(string Contenido, string Titulo, int AutorId);

        Articulo GetArticulo(int id);
    }
}
