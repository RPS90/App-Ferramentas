using System;
namespace Modelo
{//IP,Marca,ModeloPC,Nserie,NumeroPatrimonio,NomeMaquina,PatrimonioProv,Sigla,estado,datacadastro,ultimaalteracao,tipo
    public class ModeloComputador
    {
        public ModeloComputador() //construtor sem parametros
        {
             this.Codigo            = 0;             
             this.IP                = "";
             this.Marca             = 0;
             this.ModeloPC          = "";
             this.Nserie            = "";
             this.NumeroPatrimonio  = "";
             this.NomeMaquina       = "";
             this.PatrimonioProv    = "";
             this.Sigla             = "";
             this.Estado            = "";
             this.DataCadastro      = "";
             this.UltimaAlteracao   = "";
             this.Tipo = "";
        }
        public ModeloComputador(int codigo, String ip,int marca,
            String modelopc, String nserie, String numeropatrimonio, String nomemaquina,
            String patrimonioprov, String sigla, String estado, String datacadastro, String ultimaalteracao, String tipo) //construtor com os coiso
        {
            this.Codigo = codigo;            
            this.IP = ip;
            this.Marca = marca;
            this.ModeloPC = modelopc;
            this.Nserie = nserie;
            this.NumeroPatrimonio = numeropatrimonio;
            this.NomeMaquina = nomemaquina;
            this.PatrimonioProv = patrimonioprov;
            this.Sigla = sigla;
            this.Estado = estado;
            this.DataCadastro = datacadastro;
            this.UltimaAlteracao = ultimaalteracao;
            this.Tipo = tipo;
        }
        private int _codigo;
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }//codigo    
        private String _ip;
        public String IP
        {
            get { return this._ip; }
            set { this._ip = value; }
        }//ip
        private int _marca;
        public int Marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }//marca
        private String _modelopc;
        public String ModeloPC
        {
            get { return this._modelopc; }
            set { this._modelopc = value; }
        }//modelopc
        private String _nserie;
        public String Nserie
        {
            get { return this._nserie; }
            set { this._nserie = value; }
        }//nserie
        private String _numeropatrimonio;
        public String NumeroPatrimonio
        {
            get { return this._numeropatrimonio; }
            set { this._numeropatrimonio = value; }
        }//numeropatrimonio
        private String _nomemaquina;
        public String NomeMaquina
        {
            get { return this._nomemaquina; }
            set { this._nomemaquina = value; }
        }//nomemaquina
        private String _patrimonioprov;
        public String PatrimonioProv
        {
            get { return this._patrimonioprov; }
            set { this._patrimonioprov = value; }
        }//patrimonio
        private String _sigla;
        public String Sigla
        {
            get { return this._sigla; }
            set { this._sigla = value; }
        }//sigla
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
        private String _tipo;
        public String Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }//tipo-------------------------------------
    }//class
}//namespace