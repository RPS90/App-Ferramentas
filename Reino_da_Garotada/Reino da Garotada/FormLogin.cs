using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Reino_da_Garotada
{
    public partial class FormLogin : Form
    {
        public static string conexaoString = Classedall.conexaoString;
        public OleDbCommand cmd = Classedall.cmd;
        public OleDbConnection conn = Classedall.conn;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonAcessar_Click(object sender, EventArgs e)
        {
            AcessarSistema();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do programa?", " Reino da Garotada", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void textBoxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AcessarSistema();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível executar o comando solicitado.",
                    "Hotel Rural Vale das Nascentes | Sistema de Controle Interno",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }
        private void AcessarSistema()
        {
            //Usuario adiministrador
            string adiministrador = "admin", senha = "admin";
            bool verifica = true;
            if (textBoxUsuario.Text == adiministrador && textBoxSenha.Text == senha)
            {
                verifica = true;
            }
            else
            {
                verifica = false;
            }
            try
            {
                conn.ConnectionString = conexaoString;
                cmd.Connection = conn;
                cmd.CommandText = "Select * from TB_Funcionarios where txtLogin = '" + textBoxUsuario.Text + "' and txtSenha = '" + textBoxSenha.Text + "';";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                var dr = cmd.ExecuteReader();
                if (dr.Read() || verifica == true)
                {
                    FormPrincipal principal = new FormPrincipal();
                    principal.Show();
                    this.Hide();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha digitados estão incorretos !", "Reino da garotada");
                    textBoxSenha.Clear();
                    textBoxUsuario.Clear();
                    textBoxUsuario.Focus();
                    conn.Close();
                }
            }
            catch (OleDbException dr)
            {
                MessageBox.Show("Algo inesperado deu errado ! \n\nPor favor tente novamente mais tarde !" + dr.ToString());
                this.Close();
                conn.Close();
            }
        }

        private void textBoxUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AcessarSistema();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    Application.Exit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível executar o comando solicitado.",
                    "Hotel Rural Vale das Nascentes | Sistema de Controle Interno",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
