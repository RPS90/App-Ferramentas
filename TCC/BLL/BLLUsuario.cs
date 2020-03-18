using System;
using System.Data;
using DAL;
using Modelo;

namespace BLL
{//nomeusuario,login,ramal,departamento,email,foto,estado,datacadastro,ultimaalteracao
    public class BLLUsuario
    {
        private DALConexao conexao;
        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUsuario modelo)
        {//---------------------------------------------------------------------------------------------------------------------INCLUIR
            if (modelo.NomeUsuario.Trim().Length == 0)//se não tem nada escrito
            {
                throw new Exception("Nome é Obrigatório");
            }
            if (modelo.NomeUsuario.StartsWith(" "))//se começa com espaço em branco
            {
                throw new Exception("Remova o Espaço em branco antes do Nome de Usuário");
            }
            if (modelo.NomeUsuario.Trim().Length == 0)//se não tem nada escrito
            {
                throw new Exception("Nome é Obrigatório");
            }
            if (modelo.Ramal.Trim().Length == 0)//se não tem nada escrito
            {
                throw new Exception("Ramal/Telefone é Obrigatório");
            }        
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);//método incluir
        }
        public void Alterar(ModeloUsuario modelo)
        {//---------------------------------------------------------------------------------------------------------------------ALTERARR
            if (modelo.Codigo <= 0)
            {
                throw new Exception("O código do Usuario é obrigatório");
            }
            if (modelo.NomeUsuario.Trim().Length == 0)
            {
                throw new Exception("Nome é Obrigatório");
            }
            if (modelo.Ramal.Trim().Length == 0)
            {
                throw new Exception("Ramal/Telefone é Obrigatório");
            }           
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------EXCLUIR
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(valor);
        }
        public DataTable LocalizarApenasAtivosAZ(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarApenasAtivosAZ(valor);
        }
        public DataTable LocalizarApenasAtivos(String valor)
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR ATIVOS
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.LocalizarApenasAtivos(valor);
        }
        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {//---------------------------------------------------------------------------------------------------------------------MODELO
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);
        }
      
    }//class
}//namespace