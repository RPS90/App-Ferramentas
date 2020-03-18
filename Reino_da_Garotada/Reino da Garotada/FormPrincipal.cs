using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reino_da_Garotada
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBoxSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }                      
        }

        private void buttonCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (!Classedall.VerificaCurso())
            {
                if (MessageBox.Show("Não tem nenhum curso cadastrado ! \n Deseja cadastrar agora ? ", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    FormCadastrarCurso cadastrarCurso = new FormCadastrarCurso();
                    cadastrarCurso.Show();
                }
                else
                {
                    
                }
            }
            else
            {
                FormCadastrarAluno cadastrarAluno = new FormCadastrarAluno();
                cadastrarAluno.Show();
            }
        }

        private void stripMenuCadastrarAluno_Click(object sender, EventArgs e)
        {
            if (!Classedall.VerificaCurso())
            {
                if (MessageBox.Show("Não tem nenhum curso cadastrado ! \n Deseja cadastrar agora ? ", "Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    FormCadastrarCurso cadastrarCurso = new FormCadastrarCurso();
                    cadastrarCurso.Show();
                }
                else
                {

                }
            }
            else
            {
                FormCadastrarAluno cadastrarAluno = new FormCadastrarAluno();
                cadastrarAluno.Show();
            }
        }

        private void buttonCadastrarCurso_Click(object sender, EventArgs e)
        {
            FormCadastrarCurso cadastrarCurso = new FormCadastrarCurso();
            cadastrarCurso.Show();
        }

        private void buttonPesquisarNomeAluno_Click(object sender, EventArgs e)
        {
            FormAlterarAluno pesquisarnome = new FormAlterarAluno();
            pesquisarnome.Show();
            pesquisarnome.rbtPesqNome.Checked = true;
        }

        private void buttonCadastrarFuncionário_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario cadastrarFuncionario = new FormCadastrarFuncionario();
            cadastrarFuncionario.Show();
        }

        private void stripMenuCadastrarCurso_Click(object sender, EventArgs e)
        {
            FormCadastrarCurso cadastrarCurso = new FormCadastrarCurso();
            cadastrarCurso.Show();
        }

        private void stripMenuCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            FormCadastrarFuncionario cadastrarFuncionario = new FormCadastrarFuncionario();
            cadastrarFuncionario.Show();
        }

        private void tripMenuPesqNome_Click(object sender, EventArgs e)
        {
            FormAlterarAluno pesquisarAluno = new FormAlterarAluno();
            pesquisarAluno.Show();
            pesquisarAluno.rbtPesqNome.Checked = true;
        }

        private void stripMenuPesqCurso_Click(object sender, EventArgs e)
        {
            FormAlterarAluno pesquisarAlunoCurso = new FormAlterarAluno();
            pesquisarAlunoCurso.Show();
            //pesquisarAlunoCurso.rdbPesqCurso.Checked = true;
        }

        private void stripMenuPesqIdentidade_Click(object sender, EventArgs e)
        {
            FormAlterarAluno pesquisaAlunoIdentidade = new FormAlterarAluno();
            pesquisaAlunoIdentidade.Show();
            pesquisaAlunoIdentidade.rdbPesqRG.Checked = true;
        }

        private void stripMenuPesqMatricula_Click(object sender, EventArgs e)
        {
            FormAlterarAluno pesquisaAlunoMatricula = new FormAlterarAluno();
            pesquisaAlunoMatricula.Show();
            pesquisaAlunoMatricula.rdbNMatricula.Checked = true;
        }

        private void buttonPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            FormAlterarFuncionario pesquisarFuncionario = new FormAlterarFuncionario();
            pesquisarFuncionario.Show();
        }

        private void stripMenuFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

















































































        }
    }
}
