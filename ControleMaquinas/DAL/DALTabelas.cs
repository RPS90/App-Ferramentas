using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DALTabelas
    {
        public static String CriarBanco = "";        
        private DALConexao conexao;
        public DALTabelas (DALConexao cx)
        {            this.conexao = cx;        }                
        public DataTable ListarTabelas()
         {
            string banco = DadosDaConexao.banco;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT table_name FROM INFORMATION_SCHEMA.tables WHERE TABLE_SCHEMA = '" + banco +"';" ,    
                conexao.StringConexao);        
            da.Fill(tabela);
            return tabela;
         }
        #region Listar Colunas (Não muito importante)
        public DataTable ListarColunasDaTabelaMesas()
        {
            string banco = DadosDaConexao.banco;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + banco + "' AND TABLE_NAME = 'mesas';", 
                conexao.StringConexao);        
            da.Fill(tabela);
            return tabela;
        }
        public DataTable ListarColunasDaTabelaComputadores()
        {
            string banco = DadosDaConexao.banco;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + banco + "' AND TABLE_NAME = 'computadores';", 
                conexao.StringConexao);        
            da.Fill(tabela);
            return tabela;
        }
        public DataTable ListarColunasDaTabelaUsuarios()
        {
            string banco = DadosDaConexao.banco;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + banco + "' AND TABLE_NAME = 'usuarios';", 
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable ListarColunasDaTabelaMonitores()
        {
            string banco = DadosDaConexao.banco;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + banco + "' AND TABLE_NAME = 'monitores';", 
                conexao.StringConexao);         
            da.Fill(tabela);
            return tabela;
        }
        #endregion
        public DataTable TesteDeComando()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("COMANDO SQL",  conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable Relacionamento()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
"select mesas.numeropatrimonio, " +
"group_concat(distinct usuarios.nomeusuario             separator ', ') as usuarios           , " +
"group_concat(distinct computadores.numeropatrimonio    separator ', ') as computadores       , " +
"group_concat(distinct monitores.numeropatrimonio       separator ', ') as monitores          , " +
"mesas.departamento "+
"from mesas " +

"left join mesa_computador     on mesa_computador.codigo_mesa  = mesas.codigo " +
"left join mesa_monitor        on mesa_monitor.codigo_mesa     = mesas.codigo " +
"left join mesa_usuario        on mesa_usuario.codigo_mesa     = mesas.codigo " +
"left join computadores        on computadores.codigo          = mesa_computador.codigo_computador " +
"left join monitores           on monitores.codigo             = mesa_monitor.codigo_monitor " +
"left join usuarios            on usuarios.codigo              = mesa_usuario.codigo_usuario " +

"WHERE mesas.estado = 'ATIVO' " + //Para receber só MESAS ATIVAS, Maravilha
"group by mesas.codigo; ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public void CriarBancoDeDados() 
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = 
"CREATE DATABASE  `" + CriarBanco + "`;" +
"USE `" + CriarBanco + "`;" +

"CREATE TABLE `computadores` ("+
"`codigo` int(11) NOT NULL AUTO_INCREMENT,"+
"`departamento` varchar(45) DEFAULT NULL,"+
"`ip` varchar(45) DEFAULT NULL,"+
"`marca` varchar(45) DEFAULT NULL,"+
"`modelopc` varchar(45) DEFAULT NULL,"+
"`nserie` varchar(45) DEFAULT NULL,"+
"`numeropatrimonio` varchar(45) DEFAULT NULL,"+
"`nomemaquina` varchar(45) DEFAULT NULL,"+
"`patrimonioprov` varchar(45) DEFAULT NULL,"+
"`sigla` varchar(45) DEFAULT NULL,"+
"`estado` varchar(45) DEFAULT NULL,"+
"`datacadastro` varchar(45) DEFAULT NULL,"+
"`ultimaalteracao` varchar(45) DEFAULT NULL,"+
"PRIMARY KEY (`codigo`)"+
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;"+

"CREATE TABLE `mesas` ("+
"`codigo` int(11) NOT NULL AUTO_INCREMENT,"+
"`numeropatrimonio` varchar(45) DEFAULT NULL,"+
"`patrimonioprov` varchar(45) DEFAULT NULL,"+
"`departamento` varchar(45) DEFAULT NULL,"+
"`sigla` varchar(45) DEFAULT NULL,"+
"`estado` varchar(45) DEFAULT NULL,"+
"`datacadastro` varchar(45) DEFAULT NULL,"+
"`ultimaalteracao` varchar(45) DEFAULT NULL,"+
"PRIMARY KEY (`codigo`)"+
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;"+

"CREATE TABLE `monitores` ("+
"`codigo` int(11) NOT NULL AUTO_INCREMENT,"+
"`numeropatrimonio` varchar(45) DEFAULT NULL,"+
"`patrimonioprov` varchar(45) DEFAULT NULL,"+
"`marca` varchar(45) DEFAULT NULL,"+
"`nserie` varchar(45) DEFAULT NULL,"+
"`departamento` varchar(45) DEFAULT NULL,"+
"`sigla` varchar(45) DEFAULT NULL,"+
"`tipo` varchar(45) DEFAULT NULL,"+
"`estado` varchar(45) DEFAULT NULL,"+
"`datacadastro` varchar(45) DEFAULT NULL,"+
"`ultimaalteracao` varchar(45) DEFAULT NULL,"+
"PRIMARY KEY (`codigo`)"+
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;"+

"CREATE TABLE `usuarios` ("+
"`codigo` int(11) NOT NULL AUTO_INCREMENT,"+
"`nomeusuario` varchar(45) DEFAULT NULL,"+
"`login` varchar(45) DEFAULT NULL,"+
"`ramal` varchar(45) DEFAULT NULL,"+
"`departamento` varchar(45) DEFAULT NULL,"+
"`email` varchar(45) DEFAULT NULL,"+
"`foto` longblob,"+
"`estado` varchar(45) DEFAULT NULL,"+
"`datacadastro` varchar(45) DEFAULT NULL,"+
"`ultimaalteracao` varchar(45) DEFAULT NULL,"+
"PRIMARY KEY (`codigo`)"+
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;"+

"CREATE TABLE `mesa_computador` ("+
"`codigo_mesa` int(11) NOT NULL,"+
"`codigo_computador` int(11) NOT NULL,"+
"UNIQUE KEY `codigo_computador_UNIQUE` (`codigo_computador`),"+
"KEY `fk_codigo_mesa_idx` (`codigo_mesa`),"+
"KEY `fk_codigo_computador_idx` (`codigo_computador`),"+
"CONSTRAINT `fk_mc_computador` FOREIGN KEY (`codigo_computador`) REFERENCES `computadores` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,"+
"CONSTRAINT `fk_mc_mesa` FOREIGN KEY (`codigo_mesa`) REFERENCES `mesas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION"+
") ENGINE=InnoDB DEFAULT CHARSET=utf8;"+

"CREATE TABLE `mesa_monitor` ("+
"`codigo_mesa` int(11) NOT NULL,"+
"`codigo_monitor` int(11) NOT NULL,"+
"UNIQUE KEY `codigo_monitor_UNIQUE` (`codigo_monitor`),"+
"KEY `fk_codigo_mesa_idx` (`codigo_mesa`),"+
"KEY `fk_cod_mesa_idx` (`codigo_mesa`),"+
"CONSTRAINT `fk_mm_mesa` FOREIGN KEY (`codigo_mesa`) REFERENCES `mesas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,"+
"CONSTRAINT `fk_mm_monitor` FOREIGN KEY (`codigo_monitor`) REFERENCES `monitores` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION"+
") ENGINE=InnoDB DEFAULT CHARSET=utf8;"+

"CREATE TABLE `mesa_usuario` ("+
"`codigo_mesa` int(11) NOT NULL,"+
"`codigo_usuario` int(11) NOT NULL,"+
//"UNIQUE KEY `codigo_usuario_UNIQUE` (`codigo_usuario`),"+
"KEY `fk_mesa_idx` (`codigo_mesa`),"+
"KEY `fk_usuario_idx` (`codigo_usuario`),"+
"CONSTRAINT `fk_mu_mesa` FOREIGN KEY (`codigo_mesa`) REFERENCES `mesas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,"+
"CONSTRAINT `fk_mu_usuario` FOREIGN KEY (`codigo_usuario`) REFERENCES `usuarios` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION"+
") ENGINE=InnoDB DEFAULT CHARSET=utf8;"   +

"CREATE TABLE `historico` ("+
"`codigo` INT(11) NOT NULL AUTO_INCREMENT,"+
"`historico` VARCHAR(300) NOT NULL,"+
"PRIMARY KEY (`codigo`)" +
")ENGINE=InnoDB DEFAULT CHARSET=utf8;"+
//Criação do banco de dados
"insert into historico (historico) values ('Banco de dados Criado: " + DateTime.Now.ToLongDateString() + " às " + DateTime.Now.ToLongTimeString() + "');";
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
    }//class
}//namespace

//"inner join mesa_computador     on mesa_computador.codigo_mesa  = mesas.codigo " +
//"inner join mesa_monitor        on mesa_monitor.codigo_mesa     = mesas.codigo " +
//"inner join mesa_usuario        on mesa_usuario.codigo_mesa     = mesas.codigo " +
//"inner join computadores        on computadores.codigo          = mesa_computador.codigo_computador " +
//"inner join monitores           on monitores.codigo             = mesa_monitor.codigo_monitor " +
//"inner join usuarios            on usuarios.codigo              = mesa_usuario.codigo_usuario " +

//"right join mesa_computador     on mesa_computador.codigo_mesa  = mesas.codigo " +
//"right join mesa_monitor        on mesa_monitor.codigo_mesa     = mesas.codigo " +
//"right join mesa_usuario        on mesa_usuario.codigo_mesa     = mesas.codigo " +
//"right join computadores        on computadores.codigo          = mesa_computador.codigo_computador " +
//"right join monitores           on monitores.codigo             = mesa_monitor.codigo_monitor " +
//"right join usuarios            on usuarios.codigo              = mesa_usuario.codigo_usuario " +