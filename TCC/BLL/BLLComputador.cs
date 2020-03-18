using DAL;
using Modelo;
using System;
using System.Data;
namespace BLL
{//codigo,ip,marca,modelopc,nserie,numeropatrimonio,nomemaquina,patrimonioprov,sigla,estado,datacadastro,ultimaalteracao, tipo
    public class BLLComputador
    {
        private DALConexao conexao;
        public BLLComputador(DALConexao cx)//construtor
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.NumeroPatrimonio.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio é obrigatório");
            }
            if (modelo.PatrimonioProv.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio Provisório é obrigatório");
            }         
            if (modelo.NomeMaquina.Trim().Length == 0)
            {
                throw new Exception("O Nome da Máquina na rede é obrigatório");
            }
            if (modelo.Nserie.Trim().Length == 0)
            {
                throw new Exception("O n° de Série é obrigatório");
            }         
            if (modelo.ModeloPC.Trim().Length == 0)
            {
                throw new Exception("O Modelo do Computador é obrigatório");
            }           
            //tipo é combobox, então é ctz q vai ser inserido um
            DALComputador DALobj = new DALComputador(conexao);
            DALobj.Incluir(modelo);//método incluir
        }               
        public void Alterar(ModeloComputador modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERAR
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código do Computador é obrigatório");//msg erro, pq precisa ter algum código
            }
            if (modelo.NumeroPatrimonio.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio é obrigatório");
            }
            if (modelo.PatrimonioProv.Trim().Length == 0)
            {
                throw new Exception("O n° de Patrimonio Provisório é obrigatório");
            }
            if (modelo.NomeMaquina.Trim().Length == 0)
            {
                throw new Exception("O Nome da Máquina na rede é obrigatório");
            }
            if (modelo.Nserie.Trim().Length == 0)
            {
                throw new Exception("O n° de Série é obrigatório");
            }         
            if (modelo.ModeloPC.Trim().Length == 0)
            {
                throw new Exception("O Modelo do Computador é obrigatório");
            }        
            DALComputador DALobj = new DALComputador(conexao);
            DALobj.Alterar(modelo);//método alterar do CADdaCategoria
        }
        public void Excluir(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            DALComputador DALobj = new DALComputador(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALComputador DALobj = new DALComputador(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DALComputador DALobj = new DALComputador(conexao);
            return DALobj.LocalizarApenasAtivos(valor);
        }      
        public ModeloComputador CarregaModeloComputador(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALComputador DALobj = new DALComputador(conexao);
            return DALobj.CarregaModeloComputador(codigo);//método Carrega e procura do CADdaCategoria
        }
    }//class
}//namespace