using System;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor   = "";
        public static String banco      = ""; 
        public static String usuario    = "";
        public static String senha      = "";
        public static String port       = "3306"; //3306 é Padrão

        public static String StringDeConexaoSemBanco
        {
            get
            {
                return
                    "server     =" + servidor + ";" +
                    "user       =" + usuario  + ";" +                  
                    "port       =" + port     + ";" +
                    "password   =" + senha    + ";" ;
            }
        }
        public static String StringDeConexao        
        {
            get 
            {
                return
                    "server     =" + servidor + ";" +        
                    "user       =" + usuario  + ";" +        
                    "database   =" + banco    + ";" +        
                    "port       =" + port     + ";" +        
                    "password   =" + senha    + ";" ;        
            }
        }
    }//class
}//namespace