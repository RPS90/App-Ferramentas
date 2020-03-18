using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Reino_da_Garotada
{
    class Classedall
    {
        public static string conexaoString = @"Provider=Microsoft.Jet.OleDb.4.0;Data Source=Z:\Debug\banco_reino.mdb";
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbConnection conn = new OleDbConnection();
        
        public static bool VerificaAluno(string rgAluno)
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Alunos where txtRGAluno = '" + rgAluno + "';" ;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                conn.Close();
                conn.Dispose();
                return false;
            }
            else
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
        }
        public static bool verificaAlunoCadastrado()
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Alunos;";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
            else
            {
                conn.Close();
                conn.Dispose();
                return false;
            }
        }
        public static bool VerificaCurso()
        {            
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Cursos;";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dt = cmd.ExecuteReader();
            if (dt.Read())
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
            else
            {
                conn.Close();
                conn.Dispose();
                return false;
            }
        }
        public static List<DadosCurso> DadosCursos()
        {
            string sql;

            sql = "Select * from TB_Cursos where status = true";
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            var lista = new List<DadosCurso>();
            conn.Open();
            var leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var ListaCurso = new DadosCurso();
                    ListaCurso.Código_Curso = Convert.ToInt32(leitor["CodCurso"]);
                    ListaCurso.Nome_Curso = leitor["txtCurso"].ToString();
                    lista.Add(ListaCurso);
                }
            }
            conn.Close();
            return lista;
        }
        public static List<DadosFuncionario> DadosFuncionario()
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Funcionarios where chkDeslig = false";
            cmd.CommandType = CommandType.Text;
            var lista = new List<DadosFuncionario>();
            conn.Open();
            var leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var ListaFuncionario = new DadosFuncionario();
                    ListaFuncionario.Código_Funcionário = Convert.ToInt32(leitor["CodFuncionario"]);
                    ListaFuncionario.Nome_Funcionário = leitor["txtNome"].ToString();
                    lista.Add(ListaFuncionario);
                }
            }
            conn.Close();
            return lista;
        }

        public static bool VerificaFuncionario()
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Funcionarios";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                conn.Dispose();
                return true;
            }
            else
            {
                conn.Close();
                conn.Dispose();
                return false;
            }
        }
        public static bool VerificaCurso(string nomeCurso)
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Cursos where txtCurso = '" + nomeCurso + "';";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return false;
            }
            else
            {
                conn.Close();
                return true;
            }
        }
        public static bool VerificaAlunoCurso(string nomeCurso)
         {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Alunos where cboCurso = '" + nomeCurso + "' and txtForaTurma = true;";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                conn.Close();
                return true;
            }
            else
            {
                conn.Close();
                return false;
            }
        }
        public static bool VerificaQtdeAlunosCadTurmaCurso(int codigoCurso)
        {
            string sqlQtdAluno, sqlAlunosCadastrados;
            int QtdAluno, AlunosCadastrados;
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            sqlQtdAluno = "Select qtdeAlunosCurso from TB_Cursos where CodCurso = " + codigoCurso + ";";
            sqlAlunosCadastrados = "Select alunosCadastradosTurma from TB_Cursos where CodCurso = " + codigoCurso + ";";        
            cmd.CommandText = sqlQtdAluno;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            QtdAluno = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.CommandText = sqlAlunosCadastrados;
            cmd.CommandType = CommandType.Text;
            AlunosCadastrados = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            if (QtdAluno < AlunosCadastrados)
            {
                return true;
            }
            else 
            {
                return false;
            }      
        }
        public static List<PesquisaTurma> DadosTurma()
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Turma";
            cmd.CommandType = CommandType.Text;
            var lista = new List<PesquisaTurma>();
            conn.Open();
            var leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var ListaTurma = new PesquisaTurma();
                    ListaTurma.CodTurma = Convert.ToInt32(leitor["CodTurma"]);
                    ListaTurma.txtTurma = leitor["txtTurma"].ToString();
                    ListaTurma.cboCurso = leitor["cboCurso"].ToString();
                    ListaTurma.CodCurso = Convert.ToInt32(leitor["CodCurso"]);
                    ListaTurma.cboAluno = leitor["cboAluno"].ToString();
                    ListaTurma.CodAluno = Convert.ToInt32(leitor["CodAluno"].ToString());
                    lista.Add(ListaTurma);
                }
            }
            conn.Close();
            return lista;
        }
        public static List<DadosAlunoCadTurma> DadosAluno()
        {
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Alunos where txtForaTurma = false";
            cmd.CommandType = CommandType.Text;
            var lista = new List<DadosAlunoCadTurma>();
            conn.Open();
            var leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var ListaAluno = new DadosAlunoCadTurma();
                    ListaAluno.CodAluno = Convert.ToInt32(leitor["CodAluno"]);
                    ListaAluno.txtNomeAluno = leitor["txtNomeAluno"].ToString();

                    lista.Add(ListaAluno);
                }
            }
            conn.Close();
            return lista;
        }
        public static List<DadosAlunoCadTurma> DadosAlunoCid()
        {
            string sql;

            sql = "Select distinct txtCidade from TB_Alunos;";
            conn.ConnectionString = conexaoString;
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            var lista = new List<DadosAlunoCadTurma>();
            conn.Open();
            var leitor = cmd.ExecuteReader();
            if (leitor.HasRows)
            {
                while (leitor.Read())
                {
                    var ListaCurso = new DadosAlunoCadTurma();
                    ListaCurso.txtCidade = leitor["txtCidade"].ToString();
                    lista.Add(ListaCurso);
                }
            }
            conn.Close();
            return lista;
        }


    }
}
