﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuienQuiereSerAprobado
{
    public partial class frmPreguntas : Form
    {
        public frmPreguntas()
        {
            InitializeComponent();
        }

        private void frmPreguntas_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("Diseño/frmPreguntas.jpg");
        }
    }
}
