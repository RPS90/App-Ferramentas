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
    public partial class CadastrarUsuarios : System.Web.UI.Page
    {
        #region MySqlConnection Connection and Page Lode
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {   
            lblDateTime.Text = DateTime.Now.ToShortDateString();
            try
            {
                if (!Page.IsPostBack)
                {
                    BindGridView();                    
                }
            }catch (Exception ex){ShowMessage(ex.Message);}
            PopularComboBox();        
        }
        #endregion
        #region show message       
        // This function is used for show message.
        void ShowMessage(string msg)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('" + msg + "');</script>");
        }      
        // This Function is used TextBox Empty.        
        void clear()
        {
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;  
            txtNome.Focus();
        }
        #endregion
        #region bind data to GridView
        private void PopularComboBox()
        {
           
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(
                    "select codigo_unidade, numero_unidade, nome_entidade from tb_info_unidades where numero_entidade = '"+ ddlEstado.SelectedValue +"' ORDER BY numero_unidade DESC;", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                ddlCodigo_unidade.DataTextField = "numero_unidade";
                ddlCodigo_unidade.DataValueField = "codigo_unidade";
                ddlCodigo_unidade.DataSource = ds;
                ddlCodigo_unidade.DataBind();                          
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
                    "select codigo_usuario,nome,matricula,codigo_unidade from tb_info_usuarios ORDER BY nome DESC;", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                GridViewStudent.DataSource = ds;
                GridViewStudent.DataBind();
                lbltotalcount.Text = GridViewStudent.Rows.Count.ToString();
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
        #endregion
        #region Insert Data
        // this code used to Student Data insert in MYSQL Database        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string datatempo = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                 "insert into tb_info_usuarios (nome,matricula,codigo_unidade,banco_agencia,banco_conta,convenio_fenag_rdc,convenio_outro,data_alteracao,data_cadastro,data_nascimento,doc_cpf,doc_rg,email,email_caixa,endereco_bairro," +
                  "endereco_cep,endereco_cidade,endereco_complemento,endereco_numero,endereco_rua,estado_civil,fone_celular,fone_comer,fone_ramal," +
                  "fone_residencial,funcao,lotacao,nivel_acesso,nome_conjugue,preferencia_contato,sexo,situacao,super_intendencia,tamanho_camisa,usr_senha" +
                  ") values (@nome,@matricula,@codigo_unidade,@banco_agencia,@banco_conta, @convenio_fenag_rdc,@convenio_outro,@data_alteracao,@data_cadastro,@data_nascimento,@doc_cpf,@doc_rg,@email,@email_caixa,@endereco_bairro," +
                  "@endereco_cep,@endereco_cidade,@endereco_complemento,@endereco_numero,@endereco_rua,@estado_civil,@fone_celular,@fone_comer,@fone_ramal," +
                  "@fone_residencial,@funcao,@lotacao,@nivel_acesso,@nome_conjugue,@preferencia_contato,@sexo,@situacao,@super_intendencia,@tamanho_camisa,@usr_senha)", conn);

                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@codigo_unidade", Convert.ToInt32(ddlCodigo_unidade.SelectedValue));//INT, ddl pra escolher a unidade!             
                cmd.Parameters.AddWithValue("@banco_agencia", txtBanco_agencia.Text);
                cmd.Parameters.AddWithValue("@banco_conta", txtBanco_conta.Text);
                cmd.Parameters.AddWithValue("@convenio_fenag_rdc", ddlConvenio_fenag_rdc.Text); //ddl Sim ou não
                cmd.Parameters.AddWithValue("@convenio_outro", txtConvenio_outro.Text);
                cmd.Parameters.AddWithValue("@data_alteracao", datatempo); //datetime
                cmd.Parameters.AddWithValue("@data_cadastro", datatempo);//datetime
                cmd.Parameters.AddWithValue("@data_nascimento", datatempo); //==========trocar
                cmd.Parameters.AddWithValue("@doc_cpf", txtDoc_cpf.Text);
                cmd.Parameters.AddWithValue("@doc_rg", txtDoc_rg.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@email_caixa", txtEmail_caixa.Text);
                cmd.Parameters.AddWithValue("@endereco_bairro", txtEndereco_bairro.Text);
                cmd.Parameters.AddWithValue("@endereco_cep", txtEndereco_cep.Text);
                cmd.Parameters.AddWithValue("@endereco_cidade", txtEndereco_cidade.Text); //Vai por campo de seleção? ou tudo na mão mesmo?
                cmd.Parameters.AddWithValue("@endereco_complemento", txtEndereco_complemento.Text);
                cmd.Parameters.AddWithValue("@endereco_numero", txtEndereco_numero.Text);
                cmd.Parameters.AddWithValue("@endereco_rua", txtEndereco_rua.Text);
                cmd.Parameters.AddWithValue("@estado_civil", ddlEstado_civil.Text); //ddl -> Solteiro,Casado,Viúvo
                cmd.Parameters.AddWithValue("@fone_celular", txtFone_celular.Text); //montar máscara
                cmd.Parameters.AddWithValue("@fone_comer", txtFone_comer.Text); //mascara
                cmd.Parameters.AddWithValue("@fone_ramal", txtFone_ramal.Text); //2 digitos
                cmd.Parameters.AddWithValue("@fone_residencial", txtFone_residencial.Text);
                cmd.Parameters.AddWithValue("@funcao", txtFuncao.Text);
                cmd.Parameters.AddWithValue("@lotacao", txtLotacao.Text); //nao sei oq é isso
                cmd.Parameters.AddWithValue("@nivel_acesso", Convert.ToInt32(ddlNivel_acesso.SelectedValue)); //número
                cmd.Parameters.AddWithValue("@nome_conjugue", txtNome_conjugue.Text);
                cmd.Parameters.AddWithValue("@preferencia_contato", ddlPreferencia_contato.Text); //drop down, tel ou email
                cmd.Parameters.AddWithValue("@sexo", ddlSexo.Text); //ddl Másculino feminino, vai ter 'gênero' tbm? ---avisar
                cmd.Parameters.AddWithValue("@situacao", Convert.ToInt32(ddlSituacao.SelectedValue)); //ddl ATIVO OU APOSENTADO!
                cmd.Parameters.AddWithValue("@super_intendencia", txtSuper_intendencia.Text);
                cmd.Parameters.AddWithValue("@tamanho_camisa", ddlTamanho_camisa.Text); //P,M,G,GG
                cmd.Parameters.AddWithValue("@usr_senha", txtUsr_senha.Text); //usar máscara de senha

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
        #endregion 
        #region SelectedIndexChanged        
        // this code used to GridViewRow SelectedIndexChanged value show textBox        
        protected void GridViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewStudent.SelectedRow;
            lblcodigo_usuario.Text = row.Cells[1].Text;
            txtNome.Text = row.Cells[2].Text;
            txtMatricula.Text = row.Cells[3].Text;
            ddlCodigo_unidade.Text = row.Cells[4].Text;

            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
        }
        #endregion
        #region Delete Student Data        
        // This code used to GridViewStudent_RowDeleting Student Data Delete        
        protected void GridViewStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                conn.Open();
                int codigo_usuario = Convert.ToInt32(GridViewStudent.DataKeys[e.RowIndex].Value);
                MySqlCommand cmd = new MySqlCommand("Delete From student where codigo_usuario='" + codigo_usuario + "'", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage("Student Data Delete Successfully......!");
                GridViewStudent.EditIndex = -1;
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
        #endregion
        #region student data update        
        // This code used to student data update       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string codigo_usuario = lblcodigo_usuario.Text;              
                MySqlCommand cmd = new MySqlCommand(
                    "update tb_info_usuarios Set nome=@nome, matricula=@matricula, codigo_unidade=@codigo_unidade where codigo_usuario=@codigo_usuario"
                    , conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@codigo_unidade", Convert.ToInt32(ddlCodigo_unidade.SelectedValue));                
                cmd.Parameters.AddWithValue("codigo_usuario", codigo_usuario);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage("Student Data update Successfully......!");
                GridViewStudent.EditIndex = -1;
                BindGridView();
                btnUpdate.Visible = false;
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
        #endregion
        #region textbox clear
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion




    }
}

/*BACKUP
public partial class Student : System.Web.UI.Page
    {
        #region MySqlConnection Connection and Page Lode
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
            catch (Exception ex)
            {
                ShowMessage(ex.Message);
            }
        }
        #endregion
        #region show message       
        // This function is used for show message.
        void ShowMessage(string msg)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('" + msg + "');</script>");
        }      
        // This Function is used TextBox Empty.
        
        void clear()
        {
            txtNome.Text = string.Empty;
            txtMatricula.Text = string.Empty;  
            txtNome.Focus();
        }
        #endregion
        #region bind data to GridViewStudent
        private void BindGridView()
        { 
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                MySqlCommand cmd = new MySqlCommand(
                    "select codigo_usuario,nome,matricula,codigo_unidade from tb_info_usuarios ORDER BY nome DESC;", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                GridViewStudent.DataSource = ds;
                GridViewStudent.DataBind();
                lbltotalcount.Text = GridViewStudent.Rows.Count.ToString();
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
        #endregion
        #region Insert Data
        // this code used to Student Data insert in MYSQL Database        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string datatempo = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "insert into tb_info_usuarios (nome,matricula,codigo_unidade" + 
                    //================VIRGULA
                    //"assinatura,banco_agencia,banco_conta,banco_data,banco_local,banco_operacao," +                   
                    //"convenio_fenag_rdc,convenio_outro,data_alteracao,data_cadastro,data_nascimento,doc_cpf,doc_rg,email,email_caixa,endereco_bairro," +
                    //"endereco_cep,endereco_cidade,endereco_complemento,endereco_numero,endereco_rua,estado_civil,fone_celular,fone_comer,fone_ramal," +
                    //"fone_residencial,funcao,lotacao,nivel_acesso,nome_conjugue,preferencia_contato,sexo,situacao,super_intendencia,tamanho_camisa,usr_senha" +
                    ") values (@nome,@matricula,@codigo_unidade)"
                    //======================Parenteses
                    //"@assinatura,@banco_agencia,@banco_conta,@banco_data,@banco_local,@banco_operacao," +
                    //"@convenio_fenag_rdc,@convenio_outro,@data_alteracao,@data_cadastro,@data_nascimento,@doc_cpf,@doc_rg,@email,@email_caixa,@endereco_bairro,"+
                    //"@endereco_cep,@endereco_cidade,@endereco_complemento,@endereco_numero,@endereco_rua,@estado_civil,@fone_celular,@fone_comer,@fone_ramal,"+
                    //"@fone_residencial,@funcao,@lotacao,@nivel_acesso,@nome_conjugue,@preferencia_contato,@sexo,@situacao,@super_intendencia,@tamanho_camisa,@usr_senha)" 
                    , conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@codigo_unidade", Convert.ToInt32(ddlCodigo_unidade.SelectedValue));//INT, ddl pra escolher a unidade!
              //cmd.Parameters.AddWithValue("@assinatura", txtAssinatura.Text);      
              //cmd.Parameters.AddWithValue("@banco_agencia", txtBanco_agencia.Text);
              //cmd.Parameters.AddWithValue("@banco_conta", txtBanco_conta.Text);
              //cmd.Parameters.AddWithValue("@banco_data", ???????.Text);
              //cmd.Parameters.AddWithValue("@banco_local", ????.Text);
              //cmd.Parameters.AddWithValue("@banco_operacao", ??????.Text);
              //cmd.Parameters.AddWithValue("@codigo_usuario", txtEmail.Text);
              //cmd.Parameters.AddWithValue("@convenio_fenag_rdc", ddlConvenio_fenag_rdc.Text); //ddl Sim ou não
              //cmd.Parameters.AddWithValue("@convenio_outro", txtConvenio_outro.Text);
              //cmd.Parameters.AddWithValue("@data_alteracao", datatempo); //datetime
              //cmd.Parameters.AddWithValue("@data_cadastro",datatempo);//datetime
              //cmd.Parameters.AddWithValue("@data_nascimento", txtData_nascimento.Text);
              //cmd.Parameters.AddWithValue("@doc_cpf", txtDoc_cpf.Text);
              //cmd.Parameters.AddWithValue("@doc_rg", txtDoc_rg.Text);
              //cmd.Parameters.AddWithValue("@email", txtEmail.Text);
              //cmd.Parameters.AddWithValue("@email_caixa", txtEmail_caixa.Text);
              //cmd.Parameters.AddWithValue("@endereco_bairro", txtEndereco_bairro.Text);
              //cmd.Parameters.AddWithValue("@endereco_cep", txtEndereco_cep.Text);
              //cmd.Parameters.AddWithValue("@endereco_cidade", txtEndereco_cidade.Text); //Vai por campo de seleção? ou tudo na mão mesmo?
              //cmd.Parameters.AddWithValue("@endereco_complemento", txtEndereco_complemento.Text);
              //cmd.Parameters.AddWithValue("@endereco_numero", txtEndereco_numero.Text);
              //cmd.Parameters.AddWithValue("@endereco_rua", txtEndereco_rua.Text);
              //cmd.Parameters.AddWithValue("@estado_civil", ddlEstado_civil.Text); //ddl -> Solteiro,Casado,Viúvo
              //cmd.Parameters.AddWithValue("@fone_celular", txtFone_celular.Text); //montar máscara
              //cmd.Parameters.AddWithValue("@fone_comer", txtFone_comer.Text); //mascara
              //cmd.Parameters.AddWithValue("@fone_ramal", txtFone_ramal.Text); //2 digitos
              //cmd.Parameters.AddWithValue("@fone_residencial", txtFone_residencial.Text);
              //cmd.Parameters.AddWithValue("@funcao", txtFuncao.Text);
              //cmd.Parameters.AddWithValue("@lotacao", txtLotacao.Text); //nao sei oq é isso
              //cmd.Parameters.AddWithValue("@nivel_acesso", Convert.ToInt32(ddlNivel_acesso.SelectedValue)); //número
              //cmd.Parameters.AddWithValue("@nome_conjugue", txtNome_conjugue.Text);
              //cmd.Parameters.AddWithValue("@preferencia_contato", ddlPreferencia_contato.Text); //drop down, tel ou email
              //cmd.Parameters.AddWithValue("@sexo", ddlSexo.Text); //ddl Másculino feminino, vai ter 'gênero' tbm? ---avisar
              //cmd.Parameters.AddWithValue("@situacao", Convert.ToInt32(ddlSituacao.SelectedValue)); //ddl ATIVO OU APOSENTADO!
              //cmd.Parameters.AddWithValue("@super_intendencia", txtSuper_intendencia.Text);
              //cmd.Parameters.AddWithValue("@tamanho_camisa", ddlTamanho_camisa.Text); //P,M,G,GG
              //cmd.Parameters.AddWithValue("@usr_senha", txtUsr_senha.Text); //usar máscara de senha
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
        #endregion 
        #region SelectedIndexChanged        
        // this code used to GridViewRow SelectedIndexChanged value show textBox        
        protected void GridViewStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridViewStudent.SelectedRow;
            lblcodigo_usuario.Text = row.Cells[2].Text;
            txtNome.Text = row.Cells[3].Text;
            txtMatricula.Text = row.Cells[4].Text;
            ddlCodigo_unidade.Text = row.Cells[5].Text;

            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
        }
        #endregion
        #region Delete Student Data        
        // This code used to GridViewStudent_RowDeleting Student Data Delete        
        protected void GridViewStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                conn.Open();
                int codigo_usuario = Convert.ToInt32(GridViewStudent.DataKeys[e.RowIndex].Value);
                MySqlCommand cmd = new MySqlCommand("Delete From student where codigo_usuario='" + codigo_usuario + "'", conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage("Student Data Delete Successfully......!");
                GridViewStudent.EditIndex = -1;
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
        #endregion
        #region student data update        
        // This code used to student data update       
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string codigo_usuario = lblcodigo_usuario.Text;              
                MySqlCommand cmd = new MySqlCommand(
                    "update tb_info_usuarios Set nome=@nome, matricula=@matricula, codigo_unidade=@codigo_unidade where codigo_usuario=@codigo_usuario"
                    , conn);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
                cmd.Parameters.AddWithValue("@codigo_unidade", Convert.ToInt32(ddlCodigo_unidade.SelectedValue));                
                cmd.Parameters.AddWithValue("codigo_usuario", codigo_usuario);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                ShowMessage("Student Data update Successfully......!");
                GridViewStudent.EditIndex = -1;
                BindGridView();
                btnUpdate.Visible = false;
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
        #endregion
        #region textbox clear
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion




    }
*/