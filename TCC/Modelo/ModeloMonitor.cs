using System;
namespace Modelo
{//numeropatrimonio,patrimonioprov,marca,nserie,departamento,sigla,tipo,estado,datacadastro,ultimaalteracao
    public class ModeloMonitor
    {
        public ModeloMonitor()
        {
            this.Codigo = 0;
            this.NumeroPatrimonio = "";
            this.PatrimonioProv = "";          
            this.Marca = 0;
            this.Nserie = "";            
            this.Sigla = "";
            this.Tipo = "";
            this.Estado = "";
            this.DataCadastro = "";
            this.UltimaAlteracao = "";
            this.ModeloMNT = "";
        }
        public ModeloMonitor(int codigo, String numeropatrimonio, String patrimonioprov, 
            int marca, String nserie, String sigla, String tipo,
            String estado, String datacadastro, String ultimaalteracao, String modelomnt)
        {
            this.Codigo = codigo;
            this.NumeroPatrimonio = numeropatrimonio;
            this.PatrimonioProv = patrimonioprov;
            this.Marca = marca;
            this.Nserie = nserie;
            this.Sigla = sigla;
            this.Tipo = tipo;
            this.Estado = estado;
            this.DataCadastro = datacadastro;
            this.UltimaAlteracao = ultimaalteracao;
            this.ModeloMNT = modelomnt;
        }
        private int _codigo;
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }//codigo-----------------------------------
        private String _numeropatrimonio;
        public String NumeroPatrimonio
        {
            get { return this._numeropatrimonio; }
            set { this._numeropatrimonio = value; }
        }//numeropatrimonio-------------------------
        private String _patrimonioprov;
        public String PatrimonioProv
        {
            get { return this._patrimonioprov; }
            set { this._patrimonioprov = value; }
        }//_patrimonioprov--------------------------  
        private String _sigla;
        public String Sigla
        {
            get { return this._sigla; }
            set { this._sigla = value; }
        }//numeropatrimonio-------------------------
        private int _marca;
        public int Marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }//marca------------------------------------
        private String _nserie;
        public String Nserie
        {
            get { return this._nserie; }
            set { this._nserie = value; }
        }//nserie-----------------------------------
        private String _tipo;
        public String Tipo
        {
            get { return this._tipo; }
            set { this._tipo = value; }
        }//tipo-------------------------------------
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
        private String _modelomnt;
        public String ModeloMNT
        {
            get { return this._modelomnt; }
            set { this._modelomnt = value; }
        }//ultimaalteracao
    }//class
}//namespace
