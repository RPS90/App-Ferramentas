using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using LojaVirtual.DAO.Interfaces;
//Conjunto de métodos da loja
namespace LojaVirtual.DAO//<T> genérico
{//where T tem que ser do tipo class ou da ERRO
    public abstract class AbstractCRUD<T> : IBaseCRUD <T> where T : class//abstrata p/ herdar
    {//abstract crud herda todos esses métodos da classe
        LOJAEntities loja = new LOJAEntities(); //instanciando 
        //se chamar um método sem implementar, ele da pau
        #region IBaseCRUD<T> Members
        public void Add(T pEntity) //adicionar
        {
            loja.AddObject(pEntity.GetType().Name, pEntity); //Método de adicionar objeto
            //throw new NotImplementedException();
        }
        public void Delete(T pEntity)//deletar!
        {
            loja.DeleteObject(pEntity);            
        }
        public void Attach(T pEntity)
        {
            loja.AttachTo(pEntity.GetType().Name, pEntity);
        }
        public void Detach(T pEntity)
        {
            loja.Detach(pEntity);
        }
        public void Update(T pEntity)
        {//pior método de se fazer
            loja.ApplyCurrentValues<T>(pEntity.GetType().Name, pEntity); //parâmetro laaaaa da interface
        }
        public IQueryable<T> Find(Expression<Func<T, bool>> where)//era search
        {//lembrando <T> genérico 
            return loja.CreateObjectSet<T>().Where(where); //minha nossa
        }
        public IQueryable<T> GetAll()
        {
            return loja.CreateObjectSet<T>(); //trás todo reg independende doq for
        }
        public void SaveChanges()
        {
            loja.SaveChanges();
        }
        #endregion
    }
}
