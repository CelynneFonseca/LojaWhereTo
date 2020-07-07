using LojaWhereTo.Dominio.Contratos;
using LojaWhereTo.Dominio.Entidades;
using LojaWhereTo.Repositorio.Contexto;
using System.Linq;

namespace LojaWhereTo.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(LojaWhereToContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return LojaWhereToContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return LojaWhereToContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}