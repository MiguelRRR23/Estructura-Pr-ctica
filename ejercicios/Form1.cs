﻿using System;
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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listaEnlazadaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaSimple fls = new FrmListaSimple();
            fls.ShowDialog(this);
        }

        private void listaEnlazadaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaCircular flc = new FrmListaCircular();
            flc.ShowDialog(this);
        }

        private void listaEnlazadaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDoble fld = new FrmListaDoble();
            fld.ShowDialog(this);
        }

        private void listaEnlazadaDobleAnálisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaDobleAnalisis flda = new FrmListaDobleAnalisis();
            flda.ShowDialog(this);
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPila fp = new FrmPila();
            fp.ShowDialog(this); //para que se aperture el formulario
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCola fc = new FrmCola();
            fc.ShowDialog(this);
        }
    }
}
