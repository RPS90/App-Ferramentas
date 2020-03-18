using System;

namespace Modelo
{
    public class ModeloHistorico
    {
          public ModeloHistorico()
        {
            this.Codigo = 0;
            this.Historico = "";
        }
          public ModeloHistorico(int codigo, String historico)
        {           
            this.Codigo = codigo;
            this.Historico = historico;     
        }       
        private int _codigo;
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }
        private String _historico;
        public String Historico
        {
            get { return this._historico; }
            set { this._historico = value; }
        }
    }//class
}//namespace