using LojaWhereTo.Dominio.Contratos;
using LojaWhereTo.Dominio.Entidades;
using LojaWhereTo.Repositorio.Contexto;

namespace LojaWhereTo.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(LojaWhereToContexto lojaWhereToContexto) : base(lojaWhereToContexto)
        {

        }
    }
}