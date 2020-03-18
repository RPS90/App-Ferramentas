﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

namespace SGVersaoBeta
{
    public partial class InativarCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoginUsuario"] == null)
            {
                Response.Redirect("login.aspx");
            }

            OleDbConnection conn3 = new OleDbConnection();
            OleDbCommand cmd3 = new OleDbCommand();
            OleDbDataAdapter da3 = new OleDbDataAdapter();
            DataSet ds3 = new DataSet();
            conn3.ConnectionString = Conexao.ConexaoStr;
            cmd3.Connection = conn3;
            cmd3.CommandText = "select Nome from DadosClientes";
            cmd3.CommandType = CommandType.Text;
            conn3.Open();
            da3.SelectCommand = cmd3;
            da3.Fill(ds3, "Nome");
            dropInativarCliente.DataSource = ds3.Tables["Nome"];
            dropInativarCliente.DataValueField = "Nome";
            dropInativarCliente.DataBind();
            conn3.Close();
            conn3.Dispose();

        }

        protected void btnInativarCliente_Click(object sender, EventArgs e)
        {
            string statusCliente = "Inativo";
            OleDbConnection conn5 = new OleDbConnection();
            OleDbCommand cmd5 = new OleDbCommand();
            conn5.ConnectionString = Conexao.ConexaoStr;
            cmd5.Connection = conn5;
            cmd5.CommandText = "update DadosClientes set StatusCliente = '" + statusCliente + "' where Nome = '" + dropInativarCliente.Text + "'";
            cmd5.CommandType = CommandType.Text;
            conn5.Open();
            cmd5.ExecuteNonQuery();
            conn5.Close();
            conn5.Dispose();

            string data = DateTime.Now.ToString();
            string nome = Session["LoginUsuario"].ToString();
            OleDbConnection conn2 = new OleDbConnection();
            OleDbCommand cmd2 = new OleDbCommand();
            conn2.ConnectionString = Conexao.ConexaoStr;
            cmd2.Connection = conn2;
            cmd2.CommandText = "insert into HistoricoSistema(NomeAutor, AcaoEfetuada, DataAcao) values ('" + nome + "', 'Inativou o cliente " + dropInativarCliente.Text + "', '" + data + "')";
            cmd2.CommandType = CommandType.Text;
            conn2.Open();
            cmd2.ExecuteScalar();
            conn2.Close();
            conn2.Dispose();

            lblRespostaServer.Text = "Agora o cliente está inativo no sistema";
        }
    }
}