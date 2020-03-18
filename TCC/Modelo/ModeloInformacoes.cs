using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class ModeloInformacoes
    {

          public ModeloInformacoes()
        {
            this.Codigo = 0;
            this.Departamento = "";
            this.Marca = "";

        }
          public ModeloInformacoes(int codigo, String departamento, String marca)
        {           
            this.Codigo = codigo;
            this.Departamento = departamento;
            this.Marca = marca;   
        }       
        private int _codigo;
        public int Codigo
        {
            get { return this._codigo; }
            set { this._codigo = value; }
        }

        private String _departamento;
        public String Departamento
        {
            get { return this._departamento; }
            set { this._departamento = value; }
        }

        private String _marca;
        public String Marca
        {
            get { return this._marca; }
            set { this._marca = value; }
        }


    }
}
