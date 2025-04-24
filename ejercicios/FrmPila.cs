using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class FrmPila: Form
    {
        clases.Pila p = new clases.Pila();
        public FrmPila()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Apilar
        {
            p.push(textNombre.Text);
            listDatos.Items.Clear();
            p.mostrar(listDatos);
            textNombre.Clear();
        }

        private void button2_Click(object sender, EventArgs e)//Desapilar
        {
            String nom = p.Pop();

            if (nom != null)
            {
                MessageBox.Show($"{ nom} Desapilado correctamente");
                listDatos.Items.Clear();
                p.mostrar(listDatos);
            }
            else
                MessageBox.Show("Pila vacía!");
        }

        private void btnVistazo_Click(object sender, EventArgs e)
        {
            String nom = p.Peek();

            if (nom != null)
            {
                MessageBox.Show($"Cima: {nom}!");
                
            }
            else
                MessageBox.Show("Pila vacía!");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cantidad: " + p.Count());
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            p.Clear();
            listDatos.Items.Clear();
            MessageBox.Show("Pila Limpia!");
        }
    }
}
