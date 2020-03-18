using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{
    public class BLLMesaUsuario
    {
        private DALConexao conexao;
        public BLLMesaUsuario(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMesaUsuario modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.Codigo_Usuario == 0)
            {
                throw new Exception("Erro, falta selecionar um usuario");
            }
            if (modelo.Codigo_Mesa == 0)
            {
                throw new Exception("Erro, falta selecionar uma mesa");
            }
            DALMesaUsuario DALobj = new DALMesaUsuario(conexao);
            DALobj.Incluir(modelo);
        }     
        public void Alterar(ModeloMesaUsuario modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo_Usuario == 0)
            {
                throw new Exception("Erro, falta selecionar um usuario");
            }
            if (modelo.Codigo_Mesa == 0)
            {
                throw new Exception("Erro, falta selecionar uma mesa");
            }
            DALMesaUsuario DALobj = new DALMesaUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public void ExcluirMesa(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-MESA
            DALMesaUsuario DALobj = new DALMesaUsuario(conexao);
            DALobj.ExcluirMesa(codigo);
        }
        public void ExcluirUsuario(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-Usuario
            DALMesaUsuario DALobj = new DALMesaUsuario(conexao);
            DALobj.ExcluirUsuario(codigo);
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALMesaUsuario DALobj = new DALMesaUsuario(conexao);
            return DALobj.Localizar(valor);
        }    
        public ModeloMesaUsuario CarregaModeloMesaUsuario(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALMesaUsuario DALobj = new DALMesaUsuario(conexao);
            return DALobj.CarregaModeloMesaUsuario(codigo);
        }
    }//class
}//namespace