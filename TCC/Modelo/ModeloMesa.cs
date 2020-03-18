using System;
namespace Modelo
{//codigo,numeropatrimonio,patrimonioprov,departamento,sigla,estado,datacadastro,ultimaalteracao
    public class ModeloMesa
    {
        public ModeloMesa() 
        {
            this.Codigo = 0;
            this.NumeroPatrimonio = "";
            this.PatrimonioProv = "";
            this.Departamento = 0;
            this.Sigla = "";
            this.Estado = "";
            this.DataCadastro = "";
            this.UltimaAlteracao = "";
        }
        public ModeloMesa(int codigo, String numeropatrimonio, String patrimonioprov,
            int departamento, String sigla, String estado, String datacadastro, String ultimaalteracao) 
        {
            this.Codigo = codigo;
            this.NumeroPatrimonio = numeropatrimonio;
            this.PatrimonioProv = patrimonioprov;
            this.Departamento = departamento;
            this.Sigla = sigla;
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
        private int _departamento;
        public int Departamento
        {
            get { return this._departamento; }
            set { this._departamento = value; }
        }//departamento-----------------------------
        private String _sigla;
        public String Sigla
        {
            get { return this._sigla; }
            set { this._sigla = value; }
        }//numeropatrimonio-------------------------
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