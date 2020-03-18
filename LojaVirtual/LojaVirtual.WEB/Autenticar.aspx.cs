using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LojaVirtual.BLL;
using LojaVirtual.DAO;

namespace LojaVirtual.WEB
{
    public partial class Autenticar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMsg.Visible = false;
                lblMsg2.Visible = false;
            }
        }

        protected void btEntrar_Click(object sender, EventArgs e)
        {
            ClienteBLL clientebll = new ClienteBLL();
            CLIENTE cliente = new CLIENTE();
            clientebll.AutenticarCliente(txtEmail.Text.Trim(), txtSenha.Text.Trim());
            if (cliente != null)
            {
                Session.Add("cliente", cliente);
                cliente = null;//tira da mem
                Response.Redirect("default.aspx");
            }
            else
            { 
                lblMsg.Visible = true;
                lblMsg.Text = "Email ou senha inválido.";
            }

        }
    }
}