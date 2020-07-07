using LojaWhereTo.Dominio.Contratos;
using LojaWhereTo.Dominio.Entidades;
using LojaWhereTo.Repositorio.Contexto;

namespace LojaWhereTo.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(LojaWhereToContexto lojaWhereToContexto) : base(lojaWhereToContexto)
        {
        }
    }
}