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
    public partial class Administrador_Archundia : Form
    {
        validar objetoo = new validar();


        public Administrador_Archundia()
        {
            InitializeComponent();
        }

        private void Administrador_Archundia_Load(object sender, EventArgs e)
        {
            MostrarTabloide();
        }

        private void MostrarTabloide()
        {
            TablaData.DataSource = objetoo.MostrarTabla();         

        }

    }
}
