using LojaWhereTo.Dominio.Entidades;

namespace LojaWhereTo.Dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string email, string senha);
        Usuario Obter(string email);
    }
}
