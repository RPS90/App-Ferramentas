using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecretarySimulator
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            //lblRelogio.Text = DateTime.Now.ToLongTimeString(); 

         BT_iniciar.Enabled = true;
         BT_iniciar.Visible = true;                  
         BT_iniciar2.Enabled = false;
         BT_iniciar2.Visible = false;
         gb_Menu.Enabled = false;
         gb_Menu.Visible = false;   
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           // lblRelogio.Text = DateTime.Now.ToLongTimeString(); //pega tempo atual do SEU PC
            lblRelogio.Text = DateTime.Now.ToString();
       
        }   

        private void BT_iniciar_Click(object sender, EventArgs e)
        {
            BT_iniciar.Enabled = false;
            BT_iniciar.Visible = false; 
            BT_iniciar2.Enabled = true;
            BT_iniciar2.Visible = true;
            gb_Menu.Enabled = true;
            gb_Menu.Visible = true;
        }
        private void BT_iniciar2_Click(object sender, EventArgs e)
        {            
            BT_iniciar2.Enabled = false;
            BT_iniciar2.Visible = false;
            BT_iniciar.Enabled = true;
            BT_iniciar.Visible = true; 
            gb_Menu.Enabled = false;
            gb_Menu.Visible = false;
        }

        private void BT_iniciar_MouseEnter(object sender, EventArgs e)
        {
            if (gb_Menu.Visible == false)
            BT_iniciar2.Visible = true;            
        }
        private void BT_iniciar_MouseLeave(object sender, EventArgs e)
        {
            if (gb_Menu.Visible == false)
            BT_iniciar2.Visible = false;
        }   


        private void btAgenda_Click(object sender, EventArgs e)
        {
            IniciarEstadoNormal(); //fecha inicar
            FormAgenda f = new FormAgenda(); //Instanciei FormAgenda como 'f'
            f.ShowDialog();
            f.Dispose();
            
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }








        private void IniciarEstadoNormal()//iniciar em estado normal
        {
            gb_Menu.Enabled = false;
            gb_Menu.Visible = false;   
            BT_iniciar.Enabled = true;
            BT_iniciar.Visible = true;
            BT_iniciar2.Enabled = false;
            BT_iniciar2.Visible = false;
                 
        }

        private void Tela_principal_Click(object sender, EventArgs e)
        {
            IniciarEstadoNormal();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            IniciarEstadoNormal(); //fecha inicar
            FormCalculadora f = new FormCalculadora();
            f.ShowDialog();
            f.Dispose();
        }

        private void btQuiz_Click(object sender, EventArgs e)
        {
            IniciarEstadoNormal(); //fecha inicar
            FormQuiz f = new FormQuiz();
            f.ShowDialog();
            f.Dispose();
        }

        private void btTarefas_Click(object sender, EventArgs e)
        {
            IniciarEstadoNormal(); //fecha inicar
            FormTarefas f = new FormTarefas();
            f.ShowDialog();
            f.Dispose();
        }

        private void btBancodados_Click(object sender, EventArgs e)
        {

        }

     
      

   
       
  

      
    }
}
