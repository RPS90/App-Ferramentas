using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace LojaVirtual.DAO.Interfaces
{
    public interface IBaseCRUD <T>//interface com conceito de herança /classe <T> aceita genérico
    {
        void Add    (T pEntity);
        void Delete (T pEntity);
        void Attach (T pEntity);
        void Detach (T pEntity);
        void Update (T pEntity);
        //IQueryable<T> Search(Expression<Func<T, bool>> where);
        IQueryable<T> Find(Expression<Func<T, bool>> where);
        IQueryable<T> GetAll();
        void SaveChanges();
        //todas as assinaturas (existentes)

    }
}
