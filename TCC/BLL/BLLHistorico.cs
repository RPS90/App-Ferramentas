using System;
using System.Data;
using DAL;
using Modelo;
namespace BLL
{//Não era pra eu ter colocado os métodos de inclusão aqui, mas está funcionando, então não vou mexer
    public class BLLHistorico
    {
        private DALConexao conexao;
        public BLLHistorico(DALConexao cx)
        {            this.conexao = cx;        } 
        public void Incluir(ModeloHistorico modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            DALHistorico DALobj = new DALHistorico(conexao);
            DALobj.Incluir(modelo);
        }
        #region Incluir para cada item
        public void IncluirMesaHistorico(ModeloHistorico modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            DALHistorico DALobj = new DALHistorico(conexao);
            DALobj.IncluirMesaHistorico(modelo);
        }
        public void IncluirComputadorHistorico(ModeloHistorico modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            DALHistorico DALobj = new DALHistorico(conexao);
            DALobj.IncluirComputadorHistorico(modelo);
        }
        public void IncluirMonitorHistorico(ModeloHistorico modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            DALHistorico DALobj = new DALHistorico(conexao);
            DALobj.IncluirMonitorHistorico(modelo);
        }
        public void IncluirUsuarioHistorico(ModeloHistorico modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            DALHistorico DALobj = new DALHistorico(conexao);
            DALobj.IncluirUsuarioHistorico(modelo);
        }
        #endregion
        public DataTable Localizar(String valor)
        {
            DALHistorico DALobj = new DALHistorico(conexao);
            return DALobj.Localizar(valor);
        }   
        public DataTable LocalizarComFiltros(String valorPesquisa,String valorDataDe, String valorDataAte,
            int valorDepartamento, int valorMarca, String valorAcao, String valorEstado, String Operacao)
        {
            DALHistorico DALobj = new DALHistorico(conexao);
            return DALobj.LocalizarComFiltros(valorPesquisa, valorDataDe, valorDataAte, valorDepartamento, valorMarca, valorAcao, valorEstado, Operacao);
        }
        public DataTable LocalizarComFiltrosEspecifico(String valorSelecao, String valorPesquisa, String valorDataDe, String valorDataAte,
            int valorDepartamento, int valorMarca, String valorAcao, String valorEstado, String Operacao)
        {
            DALHistorico DALobj = new DALHistorico(conexao);
            return DALobj.LocalizarComFiltrosEspecifico(valorSelecao, valorPesquisa, valorDataDe, valorDataAte, valorDepartamento, valorMarca, valorAcao, valorEstado, Operacao);
        }
        public ModeloHistorico CarregaModeloMesa(int codigo)
        {
            DALHistorico DALobj = new DALHistorico(conexao);
            return DALobj.CarregaModeloHistorico(codigo);
        }
        #region Histórico registro
        //codigo,acao,descricao,historicodata
        //possíveis ações: Cadastrar, Alterar, Remover, Limpar Mesa, Atribuir, Desvincular
        //exemplo de adição ao histórico: HistoricoRegistro("cadastrar Usuário", modelo.nomeusuario, "")
        public void HistoricoRegistrar(string Acao_h, string Descricao_h, int codigo_h)
        {
            ModeloHistorico modelo = new ModeloHistorico();
            BLLHistorico bll = new BLLHistorico(conexao);
            switch (Acao_h)
            {   
                case "Cadastrar Mesa": //---------------------------------------MESA
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();//YY-MM-DD  
                    modelo.COD_mesa = codigo_h;
                    bll.IncluirMesaHistorico(modelo);
                    break;
                case "Alterar Mesa":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_mesa = codigo_h;
                    bll.IncluirMesaHistorico(modelo);
                    break; 
                case "Limpar Mesa":
                    modelo.Acao = Acao_h;                   
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_mesa = codigo_h;
                    bll.IncluirMesaHistorico(modelo);
                    break;
                case "Cadastrar Monitor"://---------------------------------------Monitor
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_monitor = codigo_h;
                    bll.IncluirMonitorHistorico(modelo);
                    break;
                case "Alterar Monitor":
                    modelo.Acao = Acao_h;
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_monitor = codigo_h;
                    bll.IncluirMonitorHistorico(modelo);
                    break;
                case "Atribuir Monitor":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_monitor = codigo_h;
                    bll.IncluirMonitorHistorico(modelo);
                    break;
                case "Desvincular Monitor":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_monitor = codigo_h;
                    bll.IncluirMonitorHistorico(modelo);
                    break;
                case "Cadastrar Computador"://---------------------------------------Computador
                    modelo.Acao = Acao_h;                                                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_computador = codigo_h;
                    bll.IncluirComputadorHistorico(modelo);
                    break;
                case "Alterar Computador":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_computador = codigo_h;
                    bll.IncluirComputadorHistorico(modelo);
                    break;
                case "Atribuir Computador":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_computador = codigo_h;
                    bll.IncluirComputadorHistorico(modelo);
                    break;
                case "Desvincular Computador":
                    modelo.Acao = Acao_h;                   
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_computador = codigo_h;
                    bll.IncluirComputadorHistorico(modelo);
                    break;
                case "Cadastrar Usuário"://---------------------------------------Usuário
                    modelo.Acao = Acao_h;                   
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_usuario = codigo_h;
                    bll.IncluirUsuarioHistorico(modelo);
                    break;
                case "Alterar Usuário":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_usuario = codigo_h;
                    bll.IncluirUsuarioHistorico(modelo);
                    break;
                case "Atribuir Usuário":
                    modelo.Acao = Acao_h;                    
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_usuario = codigo_h;
                    bll.IncluirUsuarioHistorico(modelo);
                    break;
                case "Desvincular Usuário":
                    modelo.Acao = Acao_h;                   
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    modelo.COD_usuario = codigo_h;
                    bll.IncluirUsuarioHistorico(modelo);
                    break;
                case "Departamento Cadastrado":
                    modelo.Acao = Acao_h;
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    //modelo.COD_usuario = codigo_h;
                   // bll.IncluirUsuarioHistorico(modelo);
                    break;
                case "Marca Cadastrada":
                    modelo.Acao = Acao_h;
                    modelo.Descricao = Descricao_h;
                    modelo.HistoricoData = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
                    //modelo.COD_usuario = codigo_h;
                    // bll.IncluirUsuarioHistorico(modelo);
                    break;  
              
                default:
                    break;
            }
            //BLLHistorico bll = new BLLHistorico(conexao);
            //bll.Incluir(modelo);
        }
        #endregion
    }//class
}//namespace