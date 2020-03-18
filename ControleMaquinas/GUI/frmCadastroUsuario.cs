using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BLL;
using DAL;
using Modelo;

namespace GUI
{
    public partial class frmCadastroUsuario : GUI.frmModeloDeFormularioDeCadastro
    {
        public int codigo = 0;
        public string foto = "";
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }
        private void frmCadastroUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
                this.Close();
        }
        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {//-----------------------------------------LOAD do FORM---------------------------------------------------------
            this.alteraBotoes(1);
            AtualizaTabela();
        }

        #region Botões
        private void btInserir_Click(object sender, EventArgs e)
        {//-----------------------------------------INSERIR--------------------------------------------------------------
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }
        private void btAlterar_Click(object sender, EventArgs e)
        {//-----------------------------------------ALTERAR---------------------------------------------------------------
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {//-----------------------------------------CANCELAR-------------------------------------------------------------
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        private void btLocalizar_Click(object sender, EventArgs e)
        {//-----------------------------------------LOCALIZAR---------------------------------------------------------------
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                txtNomeUsuario.Text = modelo.NomeUsuario.ToString();
                txtLogin.Text = modelo.Login.ToString();
                txtRamal.Text = modelo.Ramal.ToString();
                txtDepartamento.Text = modelo.Departamento.ToString();
                txtEmail.Text = modelo.Email.ToString();
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Foto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }
                cbEstado.Text = modelo.Estado.ToString(); //ativo-inativo
                txtDataCadastro.Text = modelo.DataCadastro.ToString();
                txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }   
        private void btExcluir_Click(object sender, EventArgs e)
        {//-----------------------------------------EXCLUIR---------------------------------------------------------------
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {//cria conexao
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);//estado original
                }
            }
            catch//caso erro
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro esta sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {//-----------------------------------------SALVAR---------------------------------------------------------------
            try
            {
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.Departamento = txtDepartamento.Text;
                modelo.NomeUsuario = txtNomeUsuario.Text;
                modelo.Login = txtLogin.Text;
                modelo.Ramal = txtRamal.Text;
                modelo.Departamento = txtDepartamento.Text;
                modelo.Email = txtEmail.Text;
                modelo.Estado = cbEstado.Text;
                modelo.DataCadastro = DateTime.Now.ToString();
                modelo.UltimaAlteracao = DateTime.Now.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                if (this.operacao == "inserir")
                {
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.AdicionarAoHistorico("Usuário", txtNomeUsuario.Text);
                }
                else
                {
                    modelo.Codigo = Convert.ToInt32(txtCodigo.Text);
                    if (this.foto == "Foto Original")
                    {
                        ModeloUsuario mt = bll.CarregaModeloUsuario(modelo.Codigo);
                        modelo.Foto = mt.Foto;
                    }
                    else
                    {
                        modelo.CarregaImagem(this.foto);
                    }
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.AdicionarAlteracaoAoHistorico("Usuário", txtNomeUsuario.Text);
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }        
        private void btCarregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }            
        }
        private void btRemoverFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }        
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
               
        #region Controle das TextBox        
        private void txtNomeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtNomeUsuario, "NSP");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtLogin, "");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtRamal_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtRamal, "LS");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtDepartamento, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtEmail, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion        

        #region Métodos
        public void LimpaTela()
        {
            txtDepartamento.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtNomeUsuario.Clear();
            txtRamal.Clear();
            txtDepartamento.Clear();
            this.foto = ""; //apaga foto
            pbFoto.Image = null; //apaga foto
            txtDataCadastro.Clear();
            txtUltimaAlteracao.Clear();
            AtualizaTabela();
        }
        private void AtualizaTabela()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                dgvDados.DataSource = bll.Localizar("");
            }
            catch (Exception erros)
            {
                MessageBox.Show(erros.Message);
            }
        }
        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
            if (codigo != 0)
            {
                this.foto = ""; //apaga foto
                pbFoto.Image = null; //apaga foto
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(codigo);
                txtCodigo.Text = modelo.Codigo.ToString();
                txtNomeUsuario.Text = modelo.NomeUsuario.ToString();
                txtLogin.Text = modelo.Login.ToString();
                txtRamal.Text = modelo.Ramal.ToString();
                txtDepartamento.Text = modelo.Departamento.ToString();
                txtEmail.Text = modelo.Email.ToString();
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Foto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                }
                catch { }
                cbEstado.Text = modelo.Estado.ToString(); //ativo-inativo
                txtDataCadastro.Text = modelo.DataCadastro.ToString();
                txtUltimaAlteracao.Text = modelo.UltimaAlteracao.ToString();
                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
        }
        #endregion
    }//class
}//namespace