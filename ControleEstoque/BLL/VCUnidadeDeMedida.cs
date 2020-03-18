using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;

namespace BLL
{
    public class BLLUnidadeDeMedida
    {
        private CADConexao conexao;
        public BLLUnidadeDeMedida(CADConexao cx)
        {
            this.conexao = cx;
        }
        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }
                        
            CADUnidadeDeMedida DALobj = new CADUnidadeDeMedida(conexao);
            DALobj.Incluir(modelo);
        }
        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            if (modelo.UmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório");
            }
            if (modelo.UmedNome.Trim().Length == 0)
            {
                throw new Exception("O nome da unidade de medida é obrigatório");
            }

            CADUnidadeDeMedida DALobj = new CADUnidadeDeMedida(conexao);
            DALobj.Alterar(modelo);
        }
        public void Excluir(int codigo)
        {
            CADUnidadeDeMedida DALobj = new CADUnidadeDeMedida(conexao);
            DALobj.Excluir(codigo);
        }
        public DataTable Localizar(String valor)
        {
            CADUnidadeDeMedida DALobj = new CADUnidadeDeMedida(conexao);
            return DALobj.Localizar(valor);
        }
        public int VerificaUnidadeDeMedida(String valor) //0 - não existe || numero > 0 existe
        {
            CADUnidadeDeMedida DALobj = new CADUnidadeDeMedida(conexao);
            return DALobj.VerificaUnidadeDeMedida(valor);
        }
        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            CADUnidadeDeMedida DALobj = new CADUnidadeDeMedida(conexao);
            return DALobj.CarregaModeloUnidadeDeMedida(codigo);
        }
    }
}
