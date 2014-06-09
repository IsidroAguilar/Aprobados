using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using QuienQuiereSerAprobado.Lógica;

namespace QuienQuiereSerAprobado
{


    public partial class frmPreguntas : Form
    {
        #region OBJETOS
        clsDatos Datos = new clsDatos();

        #endregion

        public frmPreguntas()
        {
            InitializeComponent();
        }

        private void frmPreguntas_Load(object sender, EventArgs e)
        {
            Datos.listaNumerosRespuestas.Clear();
            Datos.contador = 0;
            BackgroundImage = Image.FromFile("Diseño/frmPreguntasNaranja.png");
            Datos.GenerarRandomPregunta();
            lblPregunta.Text = Datos.pregunta;
            Datos.GenerarRandomRespuestas();
            btnRespuesta1.Text = Datos.listaNumerosRespuestas[0].ToString();
            btnRespuesta2.Text = Datos.listaNumerosRespuestas[1].ToString();
            btnRespuesta3.Text = Datos.listaNumerosRespuestas[2].ToString();
            btnRespuesta4.Text = Datos.listaNumerosRespuestas[3].ToString();

            if (btnRespuesta1.Text == "1")
            {
                Datos.GenerarRespuestaCorrecta();
                btnRespuesta1.Text = Datos.respuesta.ToString();
            }
            else
            {
                
            }

            if (btnRespuesta2.Text == "1")
            {
                Datos.GenerarRespuestaCorrecta();
                btnRespuesta2.Text = Datos.respuesta.ToString();
            }
            else
            {
                
            }

            if (btnRespuesta3.Text == "1")
            {
                Datos.GenerarRespuestaCorrecta();
                btnRespuesta3.Text = Datos.respuesta.ToString();
            }
            else
            {
                
            }

            if (btnRespuesta4.Text == "1")
            {
                Datos.GenerarRespuestaCorrecta();
                btnRespuesta4.Text = Datos.respuesta.ToString();
            }
            else
            {
                
            }
           
        }

    }

}
