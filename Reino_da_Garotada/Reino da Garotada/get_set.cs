using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reino_da_Garotada
{
    class PesquisaTurma
    {
        public string txtTurma { get; set; }
        public int CodTurma { get; set; }
        public string cboCurso { get; set; }
        public int CodCurso { get; set; }
        public string cboAluno { get; set; }
        public int CodAluno { get; set; }

    }
    class DadosCurso
    {
        public int Código_Curso { get; set; }
        public string Nome_Curso { get; set; }
        public string txtDescricao { get; set; }
        public string cboHorário { get; set; }
        public string txtCargaHoraria { get; set; }
        public string cboDiasSemana { get; set; }
        public string txtQualifProfissional { get; set; }
        public string cboLocalRalizacao { get; set; }
        public string cboResponsCurso { get; set; }
        public string cboPeriodo { get; set; }

    }
    class DadosFuncionario
    {
        public int Código_Funcionário { get; set; }
        public string Nome_Funcionário { get; set; }
    }
    class DadosAlunoCadTurma
    {
        public int CodAluno { get; set; }
        public string txtMatricula { get; set; }
        public string cboSemestre { get; set; }
        public string txtDtCadastro { get; set; }
        public string txtAno_Cadastro { get; set; }
        public string txtNomeAluno { get; set; }
        public string txtRGAluno { get; set; }
        public string txtCPFAluno { get; set; }
        public DateTime txtDtNascto { get; set; }
        public string txtNatural { get; set; }
        public string txtNacionalidade { get; set; }
        public string cboSexo { get; set; }
        public string cboEscolaridade { get; set; }
        public string txtAnoConclui { get; set; }
        public string txtNomeResp { get; set; }
        public string txtRGResp { get; set; }
        public string txtCPFResp { get; set; }
        public string txtLogradouro { get; set; }
        public string txtNum { get; set; }
        public string txtComplemento { get; set; }
        public string txtBairro { get; set; }
        public string txtCidade { get; set; }
        public string cboUF { get; set; }
        public string txtCEP { get; set; }
        public string txtFoneRes { get; set; }
        public string txtFoneCom { get; set; }
        public string txtFoneCelular { get; set; }
        public bool chkNaoPossui { get; set; }
        public bool chkDefAuditiva { get; set; }
        public bool chkDefVisual { get; set; }
        public bool chkDefIntelectual { get; set; }
        public bool chkDefMultiplas { get; set; }
        public bool chkDefOutras { get; set; }
        public bool txtDescOutras { get; set; }
        public bool chkDefPsicossocial { get; set; }
        public bool chkDefAltaHabil { get; set; }
        public bool chkDefCondutaTipicaTEA { get; set; }
        public bool chkSitOcupAutonomo { get; set; }
        public bool chkSitOcupEmpregComCarteira { get; set; }
        public bool chkSitOcupProfLiberal { get; set; }
        public bool chkSitOcupDesempregado { get; set; }
        public bool chkSitOcupEmpregador { get; set; }
        public bool chkSitOcupEmpSemCarteira { get; set; }
        public bool chkSitOcupAposentado { get; set; }
        public bool chkSitOcupBusca1Emprego { get; set; }
        public string cboCurso { get; set; }
        public string cboHorario { get; set; }
        public string txtCargaHoraria { get; set; }
        public string cboDiasSemana { get; set; }
        public string txtTurma { get; set; }
        public string txtQualiProfissional { get; set; }
        public string cboResultFinal { get; set; }
        public bool chkSitEvadido { get; set; }
        public bool chkSitDispensado { get; set; }
        public bool chkSitTrancamento { get; set; }
        public bool chkSitTransferido { get; set; }
    }
     
}
