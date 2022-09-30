using Mock_Testing_DotNet.Models;

namespace Mock_Testing_DotNet.Servicios
{
    public interface IAutorRepository
    {
        Autor GetAutor(int id);
        bool AutorValido(int id);
    }
}
