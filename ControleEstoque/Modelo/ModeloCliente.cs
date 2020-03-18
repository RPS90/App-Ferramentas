using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()//construtor
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.Clicpfcnpj = "";
            this.cli_RSocial = "";
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliFone = "";
            this.CliEmail = "";
            this.CliEndNumero = "";
            this.CliCidade = "";
            this.CliEstado = "";            
        }
        public ModeloCliente(int cod, string nome, string cpfcnpj, string rsocial, string cep,
            string endereco, string fone, string email, string endnumero, string cidade, string estado  )//construtor
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.Clicpfcnpj = cpfcnpj;
            this.CliRSocial = rsocial;

            this.CliCep = cep;
            this.CliEndereco = endereco;
            this.CliFone = fone;
            this.CliEmail = email;
            this.CliEndNumero = endnumero;
            this.CliCidade = cidade;
            this.CliEstado = estado;
        }
        //cli_cod
        private int cli_cod;
        public int CliCod
        {   get { return this.cli_cod; }
            set { this.cli_cod = value; }        }
        //clinome
        private String cli_nome;
        public String CliNome
        {   get { return this.cli_nome; }
            set { this.cli_nome = value; }        }
        //cpfCnpj
        private String cli_cpfcnpj;
        public String Clicpfcnpj
        {
            get { return this.cli_cpfcnpj; }
            set { this.cli_cpfcnpj = value; }
        }
        //Rsocial
        private String cli_RSocial;
        public String CliRSocial
        {
            get { return this.cli_RSocial; }
            set { this.cli_RSocial = value; }
        }

        //CEP
        private string cli_cep;
        public string CliCep
        {
            get { return this.cli_cep; }
            set { this.cli_cep = value; }
        }
        //endereco
        private string cli_endereco;
        public string CliEndereco
        {
            get { return this.cli_endereco; }
            set { this.cli_endereco = value; }
        }
        //fone
        private string cli_fone;
        public string CliFone
        {
            get { return this.cli_fone; }
            set { this.cli_fone = value; }
        }
        //email
        private string cli_email;
        public string CliEmail
        {
            get { return this.cli_email; }
            set { this.cli_email = value; }
        }
        //n° endereço
        private string cli_endnumero;
        public string CliEndNumero
        {
            get { return this.cli_endnumero; }
            set { this.cli_endnumero = value; }
        }
        //cidade
        private string cli_cidade;
        public string CliCidade
        {
            get { return this.cli_cidade; }
            set { this.cli_cidade = value; }
        }
        //estado
        private string cli_estado;
        public string CliEstado
        {
            get { return this.cli_estado; }
            set { this.cli_estado = value; }
        }
    
       

    }
}
