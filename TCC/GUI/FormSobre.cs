using System.Windows.Forms;

namespace GUI
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();
        }

        private void FormSobre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
                this.Close();
        }

        private void btFechar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }





        



















    }
}
