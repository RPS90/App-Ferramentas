using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace LeitorFenagDados
{
    public partial class Principal : Form
    {       
        public Principal()
        {
            InitializeComponent();
        }            
        
        private void btCarregarArquivo_Click(object sender, EventArgs e)
        {           
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtArquivo.Text = openFileDialog1.FileName;
                }            
        }
        public void TesteLeitor()
        {
            StreamReader arquivo = new StreamReader(txtArquivo.Text, false);         
            string connStr = "server=localhost;user=root;database=fenagdb;port=3306;password=root;";
            MySqlConnection conn = new MySqlConnection(connStr);
            string linha = "";
            string NumeroUnidade = "";
            string NomeUnidade = "";
            string NomeUsuario = "";
            string MatriculaUsuario = "";        
            string CodigoUnidade = "";
            int milliseconds = 25;
            while (true)
            {
                linha = arquivo.ReadLine();
                if (linha != null)
                {if (linha.Contains("---")) { }
                    else
                    {if (linha.Contains("TOTAL UNIDADE")) { }
                        else
                        {if (linha.Contains("NOME DO EMPREGADO")) { }
                            else
                            {   try
                                {
                                    if (linha.Contains("UNIDADE:"))
                                    {
                                        NumeroUnidade = linha.Substring(9, 8); //numero da unidade, inserir no banco
                                        NomeUnidade = linha.Substring(20);
                                        Thread.Sleep(milliseconds);
                                        if (conn.State == ConnectionState.Closed) { conn.Open(); }// conn.Open();// SQL 1!!!!
string sql = "insert into tb_info_unidades (numero_entidade, nome_entidade, numero_rubrica, " + "numero_unidade, nome_unidade) VALUES ('" + txtEntidade.Text + "','" + 
                                            txtEntidadeNome.Text + "','0763','" + NumeroUnidade +"','"+ NomeUnidade + "');";
                                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                                        cmd.ExecuteNonQuery(); // sem retorno
                                        if (conn.State == ConnectionState.Open) { conn.Close(); }//conn.Close();                                       
                                        try
                                        {
                                            Thread.Sleep(milliseconds);
                                            if (conn.State == ConnectionState.Closed) { conn.Open(); }//conn.Open(); // SQL 2!!!!!
string sql2 = "SELECT codigo_unidade FROM tb_info_unidades WHERE numero_unidade = '" + NumeroUnidade + "';";
                                            MySqlCommand cmd2 = new MySqlCommand(sql2, conn);
                                            MySqlDataReader rdr = cmd2.ExecuteReader();
                                            if (rdr.Read())
                                            {
                                                CodigoUnidade = rdr[0].ToString();
                                            }
                                            else { break; }                                           
                                            if (conn.State == ConnectionState.Open) { conn.Close(); }//conn.Close();
                                        } catch (Exception ex){MessageBox.Show(ex.ToString());}
                                    }//agora preparar o nome, lendo apenas lihas com nome agora
                                    NomeUsuario = linha.Substring(0, 90);
                                    MatriculaUsuario = linha.Substring(94, 9);                                   
                                    try
                                    {
                                        Thread.Sleep(milliseconds);
                                        if (conn.State == ConnectionState.Closed) { conn.Open(); }// conn.Open();//SQL 3!!!!
string sql = "insert into tb_info_usuarios (codigo_unidade, nome, matricula) VALUES ('" + CodigoUnidade + "','" + NomeUsuario + "','" + MatriculaUsuario + "');";
                                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                                        cmd.ExecuteNonQuery(); // sem retorno
                                        if (conn.State == ConnectionState.Open) { conn.Close();}//conn.Close();
                                    }
                                    catch (Exception ex){MessageBox.Show(ex.ToString());}                                    
                                }catch (Exception ) {}
                            }
                        }

                    }
                }
                else{break;}
            }//while
            MessageBox.Show("Terminou");
        }

        private void btRodar_Click(object sender, EventArgs e)
        {
            TesteLeitor();
        }
    }
}
