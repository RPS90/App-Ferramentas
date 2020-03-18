using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{
    public class BLLMesaMonitor
    {
        private DALConexao conexao;
        public BLLMesaMonitor(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMesaMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.Codigo_Monitor == 0)
            {
                throw new Exception("Erro, falta selecionar um monitor");
            }
            if (modelo.Codigo_Mesa == 0)
            {
                throw new Exception("Erro, falta selecionar uma mesa");
            }
            DALMesaMonitor DALobj = new DALMesaMonitor(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloMesaMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo_Monitor == 0)
            {
                throw new Exception("Erro, falta selecionar um monitor");
            }
            if (modelo.Codigo_Mesa == 0)
            {
                throw new Exception("Erro, falta selecionar uma mesa");
            }
            DALMesaMonitor DALobj = new DALMesaMonitor(conexao);
            DALobj.Alterar(modelo);
        }
        public void ExcluirMesa(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-MESA
            DALMesaMonitor DALobj = new DALMesaMonitor(conexao);
            DALobj.ExcluirMesa(codigo);
        }
        public void ExcluirMonitor(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR-Monitor
            DALMesaMonitor DALobj = new DALMesaMonitor(conexao);
            DALobj.ExcluirMonitor(codigo);
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALMesaMonitor DALobj = new DALMesaMonitor(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloMesaMonitor CarregaModeloMesaMonitor(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALMesaMonitor DALobj = new DALMesaMonitor(conexao);
            return DALobj.CarregaModeloMesaMonitor(codigo);
        }
    }//class
}//namespace