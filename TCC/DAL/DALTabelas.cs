using System;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class DALTabelas
    {
        public static String txtBoxPesquisa = "";//bypass do Modelo
        public static String stringDeTabela = "";//bypass do Modelo
        public static String stringDeColuna = "";//bypass do Modelo
        public static String CriarBanco = "";    //bypass do Modelo
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
        public DataTable ListarColunasDasTabelas()
        {
            string banco = DadosDaConexao.banco;
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = '" + banco + "' AND TABLE_NAME = '" + stringDeTabela + "';",
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public DataTable LocalizarEspecificoSemLike() 
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR-funciona
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from " + stringDeTabela + 
                " where " + stringDeTabela + "." + stringDeColuna + " = '" + txtBoxPesquisa + "'", //where tabela.coluna = valor;
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }        
        public DataTable LocalizarEspecifico()
        {//---------------------------------------------------------------------------------------------------------------------LOCALIZAR-funciona
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Select * from " + stringDeTabela + 
                " where " + stringDeColuna + 
                " like '%" + txtBoxPesquisa + "%'", 
                conexao.StringConexao);
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
//"mesas.departamento, "+
"departamentos.departamento "+
"from mesas " +
"left join mesa_computador     on mesa_computador.codigo_mesa  = mesas.codigo " +//Left join retorna todas as MESAS
"left join mesa_monitor        on mesa_monitor.codigo_mesa     = mesas.codigo " +
"left join mesa_usuario        on mesa_usuario.codigo_mesa     = mesas.codigo " +
"left join computadores        on computadores.codigo          = mesa_computador.codigo_computador " +
"left join monitores           on monitores.codigo             = mesa_monitor.codigo_monitor " +
"left join usuarios            on usuarios.codigo              = mesa_usuario.codigo_usuario " +
"inner join departamentos      on mesas.departamento           = departamentos.codigo " +
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

"CREATE TABLE `departamentos` (" +                      //criar departamentos primeiro pq é FK de outras tabelas
"`codigo` INT(11) NOT NULL AUTO_INCREMENT," +           //add codigo conforme add item
"`departamento` VARCHAR(45) NOT NULL," +                //tipo
"PRIMARY KEY (`codigo`)," +                             //PK
"UNIQUE KEY `departamento_UNIQUE` (`departamento`)" +   //Não pode repetir o nome de departamentos
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" + //char type, pra não enroscar com caractere especial

"CREATE TABLE `marcas` (" +
"`codigo` INT(11) NOT NULL AUTO_INCREMENT," +
"`marca` VARCHAR(45) NOT NULL," +
"PRIMARY KEY (`codigo`)," +
"UNIQUE KEY `marca_UNIQUE` (`marca`)" + //não pode por marca repetida
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" +

"CREATE TABLE `computadores` (" +
"`codigo` int(11) NOT NULL AUTO_INCREMENT," +
"`ip` varchar(45) DEFAULT NULL," +
"`marca` int(11) DEFAULT NULL," + //marca agora é FK
"`modelopc` varchar(45) DEFAULT NULL," +
"`nserie` varchar(45) DEFAULT NULL," +
"`numeropatrimonio` varchar(45) DEFAULT NULL," +
"`nomemaquina` varchar(45) DEFAULT NULL," +
"`patrimonioprov` varchar(45) DEFAULT NULL," +
"`sigla` varchar(45) DEFAULT NULL," +
"`estado` varchar(45) DEFAULT NULL," +
"`datacadastro` varchar(45) DEFAULT NULL," +
"`ultimaalteracao` varchar(45) DEFAULT NULL," +
"`tipo` varchar(45) DEFAULT NULL," +
"`campovazio` varchar(45) DEFAULT NULL," +
"`campo1` varchar(45) DEFAULT NULL," +
"`campo2` varchar(45) DEFAULT NULL," +
"`campo3` varchar(45) DEFAULT NULL," +
"PRIMARY KEY (`codigo`)," +
"KEY `fk_marca_computadores_idx` (`marca`)," +
"CONSTRAINT `fk_marca_computador` FOREIGN KEY (`marca`) REFERENCES `marcas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" +

"CREATE TABLE `mesas` (" +
"`codigo` int(11) NOT NULL AUTO_INCREMENT," +
"`numeropatrimonio` varchar(45) DEFAULT NULL," +
"`patrimonioprov` varchar(45) DEFAULT NULL," +
"`departamento` INT(11) NOT NULL," +
"`sigla` varchar(45) DEFAULT NULL," +
"`estado` varchar(45) DEFAULT NULL," +
"`datacadastro` varchar(45) DEFAULT NULL," +
"`ultimaalteracao` varchar(45) DEFAULT NULL," +
"`campovazio` varchar(45) DEFAULT NULL," +
"`campo1` varchar(45) DEFAULT NULL," +
"`campo2` varchar(45) DEFAULT NULL," +
"`campo3` varchar(45) DEFAULT NULL," +
"PRIMARY KEY (`codigo`)," +
"KEY `fk_departamento_mesas_idx` (`departamento`)," +
"CONSTRAINT `fk_departamento_mesa` FOREIGN KEY (`departamento`) REFERENCES `departamentos` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" +

"CREATE TABLE `monitores` (" +
"`codigo` int(11) NOT NULL AUTO_INCREMENT," +
"`numeropatrimonio` varchar(45) DEFAULT NULL," +
"`patrimonioprov` varchar(45) DEFAULT NULL," +
"`marca` int(11) DEFAULT NULL," +
"`nserie` varchar(45) DEFAULT NULL," +
"`sigla` varchar(45) DEFAULT NULL," +
"`tipo` varchar(45) DEFAULT NULL," +
"`estado` varchar(45) DEFAULT NULL," +
"`datacadastro` varchar(45) DEFAULT NULL," +
"`ultimaalteracao` varchar(45) DEFAULT NULL," +
"`modelomnt` varchar(45) DEFAULT NULL," +
"`campovazio` varchar(45) DEFAULT NULL," +
"`campo1` varchar(45) DEFAULT NULL," +
"`campo2` varchar(45) DEFAULT NULL," +
"`campo3` varchar(45) DEFAULT NULL," +
"PRIMARY KEY (`codigo`)," +
"KEY `fk_marca_monitores_idx` (`marca`)," +
"CONSTRAINT `fk_marca_monitor` FOREIGN KEY (`marca`) REFERENCES `marcas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" +

"CREATE TABLE `usuarios` (" +
"`codigo` int(11) NOT NULL AUTO_INCREMENT," +
"`nomeusuario` varchar(45) DEFAULT NULL," +
"`login` varchar(45) DEFAULT NULL," +
"`ramal` varchar(45) DEFAULT NULL," +
"`departamento` INT(11) NOT NULL," +
"`email` varchar(45) DEFAULT NULL," +
"`foto` longblob," +
"`estado` varchar(45) DEFAULT NULL," +
"`datacadastro` varchar(45) DEFAULT NULL," +
"`ultimaalteracao` varchar(45) DEFAULT NULL," +
"`campovazio` varchar(45) DEFAULT NULL," +
"`campo1` varchar(45) DEFAULT NULL," +
"`campo2` varchar(45) DEFAULT NULL," +
"`campo3` varchar(45) DEFAULT NULL," +
"PRIMARY KEY (`codigo`)," +
"KEY `fk_departamento_usuario_idx` (`departamento`)," +//chave estrangeira do departamento
"CONSTRAINT `fk_departamento_usuario` FOREIGN KEY (`departamento`) REFERENCES `departamentos` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB DEFAULT CHARSET=utf8;" +

"CREATE TABLE `mesa_computador` (" +
"`codigo_mesa` int(11) NOT NULL," +
"`codigo_computador` int(11) NOT NULL," +
"UNIQUE KEY `codigo_computador_UNIQUE` (`codigo_computador`)," +
"KEY `fk_codigo_mesa_idx` (`codigo_mesa`)," +
"KEY `fk_codigo_computador_idx` (`codigo_computador`)," +
"CONSTRAINT `fk_mc_computador` FOREIGN KEY (`codigo_computador`) REFERENCES `computadores` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION," +
"CONSTRAINT `fk_mc_mesa` FOREIGN KEY (`codigo_mesa`) REFERENCES `mesas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB DEFAULT CHARSET=utf8;" +

"CREATE TABLE `mesa_monitor` (" +
"`codigo_mesa` int(11) NOT NULL," +
"`codigo_monitor` int(11) NOT NULL," +
"UNIQUE KEY `codigo_monitor_UNIQUE` (`codigo_monitor`)," +
"KEY `fk_codigo_mesa_idx` (`codigo_mesa`)," +
"KEY `fk_cod_mesa_idx` (`codigo_mesa`)," +
"CONSTRAINT `fk_mm_mesa` FOREIGN KEY (`codigo_mesa`) REFERENCES `mesas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION," +
"CONSTRAINT `fk_mm_monitor` FOREIGN KEY (`codigo_monitor`) REFERENCES `monitores` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB DEFAULT CHARSET=utf8;" +

"CREATE TABLE `mesa_usuario` (" +
"`codigo_mesa` int(11) NOT NULL," +
"`codigo_usuario` int(11) NOT NULL," +
//"UNIQUE KEY `codigo_usuario_UNIQUE` (`codigo_usuario`),"+ //usuario não é unique pq pode ter mais de um em qlq mesa
"KEY `fk_mesa_idx` (`codigo_mesa`)," +
"KEY `fk_usuario_idx` (`codigo_usuario`)," +
"CONSTRAINT `fk_mu_mesa` FOREIGN KEY (`codigo_mesa`) REFERENCES `mesas` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION," +
"CONSTRAINT `fk_mu_usuario` FOREIGN KEY (`codigo_usuario`) REFERENCES `usuarios` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB DEFAULT CHARSET=utf8;" +

"CREATE TABLE `historico` (" +
"`codigo`           int(11)         NOT NULL AUTO_INCREMENT," +
"`cod_mesa`         int(11)         DEFAULT NULL," +
"`cod_usuario`      int(11)         DEFAULT NULL," +
"`cod_monitor`      int(11)         DEFAULT NULL," +
"`cod_computador`   int(11)         DEFAULT NULL," +
"`acao`             varchar(45)     NOT NULL," +
"`descricao`        varchar(300)    DEFAULT NULL," +
"`historicodata`    date            NOT NULL," +
"`campovazio` varchar(45) DEFAULT NULL," +
"PRIMARY KEY (`codigo`)," +
"KEY `cod_mesa_idx`         (`cod_mesa`)," +
"KEY `cod_computador_idx`   (`cod_computador`)," +
"KEY `cod_monitor_idx`      (`cod_monitor`)," +
"KEY `cod_usuario_idx`      (`cod_usuario`)," +
"CONSTRAINT `cod_computador`    FOREIGN KEY (`cod_computador`)  REFERENCES `computadores`   (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION," +
"CONSTRAINT `cod_mesa`          FOREIGN KEY (`cod_mesa`)        REFERENCES `mesas`          (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION," +
"CONSTRAINT `cod_monitor`       FOREIGN KEY (`cod_monitor`)     REFERENCES `monitores`      (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION," +
"CONSTRAINT `cod_usuario`       FOREIGN KEY (`cod_usuario`)     REFERENCES `usuarios`       (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION" +
") ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=utf8;" +
//Criação do banco de dados pro historico
"insert into historico (acao, descricao, historicodata)" +
"values ('Criação do Banco de dados', 'Banco de dados criado a partir do programa', '" + //Ano-Mês-Dia, Formato que o MySQL aceita
DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "');";
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void TesteDeComandoSemDataTable()
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText =
                "shell> mysqldump -u <root> -p<root> mysql > mysql.sql.";
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public DataTable TesteDeComando()
        {
            DataTable tabela = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(
                "Comando",
                conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
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