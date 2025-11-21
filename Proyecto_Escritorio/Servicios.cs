using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Escritorio
{
    public partial class Servicios : Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void button_CerrarSesion_Click(object sender, EventArgs e)
        {
            Inicio paginaInicio = new Inicio();
            paginaInicio.Show();
            this.Close();
        }
    }
}
