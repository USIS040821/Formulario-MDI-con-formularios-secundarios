using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_MDI_y_secundarios
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void formulariosDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form Formularios_de_venta = new Formularios_de_venta();
            Formularios_de_venta.Show();
        }

        private void integrantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Integrantes = new Integrantes();
            Integrantes.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ayuda = new Ayuda();
            Ayuda.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AboutBox1 = new AboutBox1();
            AboutBox1.Show(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cuadroDeDialogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Cuadros_de_dialogos = new Cuadros_de_dialogos();
            Cuadros_de_dialogos.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
