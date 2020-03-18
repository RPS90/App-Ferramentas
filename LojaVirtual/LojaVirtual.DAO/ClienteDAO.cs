using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaVirtual.DAO.Interfaces;

namespace LojaVirtual.DAO
{
    public class ClienteDAO:AbstractCRUD<CLIENTE>, IClienteDAO //herança
    {        
        public CLIENTE AutenticarCliente(string email, string senha)
        {
          return Find(c => c.EMAIL.Trim().Equals(email) && c.SENHA.Trim().Equals(senha)).FirstOrDefault();
           
        }
       



    }
}
