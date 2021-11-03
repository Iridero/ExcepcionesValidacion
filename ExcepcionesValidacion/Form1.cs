using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcepcionesValidacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Libro l = new Libro();
            //try
            //{
            //    l.Titulo = "El principito";
            //    l.Titulo = "     ";
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Libro l = new Libro();
            try
            {
                l.Autor = txtAutor.Text;
                l.Año = ushort.Parse(txtAño.Text);
                l.Editorial = txtEditorial.Text;
                l.Existencias = byte.Parse(txtExistencias.Text);
                l.Isbn = txtIsbn.Text;
                l.Paginas = ushort.Parse(txtPaginas.Text);
                l.Precio = decimal.Parse(txtPrecio.Text);
                l.Titulo = txtTitulo.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
