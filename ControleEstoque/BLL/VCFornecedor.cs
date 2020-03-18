using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{//for_nome,for_cnpj,for_cep,for_endereco,for_bairro,for_endnumero,for_fone, for_email, for_cidade, for_estado
    public class BLLFornecedor
    {
        private CADConexao conexao;
        public BLLFornecedor(CADConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloFornecedor obj)
        {
            if (obj.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }
            if (obj.ForCNPJ.Trim().Length == 0)
            {
                throw new Exception("CNPJ!");
            }
            if (obj.ForCEP.Trim().Length == 0)
            {
                throw new Exception("CEP!");
            }
            if (obj.ForEndereco.Trim().Length == 0)
            {
                throw new Exception("Endereço!");
            }
            if (obj.ForBairro.Trim().Length == 0)
            {
                throw new Exception("Bairro!");
            }
            if (obj.ForEndNumero.Trim().Length == 0)
            {
                throw new Exception("Número de endereço!");
            }
            if (obj.ForFone.Trim().Length == 0)
            {
                throw new Exception("Fone!");
            }
            if (obj.ForEmail.Trim().Length == 0)
            {
                throw new Exception("Email!");
            }
            if (obj.ForCidade.Trim().Length == 0)
            {
                throw new Exception("Cidade!");
            }
            if (obj.ForEstado.Trim().Length == 0)
            {
                throw new Exception("Estado!");
            }

            CADFornecedor DALobj = new CADFornecedor(conexao);
            DALobj.Incluir(obj);
        }
        public void Excluir(int codigo)
        {
            CADFornecedor DALobj = new CADFornecedor(conexao);
            DALobj.Excluir(codigo);
        }
        public void Alterar(ModeloFornecedor obj)
        {
            if (obj.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do Fornecedor é obrigatório");
            }
            if (obj.ForCNPJ.Trim().Length == 0)
            {
                throw new Exception("CNPJ!");
            }
            if (obj.ForCEP.Trim().Length == 0)
            {
                throw new Exception("CEP!");
            }
            if (obj.ForEndereco.Trim().Length == 0)
            {
                throw new Exception("Endereço!");
            }
            if (obj.ForBairro.Trim().Length == 0)
            {
                throw new Exception("Bairro!");
            }
            if (obj.ForEndNumero.Trim().Length == 0)
            {
                throw new Exception("Número de endereço!");
            }
            if (obj.ForFone.Trim().Length == 0)
            {
                throw new Exception("Fone!");
            }
            if (obj.ForEmail.Trim().Length == 0)
            {
                throw new Exception("Email!");
            }
            if (obj.ForCidade.Trim().Length == 0)
            {
                throw new Exception("Cidade!");
            }
            if (obj.ForEstado.Trim().Length == 0)
            {
                throw new Exception("Estado!");
            }
            if (obj.ForCod <= 0)
            {
                throw new Exception("O código do Fornecedor é obrigatório");
            }

            CADFornecedor DALobj = new CADFornecedor(conexao);
            DALobj.Alterar(obj);
        }
        public DataTable Localizar(String valor)
        {
            CADFornecedor DALobj = new CADFornecedor(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            CADFornecedor DALobj = new CADFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);
        }
    }
}
