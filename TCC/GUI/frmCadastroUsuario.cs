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
            PopularComboBox();            
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
                cbDepartamento.Text = modelo.Departamento.ToString();
                txtEmail.Text = modelo.Email.ToString();
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Foto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                } catch { }
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
        private void btSalvar_Click(object sender, EventArgs e)
        {//------------------------------------------------------------------------------------------------------BOTAO SALVAR
            Salvar();
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void btfrmCadastroInformacoes_Click(object sender, EventArgs e)
        {
            frmCadastroInformacoes f = new frmCadastroInformacoes();
            f.ShowDialog();
            PopularComboBox();
            f.Dispose();
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
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormMenu organizacao = new FormMenu();
            organizacao.ControleDasTextBoxes(sender, e, txtEmail, "S");//Letras,Números,Espaço,Simbolos,Pontuação
        }
        private void cbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void cbDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        #endregion        

        #region Métodos
        public void LimpaTela()
        {           
            txtEmail.Clear();
            txtLogin.Clear();
            txtNomeUsuario.Clear();
            txtRamal.Clear();           
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
                MessageBox.Show("Banco de dados não conectado\nErro: " + erros.Message);
            }
            FormMenu organizacao = new FormMenu();
            organizacao.ArrumarTabelaUSUARIOS(dgvDados);
        }
        private void PopularComboBox()
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLInformacoes bll = new BLLInformacoes(cx);
                cbDepartamento.DataSource = bll.LocalizarDepartamento("");
                cbDepartamento.DisplayMember = "departamento";
                cbDepartamento.ValueMember = "codigo";
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um erro:\n" + erro.Message);
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
                cbDepartamento.Text = modelo.Departamento.ToString();
                txtEmail.Text = modelo.Email.ToString();
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.Foto);
                    pbFoto.Image = Image.FromStream(ms);
                    this.foto = "Foto Original";
                } catch {}
                //catch (Exception error) { MessageBox.Show("Erro ao carregar a foto\nErro:" + error.Message); }
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
        private void DesvincularUsuarioDasMesas(int codigoUsuario)
        {
            if (cbEstado.Text == "INATIVO")
            {
                codigoUsuario = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLMesaUsuario bll = new BLLMesaUsuario(cx);
                    bll.ExcluirUsuario(Convert.ToInt32(codigoUsuario));
                    BLLHistorico bll2 = new BLLHistorico(cx);
                    bll2.HistoricoRegistrar("Desvincular Usuário", "Alterar descrição", codigoUsuario);
                }
                catch (Exception error) { MessageBox.Show("Banco de dados não conectado\nErro:" + error.Message); }
                //não vou por mensagem de erro, pra chegar a esse método, tem q -----arrumado
            }
        }
        private void Salvar()
        {
            try
            {
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.Departamento = Convert.ToInt32(cbDepartamento.SelectedValue);
                modelo.NomeUsuario = txtNomeUsuario.Text;
                modelo.Login = txtLogin.Text;
                modelo.Ramal = txtRamal.Text;                
                modelo.Email = txtEmail.Text;
                modelo.Estado = cbEstado.Text;
                modelo.DataCadastro = DateTime.Now.ToString();
                modelo.UltimaAlteracao = DateTime.Now.ToString();
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);

                if (this.operacao == "inserir")
                {//------------------------------------------------------------------------------------------------------SALVAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        MessageBox.Show("Não é possível efetuar um cadastro em INATIVO\nCadastre como ATIVO e Altere o Cadastro efetuado\n se é isso que deseja.");
                        this.alteraBotoes(2);
                    }
                    else //Estado ATIVO
                    {
                        modelo.CarregaImagem(this.foto);
                        bll.Incluir(modelo);
                        MessageBox.Show("Cadastro efetuado: Código " + modelo.Codigo.ToString());
                        BLLHistorico bll2 = new BLLHistorico(cx);
                        bll2.HistoricoRegistrar("Cadastrar Usuário", "Alterar descrição", modelo.Codigo);
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
                else
                {//------------------------------------------------------------------------------------------------------ALTERAR CADASTRO
                    if (cbEstado.Text == "INATIVO")
                    {
                        DialogResult dialogResult = MessageBox.Show("Alterar para INATIVO irá remove-lo\nde todas as Mesas, Tem Certeza?", "Aviso!", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
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
                            DesvincularUsuarioDasMesas(Convert.ToInt32(txtCodigo.Text));//remove e add no historico
                            this.LimpaTela();
                            this.alteraBotoes(1);
                        }
                        if (dialogResult == DialogResult.No)
                        {
                            this.alteraBotoes(2);//Volta pra alterar
                        }
                    }
                    else//está ativo
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
                        bll2.HistoricoRegistrar("Alterar Usuário", "Alterar descrição", modelo.Codigo);
                        this.LimpaTela();
                        this.alteraBotoes(1);
                    }
                }
                //this.LimpaTela();
                //this.alteraBotoes(1);//isso ta me ferrando, resolver
            }
            catch (Exception error) { MessageBox.Show("Banco de dados não conectado\nErro:" + error.Message); }
        }
        private void Excluir() //método funciona mas não é usado
        {
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
        #endregion             

  
        
    }//class
}//namespace