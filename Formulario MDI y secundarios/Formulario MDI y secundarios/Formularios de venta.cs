using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario_MDI_y_secundarios
{
    public partial class Formularios_de_venta : Form
    {
        public Formularios_de_venta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "abc123")
            {
                label2.Text = "Clave correcta";
            }
            else
            {
                label2.Text = "Clave incorrecta";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        
    }
    }
}
