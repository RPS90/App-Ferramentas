namespace Modelo
{
    public class ModeloMesaUsuario
    {
        public ModeloMesaUsuario()
        {
            this.Codigo_Mesa = 0;
            this.Codigo_Usuario = 0;
        }
        public ModeloMesaUsuario(int codigo_mesa, int codigo_usuario)
        {           
            this.Codigo_Mesa = codigo_mesa;
            this.Codigo_Usuario = codigo_usuario;     
        }       
        private int _codigo_mesa;
        public int Codigo_Mesa
        {
            get { return this._codigo_mesa; }
            set { this._codigo_mesa = value; }
        }//mesa-------------------------
        private int _codigo_usuario;
        public int Codigo_Usuario
        {
            get { return this._codigo_usuario; }
            set { this._codigo_usuario = value; }
        }//usuario---------------------
    }//class
}//namespace
