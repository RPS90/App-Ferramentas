using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.BLL;
using LojaVirtual.DAO;

namespace LojaVirtual.ADMIN
{
    public partial class Clientes : System.Web.UI.Page
    {//start Passos para comunicação entre BD
        int codCliente = 0; //variável do código
        ClienteBLL clientesBLL = new ClienteBLL(); //Business 
        ClienteDAO clientes = new ClienteDAO(); // DATA ACCESS 
        CLIENTE cliente = new CLIENTE();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) //de praxe
            { BuscarClientes(); }
        }

        protected void btSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodCliente.Text != string.Empty)
            { AtualizarCliente(); }
            else
            {//Decimal.Parse(
                //cliente.IDT_CLIENTE = int.Parse(txtCodCliente.Text);
                cliente.NOME = txtNomeCliente.Text;
                cliente.EMAIL = txtEmailCliente.Text;
                cliente.SENHA = txtSenhaCliente.Text;
                cliente.ENDERECO = txtEnderecoCliente.Text;
                clientesBLL.Add(cliente);
                clientesBLL.SaveChanges();
                BuscarClientes();
                clientesBLL = null;
                cliente = null;
                LimparCampos();

            }//else
            
        }//btSalvar
        //meus métodos
        public void AtualizarCliente()
        {//codCliente é a variável lá de cima
            codCliente = int.Parse(txtCodCliente.Text);
            cliente = clientes.Find(cat => cat.IDT_CLIENTE == codCliente).First<CLIENTE>();
            cliente.NOME = txtNomeCliente.Text;
            cliente.EMAIL = txtEmailCliente.Text;
            cliente.SENHA = txtSenhaCliente.Text;
            cliente.ENDERECO = txtEnderecoCliente.Text;
            clientes.Update(cliente);
            clientes.SaveChanges();
            BuscarClientes();
            clientes = null;
            cliente = null;
            LimparCampos();

        }
        public void LimparCampos()
        { 
            txtCodCliente.Text = "";
            txtEmailCliente.Text = "";
            txtEnderecoCliente.Text = "";
            txtNomeCliente.Text = "";
            txtSenhaCliente.Text = "";              
            btSalvar.Text = "Salvar";
            lblMsg.Text = "<h1>Gerenciamento de CLIENTES</h1>";
        }
        public void BuscarClientes()
        {
            grvClientes.DataSource = clientesBLL.GetAll();
            grvClientes.DataBind();
        }
        protected void grvClientes_selectedIndexChanged(object sender, EventArgs e)
        {
            btSalvar.Text = "Atualizar";
            lblMsg.Text = "<h1>Gerenciamento de CLIENTES : alterando</h1>";
            codCliente = (int)grvClientes.SelectedValue;
            cliente = clientes.Find(cli => cli.IDT_CLIENTE == codCliente).First<CLIENTE>();
            txtCodCliente.Text = cliente.IDT_CLIENTE.ToString();
            txtNomeCliente.Text = cliente.NOME;
            txtEmailCliente.Text = cliente.EMAIL;
            txtSenhaCliente.Text = cliente.SENHA;
            txtEnderecoCliente.Text = cliente.ENDERECO;
            clientes = null;
            cliente = null;                 
        }

        protected void grvClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {//só chama qnd clica em excluir
            codCliente = int.Parse(grvClientes.DataKeys[e.RowIndex].Value.ToString());
            cliente = clientes.Find(cli => cli.IDT_CLIENTE == codCliente).First<CLIENTE>();
            clientes.Delete(cliente);
            clientes.SaveChanges();
            clientes = null;
            cliente = null;
            BuscarClientes();
        }

        protected void btExcluir_Click(object sender, EventArgs e)
        {

        }
        

    }
}