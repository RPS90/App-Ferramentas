namespace Modelo
{
    public class ModeloMesaComputador
    {
        public ModeloMesaComputador()
        {
            this.Codigo_Mesa = 0;
            this.Codigo_Computador = 0;
        }
        public ModeloMesaComputador(int codigo_mesa, int codigo_computador)
        {
            this.Codigo_Mesa = codigo_mesa;
            this.Codigo_Computador = codigo_computador;
        }
        private int _codigo_mesa;
        public int Codigo_Mesa
        {
            get { return this._codigo_mesa; }
            set { this._codigo_mesa = value; }
        }//mesa-------------------------
        private int _codigo_computador;
        public int Codigo_Computador
        {
            get { return this._codigo_computador; }
            set { this._codigo_computador = value; }
        }//computador---------------------
    }//class
}//namespace