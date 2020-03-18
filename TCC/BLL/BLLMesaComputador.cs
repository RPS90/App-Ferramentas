using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{
    public class BLLMesaComputador
    {
        private DALConexao conexao;
        public BLLMesaComputador(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMesaComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.Codigo_Computador == 0)
            {
                throw new Exception("Erro, falta selecionar um computador");
            }
            if (modelo.Codigo_Mesa == 0)
            {
                throw new Exception("Erro, falta selecionar uma mesa");
            }         
            DALMesaComputador DALobj = new DALMesaComputador(conexao);
            DALobj.Incluir(modelo);
        }           
        public void Alterar(ModeloMesaComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo_Computador == 0)
            {
                throw new Exception("Erro, falta selecionar um computador");
            }
            if (modelo.Codigo_Mesa == 0)
            {
                throw new Exception("Erro, falta selecionar uma mesa");
            }    
            DALMesaComputador DALobj = new DALMesaComputador(conexao);
            DALobj.Alterar(modelo);
        }   
        public void ExcluirMesa(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------ExcluirMESA
            DALMesaComputador DALobj = new DALMesaComputador(conexao);
            DALobj.ExcluirMesa(codigo);
        }
        public void ExcluirComputador(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------ExcluirCOMP
            DALMesaComputador DALobj = new DALMesaComputador(conexao);
            DALobj.ExcluirComputador(codigo);
        } 
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------Localizar
            DALMesaComputador DALobj = new DALMesaComputador(conexao);
            return DALobj.Localizar(valor);
        }        
        public ModeloMesaComputador CarregaModeloMesaComputador(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALMesaComputador DALobj = new DALMesaComputador(conexao);
            return DALobj.CarregaModeloMesaComputador(codigo);
        }
    }//class
}//namespace