using MejoresPracticasShareDLL;
using MejoresPracticasShareDLL.Entities;
using MejoresPracticasShareDLL.Servicios;
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
            Articulo articulo = new Articulo();
            articulo.Nombre = txtNombre.Text;
            articulo.Categoria =  txtCategoria.Text;
            articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
            articulo.Costo = Convert.ToDecimal(txtCosto.Text);
            articulo.Color = txtColor.Text;

            ArticulosServicio articulosServicio = new ArticulosServicio();

            string mensaje = articulosServicio.AgregarArticulo(articulo);

            MessageBox.Show(mensaje);

            //LogDBEntities db = new LogDBEntities();
            //db.Articulos.Add(articulo);

            //int i = db.SaveChanges();

            //if(i>0)
            //{
            //    MessageBox.Show("Articulo Guardado");
            //}
            //else
            //{
            //    MessageBox.Show("No se pudo guardar articulo");
            //}



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
