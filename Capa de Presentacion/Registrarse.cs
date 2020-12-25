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
    public partial class Registrarse : Form
    {
        validar objeto = new validar();


        public Registrarse()
        {
            InitializeComponent();
        }

        private void registroo_Click(object sender, EventArgs e)
        {
            try {

                objeto.InsertarParametros(nomm.Text, contra.Text, email.Text);
                MessageBox.Show("Registro con exito");

            }
            catch(Exception ex)
            {
                
                MessageBox.Show("No se pudo lograr el registro, debido a: "+ ex);

            }
            
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
