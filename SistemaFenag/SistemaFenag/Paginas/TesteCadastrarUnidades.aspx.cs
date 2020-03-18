using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace SistemaFenag
{
    public partial class CadastrarUnidades : System.Web.UI.Page
    {        
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);        
        protected void Page_Load(object sender, EventArgs e)
        {           
            try
            {
                if (!Page.IsPostBack)
                {
                    BindGridView();
                }
            }
            catch (Exception ex) { ShowMessage(ex.Message); }
            PopularComboBox();
        }          
        void ShowMessage(string msg)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('" + msg + "');</script>");
        } 
        void clear()
        {
           // txtNome.Text = string.Empty;
         //   txtMatricula.Text = string.Empty;
            //txtNome.Focus();
        }
        private void PopularComboBox()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(
                    "select nome,codigo_usuario from tb_info_usuarios where codigo_unidade = '" +"1"+ "' ORDER BY numero_unidade DESC;", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                ddlPresidente.DataTextField = "nome";
                ddlPresidente.DataValueField = "codigo_usuario";
                ddlPresidente.DataSource = ds;
                ddlPresidente.DataBind();
            }
            catch (MySqlException ex)
            {
                ShowMessage(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void BindGridView()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(
                    "select codigo_unidade,nome_entidade, numero_entidade from tb_info_unidades ORDER BY codigo_unidade DESC;", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                GridViewDados.DataSource = ds;
                GridViewDados.DataBind();
                //lbltotalcount.Text = GridViewDados.Rows.Count.ToString();
            }
            catch (MySqlException ex)
            {
                ShowMessage(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
       
 
        protected void btSalvar_Click(object sender, EventArgs e)
        {
            string datatempo = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                 "insert into tb_info_usuarios (numero_entidade,numero_rubrica,numero_unidade,endereco_cidade,endereco_nome,"+
                 "estatus,endereco_uf,tipo,nome_entidade,nome_rubrica,nome_unidade,"+
                 "endereco_cep,endereco_numero,endereco_bairro,cnpj,telefone1,telefone1_ramal,telefone2,"+
                 "telefone2_ramal,endereco_complemento,codigo_presidente,email"+
                 ") values (@numero_entidade,@numero_rubrica,@numero_unidade,@endereco_cidade,@endereco_nome," +
                 "@estatus,@endereco_uf,@tipo,@nome_entidade,@nome_rubrica,@nome_unidade," +
                 "@endereco_cep,@endereco_numero,@endereco_bairro,@cnpj,@telefone1,@telefone1_ramal,@telefone2," +
                 "@telefone2_ramal,@endereco_complemento,@codigo_presidente,@email);", conn);

                cmd.Parameters.AddWithValue("@numero_entidade", txtnumero_entidade.Text);
                cmd.Parameters.AddWithValue("@numero_rubrica", txtnumero_rubrica.Text);
                cmd.Parameters.AddWithValue("@numero_unidade", txtnumero_unidade.Text);
                cmd.Parameters.AddWithValue("@endereco_cidade", txtendereco_cidade.Text);
                cmd.Parameters.AddWithValue("@endereco_nome", txtendereco_nome.Text);
                cmd.Parameters.AddWithValue("@estatus", txtestatus.Text);
                cmd.Parameters.AddWithValue("@endereco_uf", txtendereco_uf);
                cmd.Parameters.AddWithValue("@tipo", Convert.ToInt32(ddltipo.SelectedValue));
                cmd.Parameters.AddWithValue("@nome_entidade", txtnome_entidade.Text);
                cmd.Parameters.AddWithValue("@nome_rubrica", txtnome_rubrica.Text);
                cmd.Parameters.AddWithValue("@nome_unidade", txtnome_unidade.Text);
                cmd.Parameters.AddWithValue("@endereco_cep", txtendereco_cep.Text);
                cmd.Parameters.AddWithValue("@endereco_numero", txtendereco_numero.Text);
                cmd.Parameters.AddWithValue("@endereco_bairro", txtendereco_bairro.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtcnpj.Text);
                cmd.Parameters.AddWithValue("@telefone1", txttelefone1.Text);
                cmd.Parameters.AddWithValue("@telefone1_ramal", txttelefone1_ramal.Text);
                cmd.Parameters.AddWithValue("@telefone2", txttelefone2.Text);
                cmd.Parameters.AddWithValue("@telefone2_ramal", txttelefone2_ramal.Text);
                cmd.Parameters.AddWithValue("@endereco_complemento", txtendereco_complemento.Text);
                cmd.Parameters.AddWithValue("@codigo_presidente", Convert.ToInt32(ddlPresidente.SelectedValue));
                cmd.Parameters.AddWithValue("@email", txtemail.Text);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage("Cadastrado com sucesso");
                clear();
                BindGridView();
            }
            catch (MySqlException ex)
            {
                ShowMessage(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        protected void GridViewDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewDados.SelectedRow;
           // lblcodigo_usuario.Text = row.Cells[1].Text;
           // txtNome.Text = row.Cells[2].Text;
        //    txtMatricula.Text = row.Cells[3].Text;
           // ddlCodigo_unidade.Text = row.Cells[4].Text;

            btSalvar.Visible = false;
           btAlterar.Visible = true;
        }
   
        protected void GridViewDados_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                conn.Open();
                int codigo_usuario = Convert.ToInt32(GridViewDados.DataKeys[e.RowIndex].Value);
                MySqlCommand cmd = new MySqlCommand("Delete From  where codigo_usuario='" + codigo_usuario + "'", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage(" Data Delete Successfully......!");
                GridViewDados.EditIndex = -1;
                BindGridView();
            }
            catch (MySqlException ex)
            {
                ShowMessage(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }  
        protected void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
"update tb_info_usuarios Set numero_entidade=@numero_entidade,numero_rubrica=@numero_rubrica,numero_unidade=@numero_unidade," +
"endereco_cidade=@endereco_cidade,endereco_nome=@endereco_nome,estatus=@estatus,endereco_uf=@endereco_uf,tipo=@tipo," +
"nome_entidade=@nome_entidade,nome_rubrica=@nome_rubrica,nome_unidade=@nome_unidade,endereco_cep=@endereco_cep," +
"endereco_numero=@endereco_numero,endereco_bairro=@endereco_bairro,cnpj=@cnpj,telefone1=@telefone1,telefone1_ramal=@telefone1_ramal," +
"telefone2=@telefone2,telefone2_ramal=@telefone2_ramal,endereco_complemento=@endereco_complemento,codigo_presidente=@codigo_presidente,email=@email;"
, conn);
                cmd.Parameters.AddWithValue("@numero_entidade", txtnumero_entidade.Text);
                cmd.Parameters.AddWithValue("@numero_rubrica", txtnumero_rubrica.Text);
                cmd.Parameters.AddWithValue("@numero_unidade", txtnumero_unidade.Text);
                cmd.Parameters.AddWithValue("@endereco_cidade", txtendereco_cidade.Text);
                cmd.Parameters.AddWithValue("@endereco_nome", txtendereco_nome.Text);
                cmd.Parameters.AddWithValue("@estatus", txtestatus.Text);
                cmd.Parameters.AddWithValue("@endereco_uf", txtendereco_uf);
                cmd.Parameters.AddWithValue("@tipo", Convert.ToInt32(ddltipo.SelectedValue));
                cmd.Parameters.AddWithValue("@nome_entidade", txtnome_entidade.Text);
                cmd.Parameters.AddWithValue("@nome_rubrica", txtnome_rubrica.Text);
                cmd.Parameters.AddWithValue("@nome_unidade", txtnome_unidade.Text);
                cmd.Parameters.AddWithValue("@endereco_cep", txtendereco_cep.Text);
                cmd.Parameters.AddWithValue("@endereco_numero", txtendereco_numero.Text);
                cmd.Parameters.AddWithValue("@endereco_bairro", txtendereco_bairro.Text);
                cmd.Parameters.AddWithValue("@cnpj", txtcnpj.Text);
                cmd.Parameters.AddWithValue("@telefone1", txttelefone1.Text);
                cmd.Parameters.AddWithValue("@telefone1_ramal", txttelefone1_ramal.Text);
                cmd.Parameters.AddWithValue("@telefone2", txttelefone2.Text);
                cmd.Parameters.AddWithValue("@telefone2_ramal", txttelefone2_ramal.Text);
                cmd.Parameters.AddWithValue("@endereco_complemento", txtendereco_complemento.Text);
                cmd.Parameters.AddWithValue("@codigo_presidente", Convert.ToInt32(ddlPresidente.SelectedValue));
                cmd.Parameters.AddWithValue("@email", txtemail.Text);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage(" Data update Successfully......!");
                GridViewDados.EditIndex = -1;
                BindGridView();
                //btnUpdate.Visible = false;
            }
            catch (MySqlException ex)
            {
                ShowMessage(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }









    }
}
/*
numero_entidade         varchar(6) 
numero_rubrica          varchar(6) 
numero_unidade          varchar(10) 
endereco_cidade         varchar(45) 
endereco_nome           varchar(45) 
estatus                 tinyint(4) 
endereco_uf             varchar(2) 
tipo                    tinyint(4) 
nome_entidade           varchar(45) 
nome_rubrica            varchar(45) 
nome_unidade            varchar(45) 
endereco_cep            varchar(10) 
endereco_numero         varchar(45) 
endereco_bairro         varchar(45) 
cnpj                    varchar(17) 
telefone1               varchar(45) 
telefone1_ramal         varchar(45) 
telefone2               varchar(45) 
telefone2_ramal         varchar(45) 
endereco_complemento    varchar(45) 
codigo_presidente       int(11) 
email                   varchar(45)
 */
