using Mock_Testing_DotNet.Models;
using Mock_Testing_DotNet.Servicios;
using Moq;

namespace Mock_Testing_DotNet.Test
{
    [TestClass]
    public class TestAurticuloServicio
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Mímica de mis repositorios
            Mock<IArticuloRepository> articuloRepository = new Mock<IArticuloRepository>();
            Mock<IAutorRepository> autorRepository = new Mock<IAutorRepository>();

            string contenido = "contenido";
            string titulo = "titulo";
            int autorId = 1;

            autorRepository.Setup(a => a.AutorValido(It.IsAny<int>())).Returns(true);

            articuloRepository.Setup(a => a.InsertarArticulo(contenido, titulo, autorId)).Returns(1);
            articuloRepository.Setup(a => a.GetArticulo(1)).Returns(new Articulo()
            {
                AutorId = new Autor()
                {
                    AutorId = autorId,
                    Nombre = "test"
                },
                Contenido = contenido,
                Fecha = DateTime.Now,
                Id = 1,
                Titulo = titulo
            });

            ArticulosServicio servicio = new ArticulosServicio(autorRepository.Object, articuloRepository.Object);

           
            Articulo articulo = servicio.InsertarArticulo(contenido, titulo, autorId);

            Assert.AreEqual(autorId, articulo.AutorId.AutorId);

            autorRepository.Verify(a => a.AutorValido(1));
            articuloRepository.Verify(a => a.InsertarArticulo(contenido, titulo, autorId));
            articuloRepository.Verify(a => a.GetArticulo(1));

        }
    }
}