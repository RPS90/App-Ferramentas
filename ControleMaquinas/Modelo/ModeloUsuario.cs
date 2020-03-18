using System;
using System.IO;//IMAGENS e outros
namespace Modelo
{//nomeusuario,login,ramal,departamento,email,foto,estado,datacadastro,ultimaalteracao
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.Codigo = 0;
            this.NomeUsuario = "";
            this.Login = "";
            this.Ramal = "";                        
            this.Departamento = "";
            this.Email = "";
            this.Estado = "";
            this.DataCadastro = "";
            this.UltimaAlteracao = "";
        }
        public ModeloUsuario(int codigo, String nomeusuario, String login, String ramal, 
            String departamento, String email, String foto, String estado, String datacadastro, String ultimaalteracao)
        {
            this.Codigo = codigo;
            this.NomeUsuario = nomeusuario;
            this.Login = login;
            this.Ramal = ramal;
            this.Departamento = departamento;
            this.Email = email;
            this.CarregaImagem(foto);
            this.Estado=estado;
            this.DataCadastro = datacadastro;
            this.UltimaAlteracao = ultimaalteracao;
        }
        public ModeloUsuario(int codigo, String nomeusuario, String login, String ramal, 
            String departamento, String email, Byte[] foto, String estado, String datacadastro, String ultimaalteracao)
        {
            this.Codigo = codigo;
            this.NomeUsuario = nomeusuario;
            this.Login = login;
            this.Ramal = ramal;
            this.Departamento = departamento;
            this.Email = email;
            this.Foto = foto;
            this.Estado = estado;
            this.DataCadastro = datacadastro;
            this.UltimaAlteracao = ultimaalteracao;
        }
        private int _codigo;
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }//codigo-----------------------------------
        private String _nomeusuario;
        public String NomeUsuario
        {
            get { return this._nomeusuario; }
            set { this._nomeusuario = value; }
        }//numeropatrimonio-------------------------
        private String _login;
        public String Login
        {
            get { return this._login; }
            set { this._login = value; }
        }//_patrimonioprov--------------------------
        private String _ramal;
        public String Ramal
        {
            get { return this._ramal; }
            set { this._ramal = value; }
        }//departamento-----------------------------
        private String _departamento;
        public String Departamento
        {
            get { return this._departamento; }
            set { this._departamento = value; }
        }//numeropatrimonio-------------------------
        private String _email;
        public String Email
        {
            get { return this._email; }
            set { this._email = value; }
        }//numeropatrimonio        
        private byte[] _foto;
        public byte[] Foto
        {
            get { return this._foto; }
            set { this._foto = value; }
        }
        public void CarregaImagem(String imgCaminho)
        {//precisa do using system.IO;
            try
            {
                if (string.IsNullOrEmpty(imgCaminho))
                    return;
                //fornece propriedadese métodos de instância para criar, copiar,
                //excluir, mover, e abrir arquivos, e ajuda na criação de objetos FileStream
                FileInfo arqImagem = new FileInfo(imgCaminho);
                //Expõe um Stream ao redor de um arquivo de suporte
                //síncrono e assíncrono operações de leitura e gravar.
                FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);
                //aloca memória para o vetor
                this.Foto = new byte[Convert.ToInt32(arqImagem.Length)];
                //Lê um bloco de bytes do fluxo e grava osdados em um buffer fornecido.
                int iBytesRead = fs.Read(this.Foto, 0, Convert.ToInt32(arqImagem.Length));
                fs.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
        private String _estado;
        public String Estado
        {
            get { return this._estado; }
            set { this._estado = value; }
        }//_estado
        private String _datacadastro;
        public String DataCadastro
        {
            get { return this._datacadastro; }
            set { this._datacadastro = value; }
        }//DataCadastro
        private String _ultimaalteracao;
        public String UltimaAlteracao
        {
            get { return this._ultimaalteracao; }
            set { this._ultimaalteracao = value; }
        }//ultimaalteracao
    }//class
}//namespace
