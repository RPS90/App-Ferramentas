using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{//Não era pra eu ter colocado os métodos de inclusão aqui, mas está funcionando, então não vou mexer
    public class BLLHistorico
    {
        private DALConexao conexao;
        public BLLHistorico(DALConexao cx)
        {
            this.conexao = cx;
        } 
        public void Incluir(ModeloHistorico modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.Historico.Trim().Length == 0)
            {
                throw new Exception("ERRO!");
            }
            DALHistorico DALobj = new DALHistorico(conexao);
            DALobj.Incluir(modelo);
        }                     
        public DataTable Localizar(String valor)
        {
            DALHistorico DALobj = new DALHistorico(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloHistorico CarregaModeloMesa(int codigo)
        {
            DALHistorico DALobj = new DALHistorico(conexao);
            return DALobj.CarregaModeloHistorico(codigo);
        }
        public void AdicionarAoHistorico(string selecaoHistorico, string str1) //Mesa usuario pc monitor , numero ou nome, 
        {//---------------------------------------------------------------------------------------------------------------------ADDHISTORICO            
            ModeloHistorico modelo = new ModeloHistorico();
            if (selecaoHistorico == "Usuário" || selecaoHistorico == "usuário")
            {
                modelo.Historico = selecaoHistorico + " '" + str1 + "' Adicionado em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            }
            else// {se é Mesa, Monitor ou Computador}
            {
                modelo.Historico = selecaoHistorico + " (N°Patrimônio): '" + str1 + "' Adicionado em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString(); 
            }
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLHistorico bll = new BLLHistorico(cx);
            bll.Incluir(modelo);           
        }
        public void AdicionarAlteracaoAoHistorico(string selecaoHistorico, string str1) //Mesa usuario pc monitor , numero ou nome, 
        {//---------------------------------------------------------------------------------------------------------------------ADDALTERACAO
            ModeloHistorico modelo = new ModeloHistorico();
            if (selecaoHistorico == "Usuário" || selecaoHistorico == "usuário")
            {
                modelo.Historico = selecaoHistorico + " '" + str1 + "' Atualizado em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            }
            else
            {
                modelo.Historico = selecaoHistorico + " (N°Patrimônio): '" + str1 + "' Atualizado em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            }
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLHistorico bll = new BLLHistorico(cx);
            bll.Incluir(modelo);
        }
        public void AdicionarConexaoAoHistorico(string selecaoHistorico, string str1, string str2 )
        {//---------------------------------------------------------------------------------------------------------------------CONEXAO HISTORICO            
            ModeloHistorico modelo = new ModeloHistorico();
            if (selecaoHistorico == "Usuário" || selecaoHistorico == "usuário")
            {
                modelo.Historico = selecaoHistorico + " '" + str1 + "' Atribuido à Mesa (N°Patrimonio): '" + str2 + "' em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            }
            if (selecaoHistorico == "Monitor" || selecaoHistorico == "monitor")
            {
                modelo.Historico = selecaoHistorico + " '" + str1 + "' Atribuido à Mesa (N°Patrimonio): '" + str2 + "' em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            }
            if (selecaoHistorico == "Computador" || selecaoHistorico == "computador")
            {
                modelo.Historico = selecaoHistorico + " '" + str1 + "' Atribuido à Mesa (N°Patrimonio): '" + str2 + "' em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            }
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLHistorico bll = new BLLHistorico(cx);
            bll.Incluir(modelo);         
        }
        public void RemoverConexaoAoHistorico()//não terminei
        {//---------------------------------------------------------------------------------------------------------------------DELETAR CONEXAO
            ModeloHistorico modelo = new ModeloHistorico();            
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLHistorico bll = new BLLHistorico(cx);
            bll.Incluir(modelo);
        }
        public void HistoricoLimparMesa(string MesaQueVaiSerLimpa)  
        {//---------------------------------------------------------------------------------------------------------------------HISTORICO LIMPAR MESA-ok         
            ModeloHistorico modelo = new ModeloHistorico();          
            modelo.Historico = "TODOS os DADOS da mesa: '" + MesaQueVaiSerLimpa + "' foram apagados em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();               
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLHistorico bll = new BLLHistorico(cx);
            bll.Incluir(modelo);
        }
        public void HistoricoLimparMesa(int MesaQueVaiSerLimpa)
        {//---------------------------------------------------------------------------------------------------------------------HISTORICO LIMPAR MESA-ok         
            ModeloHistorico modelo = new ModeloHistorico();
            modelo.Historico = "TODOS os DADOS da mesa: '" + MesaQueVaiSerLimpa + "' foram apagados em: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLHistorico bll = new BLLHistorico(cx);
            bll.Incluir(modelo);
        }
    }//class
}//namespace