namespace Modelo
{
    public class ModeloMesaMonitor
    {
        public ModeloMesaMonitor()
        {
            this.Codigo_Mesa = 0;
            this.Codigo_Monitor = 0;
        }
        public ModeloMesaMonitor(int codigo_mesa, int codigo_monitor)
        {
            this.Codigo_Mesa = codigo_mesa;
            this.Codigo_Monitor = codigo_monitor;
        }       
        private int _codigo_mesa;
        public int Codigo_Mesa
        {
            get { return this._codigo_mesa; }
            set { this._codigo_mesa = value; }
        }//mesa-------------------------
        private int _codigo_monitor;
        public int Codigo_Monitor
        {
            get { return this._codigo_monitor; }
            set { this._codigo_monitor = value; }
        }//monitor---------------------
    }//class
}//namespace