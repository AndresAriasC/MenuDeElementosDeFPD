using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico
{
    public partial class Login : Form
    {
        PanelDeControl pc = new PanelDeControl();

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

          


            String usuario = "Carlitos02";
            String pass = "1234";
            usuario = campoUser.Text;
            pass = campoUser.Text;
            if (campoUser.Text == "Carlitos02" && campoContra.Text == "1234")
            {
                int i;

                barra.Minimum = 0;
                barra.Maximum = 200;

                for (i = 0; i < 200; i++)
                {
                    barra.Value = i;
                }
                pc.Show();

            }
            else if (usuario != "Carlitos02")
            {
                MessageBox.Show("Usuario Invalida, intente nuevamente");
                campoUser.Clear();
                campoUser.Focus();
            }
            else if (pass != "1234")
            {
                MessageBox.Show("Contraseña Invalida, intente nuevamente");
                campoContra.Clear();
                campoContra.Focus();
            }
            else {
                MessageBox.Show("Los campos no pueden estar vacios");
                campoUser.Focus();
            }



        }

        private void barra_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
