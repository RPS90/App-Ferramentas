using System;

namespace Modelo
{
    public class ModeloHistorico
    {//codigo,acao,descricao,historicodata
        public ModeloHistorico()
        {
            this.Codigo = 0;
            this.Acao = "";            
            this.Descricao = "";
            this.HistoricoData = "";
            this.COD_computador = 0;  //FK
            this.COD_mesa = 0;//FK
            this.COD_monitor = 0;//FK
            this.COD_usuario = 0;//FK
        }
        public ModeloHistorico(int codigo, String acao, String descricao, String historicodata,
            int cod_computador, int cod_mesa, int cod_monitor, int cod_usuario)
        {           
            this.Codigo = codigo;
            this.Acao = acao;         
            this.Descricao = descricao;
            this.HistoricoData = historicodata;
            this.COD_computador = cod_computador;
            this.COD_mesa = cod_mesa;
            this.COD_monitor = cod_monitor;
            this.COD_usuario = cod_usuario;
        }       
        private int _codigo;//---------------------------CODIGO
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        private String _acao;//--------------------------AÇÃO
        public String Acao
        {
            get { return this._acao; }
            set { this._acao = value; }
        }      
        private String _descricao;//---------------------DESCRICAO
        public String Descricao
        {
            get { return this._descricao; }
            set { this._descricao = value; }
        }
        private String _historicodata;//-----------------HISTORICODATA
        public String HistoricoData
        {
            get { return this._historicodata; }
            set { this._historicodata = value; }
        }
        private int _cod_computador;//---------------------------CODIGO comp
        public int COD_computador
        {
            get { return this._cod_computador; }
            set { this._cod_computador = value; }
        }
        private int _cod_mesa;//---------------------------CODIGO mesa
        public int COD_mesa
        {
            get { return this._cod_mesa; }
            set { this._cod_mesa = value; }
        }
        private int _cod_monitor;//---------------------------CODIGO monit
        public int COD_monitor
        {
            get { return this._cod_monitor; }
            set { this._cod_monitor = value; }
        }
        private int _cod_usuario;//---------------------------CODIGO user
        public int COD_usuario
        {
            get { return this._cod_usuario; }
            set { this._cod_usuario = value; }
        }
    }//class
}//namespace