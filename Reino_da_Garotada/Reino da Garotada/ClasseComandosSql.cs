using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Reino_da_Garotada
{
    class ClasseComandosSql
    {
        public static string ConexaoString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source =C://Users//jesse//Desktop//Reino da Garotada//Reino da Garotada//Reino da Garotada.mdb";
        public static OleDbCommand cmd = new OleDbCommand();
        public static OleDbConnection conn = new OleDbConnection();
        public static bool VerificarAlunoExixtente(int cpfAluno, int rgAluno)
        {

            conn.ConnectionString = ConexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Select * from TB_Alunos where txtRGAluno = " + rgAluno + " or txtCPFAluno = " + cpfAluno + ";";
            cmd.CommandType = CommandType.Text;
            conn.Open();
            var ds = cmd.ExecuteReader();
            conn.Dispose();
            cmd.Dispose();
            if (ds.Read())
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void CadastroAluno()
        {
            conn.ConnectionString = ConexaoString;
            cmd.Connection = conn;
            cmd.CommandText = "Insert into TB_Alunos (txtMatricula, cboSemestre, txtAnoCadastro, txtDtCadastro, CodAluno, txtNomeAluno, txtRGAluno, txtCPFAluno, txtDtNascto," +
                "txtNatural, txtNacionalidade, cboSexo, cboEscolaridade, txtAnoConclui, txtNomeResp, txtRGResp, txtCPFResp, txtTpLograd, txtNum" +
                "txtComplemento, txtBairro, txtCidade, txtUF, txtCEP, txtFoneRes, txtFoneCom, txtFoneCelular, chkNaoPossui, chkDefAuditiva, chkDefVisual, chkDefIntelectual," +
                "chkDefMultiplas, chkDefOutras, txtDescOutras, chkDefPsicossocial, chkDefAltaHabil, chkDefCondutaTipicaTEA, chkSitOcupAutonomo, chkSitOcupEmpregComCarteira," +
                "chkSitOcupProfLiberal, chkSitOcupDesempregado, chkSitOcupEmpregador, chkSitOcupEmpSemCarteira, chkSitOcupAposentado, chkSitOcupBusca1Emprego, cboCodCurso, cboHorario, " +
                "txtCargaHoraria, cboDiasSemana, txtInicio, txtTermino, txtTurma, txtQualiProfissional, cboResultFinal, chkSitEvadido, chkSitDispensado, chkSitTrancamento, chkSitTransferido" +
                ") values ();";
        }
    }
}
