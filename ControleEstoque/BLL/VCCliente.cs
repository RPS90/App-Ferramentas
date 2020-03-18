using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLCliente
    {
        private CADConexao conexao;
        public BLLCliente(CADConexao cx)//construtor
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)//verificação, se for igual a zero\/
            {
                throw new Exception("cliente é obrigatório");//msg erro, pq n tem nada no nome
            }
            if (modelo.Clicpfcnpj.Trim().Length == 0)
            {
                throw new Exception("obrigatório");
            }
            //verificar cpf
            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("obrigatório");
            }
            CADCliente DALobj = new CADCliente(conexao);
            DALobj.Incluir(modelo);//método incluir
        }
        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)//verificação, se for igual a zero\/
            {
                throw new Exception("Cliente é obrigatório");//msg erro, pq n tem nada no nome
            }
            if (modelo.Clicpfcnpj.Trim().Length == 0)
            {
                throw new Exception("CPF obrigatório");
            }
            CADCliente DALobj = new CADCliente(conexao);
            DALobj.Alterar(modelo);//
        }
        public void Excluir(int codigo)
        {
            CADCliente DALobj = new CADCliente(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            CADCliente DALobj = new CADCliente(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            CADCliente DALobj = new CADCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }
        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            CADCliente DALobj = new CADCliente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);
        }




    }
}
