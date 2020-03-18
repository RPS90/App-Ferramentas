using System;
using System.Data;
using DAL;
using Modelo;
namespace BLL
{//codigo,numeropatrimonio,patrimonioprov,marca,nserie,departamento,sigla,tipo,estado,datacadastro,ultimaalteracao
    public class BLLMonitor
    {
        private DALConexao conexao;
        public BLLMonitor(DALConexao cx)
        {            this.conexao = cx;        }
        public void Incluir(ModeloMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.NumeroPatrimonio.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio é obrigatório");
            } 
            if (modelo.PatrimonioProv.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio Provisório é obrigatório");
            }            
            if (modelo.Nserie.Trim().Length == 0)
            {
                throw new Exception("O n° de Série é obrigatório");
            } 
            DALMonitor DALobj = new DALMonitor(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloMonitor modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código do Monitor é obrigatório");
            }
            if (modelo.NumeroPatrimonio.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio é obrigatório");
            }
            if (modelo.PatrimonioProv.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio Provisório é obrigatório");
            }          
            if (modelo.Nserie.Trim().Length == 0)
            {
                throw new Exception("O n° de Série é obrigatório");
            }        
            DALMonitor DALobj = new DALMonitor(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            DALMonitor DALobj = new DALMonitor(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALMonitor DALobj = new DALMonitor(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DALMonitor DALobj = new DALMonitor(conexao);
            return DALobj.LocalizarApenasAtivos(valor);
        }
        public ModeloMonitor CarregaModeloMonitor(int codigo)
        {
            DALMonitor DALobj = new DALMonitor(conexao);
            return DALobj.CarregaModeloMonitor(codigo);
        }
    }//class
}//namespace