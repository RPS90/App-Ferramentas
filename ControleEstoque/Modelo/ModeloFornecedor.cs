using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{//for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado
    public class ModeloFornecedor
    {
        public ModeloFornecedor() //construtor
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCNPJ = "";
            this.ForCEP = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForEndNumero = "";
            this.ForFone = "";
            this.ForEmail = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }
        public ModeloFornecedor(int for_cod, String for_nome, String for_cnpj, 
            String for_cep, String for_endereco, String for_bairro, String for_endnumero,
            String for_fone, String for_email, String for_cidade, String for_estado) //construtor
        {
            this.ForCod = for_cod;
            this.ForNome = for_nome;
            this.ForCNPJ = for_cnpj;
            this.ForCEP = for_cep;
            this.ForEndereco = for_endereco;
            this.ForBairro = for_bairro;
            this.ForEndNumero = for_endnumero;
            this.ForFone = for_fone;
            this.ForEmail = for_email;
            this.ForCidade = for_cidade;
            this.ForEstado = for_estado;
        }     
        private int _for_cod;
        public int ForCod
        {
            get
            {
                return this._for_cod;
            }
            set
            {
                this._for_cod = value;
            }
        }
        private String _for_nome;
        public String ForNome
        {
            get
            {
                return this._for_nome;
            }
            set
            {
                this._for_nome = value;
            }
        }//for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado
        private String _for_estado;
        public String ForEstado
        {
            get
            {
                return this._for_estado;
            }
            set
            {
                this._for_estado = value;
            }
        }
        private String _for_cidade;
        public String ForCidade
        {
            get
            {
                return this._for_cidade;
            }
            set
            {
                this._for_cidade = value;
            }
        }
        private String _for_email;
        public String ForEmail
        {
            get
            {
                return this._for_email;
            }
            set
            {
                this._for_email = value;
            }
        }
        private String _for_fone;
        public String ForFone
        {
            get
            {
                return this._for_fone;
            }
            set
            {
                this._for_fone = value;
            }
        }
        private String _for_endnumero;
        public String ForEndNumero
        {
            get
            {
                return this._for_endnumero;
            }
            set
            {
                this._for_endnumero = value;
            }
        }
        private String _for_bairro;
        public String ForBairro
        {
            get
            {
                return this._for_bairro;
            }
            set
            {
                this._for_bairro = value;
            }
        }
        private String _for_endereco;
        public String ForEndereco
        {
            get
            {
                return this._for_endereco;
            }
            set
            {
                this._for_endereco = value;
            }
        }
        private String _for_cep;
        public String ForCEP
        {
            get
            {
                return this._for_cep;
            }
            set
            {
                this._for_cep = value;
            }
        }

        private String _for_cnpj;
        public String ForCNPJ
        {
            get
            {
                return this._for_cnpj;
            }
            set
            {
                this._for_cnpj = value;
            }
        }










    }
}
