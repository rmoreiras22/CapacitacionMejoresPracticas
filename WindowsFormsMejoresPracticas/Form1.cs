using MejoresPracticasShareDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsMejoresPracticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona  persona = new Persona();
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;

            MessageBox.Show(persona.Nombre + " " + persona.Apellido);

        }
    }
}
