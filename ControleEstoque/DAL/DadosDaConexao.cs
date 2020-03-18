using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String StringDeConexao
        {
            get 
            {
                
                return 
                    "Data Source=D530\\SQLEXPRESS;Initial Catalog=ControleDeEstoque;Integrated Security=True";
            }
        }
    }
}
