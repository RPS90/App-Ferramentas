using System;
using System.Windows.Forms;
using DAL;
using MySql.Data.MySqlClient;

namespace GUI
{
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }
        private void FormBackup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {  this.Close(); }
        }
        #region Botões
        private void btCriarBackup_Click(object sender, EventArgs e)
        {//--------------------------------------------------Criar BKP------------------------------------------------------
            if (txtDestino.Text == "")
            {
                MessageBox.Show("Informe o local de\ndestino para Backup");
            }
            else
            {
                try
                {
                    CriarBackup(txtDestino.Text);
                    MessageBox.Show("Backup criado com sucesso em:\n" + txtDestino.Text);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
        private void btProcurar_Click(object sender, EventArgs e)
        {//--------------------------------------------------Criar Procurar------------------------------------------------------
            ChooseFolder();
        }
        private void btImportarBanco_Click(object sender, EventArgs e)
        {//--------------------------------------------------IMPORTAR BKP---------------------------------------------------
            if (txtLocalBackup.Text == "")
            {
                MessageBox.Show("Informe o local do Backup");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Tem Certeza?", "Aviso!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        ImportarBackup(txtLocalBackup.Text);
                        MessageBox.Show("Backup  restaurado com Sucesso!");
                        txtLocalBackup.Text = "";
                        this.Close();
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show(erro.Message);
                    }            
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }                
            }           
        }
        private void btProcurar2_Click(object sender, EventArgs e)
        {//--------------------------------------------------IMPORTAR Procurar------------------------------------------------------
            ChooseFile();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Métodos
        public void ChooseFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLocalBackup.Text = openFileDialog1.FileName;
            }
        }
        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDestino.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        public void ImportarBackup(string Caminho)
        {
            string constring = DadosDaConexao.StringDeConexao; //"server=localhost;user=root;pwd=qwerty;database=test;";
            // Important Additional Connection Options
            constring += "charset=utf8;convertzerodatetime=true;";
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(Caminho);
                        conn.Close();
                    }
                }
            }
        }
        public void CriarBackup(string Caminho) //Backup a MySQL database
        {//define o nome do arquivo de backup de acordo com a data e hora.
            string dia = DateTime.Now.Day.ToString();
            string mes = DateTime.Now.Month.ToString();
            string ano = DateTime.Now.Year.ToString();
            string hora = DateTime.Now.ToLongTimeString().Replace(":","");
            string nomeDoArquivo = "Backup_" + ano + "-" + mes + "-" + dia + "_" + hora;     
            string constring = DadosDaConexao.StringDeConexao;
            string CaminhoBackup = Caminho + "\\" + nomeDoArquivo;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(CaminhoBackup);
                        conn.Close();
                    }
                }
            }
        }       
        #endregion

        #region Eventos
        private void txtDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtDestino_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseFolder();
        }    
        private void txtLocalBackup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        } 
        private void txtLocalBackup_MouseClick(object sender, MouseEventArgs e)
        {
            ChooseFile();
        }
        #endregion     

        #region modelo Exportar-Importar
        //Padrão Criar Backup
        //string constring = DadosDaConexao.StringDeConexao;
        //// Important Additional Connection Options
        //constring += "charset=utf8;convertzerodatetime=true;";
        //string file = "C:\\backup.sql";
        //using (MySqlConnection conn = new MySqlConnection(constring))
        //{
        //    using (MySqlCommand cmd = new MySqlCommand())
        //    {
        //        using (MySqlBackup mb = new MySqlBackup(cmd))
        //        {
        //            cmd.Connection = conn;
        //            conn.Open();
        //            mb.ExportToFile(file);
        //            conn.Close();
        //        }
        //    }
        //}

        //Padrão IMPORTAR
        //string constring = "server=localhost;user=root;pwd=qwerty;database=test;";
        //// Important Additional Connection Options
        //constring += "charset=utf8;convertzerodatetime=true;";
        //using (MySqlConnection conn = new MySqlConnection(constring))
        //{
        //    using (MySqlCommand cmd = new MySqlCommand())
        //    {
        //        using (MySqlBackup mb = new MySqlBackup(cmd))
        //        {
        //            cmd.Connection = conn;
        //            conn.Open();
        //            mb.ImportFromFile(file);
        //            conn.Close();
        //        }
        //    }
        //}
        #endregion
    }//class
}//namespace

