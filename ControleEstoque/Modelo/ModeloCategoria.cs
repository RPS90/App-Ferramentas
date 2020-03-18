using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCategoria
    {
        private int cat_cod;
        private String cat_nome;

        public ModeloCategoria()//construtor
        {
            this.CatCod = 0;
            this.CatNome = "";
        }
        public ModeloCategoria(int catcod, String nome)//construtor
        {
            this.CatCod = catcod;
            this.CatNome = nome;
        }
        public int CatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }
        public String CatNome
        {
            get { return this.cat_nome; }
            set { this.cat_nome = value; }
        }
    }
}
