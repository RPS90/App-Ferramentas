using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{
    public class BLLInformacoes
    {
        private DALConexao conexao;
        public BLLInformacoes(DALConexao cx)
        { this.conexao = cx; }
        public void IncluirDepartamento(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.Departamento.Trim().Length == 0)
            {
                throw new Exception("Insira um Departamento");
            }
            DALInformacoes DALobj = new DALInformacoes(conexao);
            DALobj.IncluirDepartamento(modelo);
        }
        public void IncluirMarca(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.Departamento.Trim().Length == 0)
            {
                throw new Exception("Insira uma Marca");
            }
            DALInformacoes DALobj = new DALInformacoes(conexao);
            DALobj.IncluirMarca(modelo);
        }
        public void AlterarDepartamento(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código é obrigatório");
            }
            if (modelo.Departamento.Trim().Length == 0)
            {
                throw new Exception("Insira um Departamento");
            }
            DALInformacoes DALobj = new DALInformacoes(conexao);
            DALobj.AlterarDepartamento(modelo);
        }
        public void AlterarMarca(ModeloInformacoes modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código é obrigatório");
            }
            if (modelo.Departamento.Trim().Length == 0)
            {
                throw new Exception("Insira uma Marca");
            }
            DALInformacoes DALobj = new DALInformacoes(conexao);
            DALobj.AlterarMarca(modelo);
        }
        public void ExcluirDepartamento(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            DALInformacoes DALobj = new DALInformacoes(conexao);
            DALobj.ExcluirDepartamento(codigo);
        }
        public void ExcluirMarca(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            DALInformacoes DALobj = new DALInformacoes(conexao);
            DALobj.ExcluirMarca(codigo);
        }
        public DataTable LocalizarDepartamento(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALInformacoes DALobj = new DALInformacoes(conexao);
            return DALobj.LocalizarDepartamento(valor);
        }
        public DataTable LocalizarMarca(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALInformacoes DALobj = new DALInformacoes(conexao);
            return DALobj.LocalizarMarca(valor);
        }      
        public ModeloInformacoes CarregaModeloDepartamento(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALInformacoes DALobj = new DALInformacoes(conexao);
            return DALobj.CarregaModeloDepartamento(codigo);
        }
        public ModeloInformacoes CarregaModeloMarca(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALInformacoes DALobj = new DALInformacoes(conexao);
            return DALobj.CarregaModeloMarca(codigo);
        }
    }//class
}//namespace