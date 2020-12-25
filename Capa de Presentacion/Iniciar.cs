using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_de_Presentacion
{
    public partial class Iniciar : Form
    {
        validar objeto = new validar();

        public Iniciar()
        {
            InitializeComponent();
        }

        private void entrar_Click(object sender, EventArgs e)
        {     

            if(objeto.ValidarParametro(login.Text, contralogin.Text) > 0)
            {
                MessageBox.Show("Bienvenido Usuario");

                this.Close();
            }
            else if (login.Text == "Admin" && contralogin.Text == "equipo4")
            {
                Administrador_Archundia form = new Administrador_Archundia();
                form.Show();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
         
        }
    }
}
