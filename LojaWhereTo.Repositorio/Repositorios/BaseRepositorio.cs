using System.Collections.Generic;
using System.Linq;
using LojaWhereTo.Dominio.Contratos;
using LojaWhereTo.Repositorio.Contexto;

namespace LojaWhereTo.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly LojaWhereToContexto LojaWhereToContexto;


        public BaseRepositorio(LojaWhereToContexto lojaWhereToContexto)
        {
            LojaWhereToContexto = lojaWhereToContexto;
        }

        public void Adicionar(TEntity entity)
        {
            LojaWhereToContexto.Set<TEntity>().Add(entity);
            LojaWhereToContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            LojaWhereToContexto.Set<TEntity>().Update(entity);
            LojaWhereToContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return LojaWhereToContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return LojaWhereToContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            LojaWhereToContexto.Remove(entity);
            LojaWhereToContexto.SaveChanges();
        }

        public void Dispose()
        {
            LojaWhereToContexto.Dispose();
        }
    }
}