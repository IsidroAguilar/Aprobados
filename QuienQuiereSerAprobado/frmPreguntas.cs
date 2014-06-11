using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
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
            Datos.contadorRespuestas = 0;
            BackgroundImage = Image.FromFile("Diseño/frmPreguntasNaranja.png");
            Datos.GenerarRandomPregunta();
            lblPregunta.Text = Datos.pregunta;
            Datos.GenerarRandomRespuestas();
            btnRespuesta1.Text = Datos.listaNumerosRespuestas[0].ToString();
            btnRespuesta2.Text = Datos.listaNumerosRespuestas[1].ToString();
            btnRespuesta3.Text = Datos.listaNumerosRespuestas[2].ToString();
            btnRespuesta4.Text = Datos.listaNumerosRespuestas[3].ToString();

            Datos.GenerarRespuestas();

            #region BOTÓN 1 POSIBILIDADES RESPUESTAS
            if (btnRespuesta1.Text == "1") // Respuesta Correcta
            {
                btnRespuesta1.Text = Datos.respuesta;
            }

            if (btnRespuesta1.Text == "2") // Opción 1
            {
                btnRespuesta1.Text = Datos.opcion1;
            }

            if (btnRespuesta1.Text == "3") // Opción 2
            {
                btnRespuesta1.Text = Datos.opcion2;
            }

            if (btnRespuesta1.Text == "4") // Opción 3
            {
                btnRespuesta1.Text = Datos.opcion3;
            }
            #endregion

            #region BOTÓN 2 POSIBILIDADES RESPUESTAS
            if (btnRespuesta2.Text == "1") // Respuesta Correcta
            {
                btnRespuesta2.Text = Datos.respuesta;
            }

            if (btnRespuesta2.Text == "2") // Opción 1
            {
                btnRespuesta2.Text = Datos.opcion1;
            }

            if (btnRespuesta2.Text == "3") // Opción 2
            {
                btnRespuesta2.Text = Datos.opcion2;
            }

            if (btnRespuesta2.Text == "4") // Opción 3
            {
                btnRespuesta2.Text = Datos.opcion3;
            }
            #endregion

            #region BOTÓN 3 POSIBILIDADES RESPUESTAS
            if (btnRespuesta3.Text == "1") // Respuesta Correcta
            {
                btnRespuesta3.Text = Datos.respuesta;
            }

            if (btnRespuesta3.Text == "2") // Opción 1
            {
                btnRespuesta3.Text = Datos.opcion1;
            }

            if (btnRespuesta3.Text == "3") // Opción 2
            {
                btnRespuesta3.Text = Datos.opcion2;
            }

            if (btnRespuesta3.Text == "4") // Opción 3
            {
                btnRespuesta3.Text = Datos.opcion3;
            }
            #endregion

            #region BOTÓN 4 POSIBILIDADES RESPUESTAS
            if (btnRespuesta4.Text == "1") // Respuesta Correcta
            {
                btnRespuesta4.Text = Datos.respuesta;
            }

            if (btnRespuesta4.Text == "2") // Opción 1
            {
                btnRespuesta4.Text = Datos.opcion1;
            }

            if (btnRespuesta4.Text == "3") // Opción 2
            {
                btnRespuesta4.Text = Datos.opcion2;
            }

            if (btnRespuesta4.Text == "4") // Opción 3
            {
                btnRespuesta4.Text = Datos.opcion3;
            }
            #endregion


        }

        private void btnRespuesta1_Click(object sender, EventArgs e)
        {
            if (btnRespuesta1.Text == Datos.respuesta)
            {
                btnRespuesta1.Enabled = false;
                btnRespuesta1.ForeColor = Color.LimeGreen;
                btnRespuesta2.ForeColor = Color.Red;
                btnRespuesta3.ForeColor = Color.Red;
                btnRespuesta4.ForeColor = Color.Red;
            }
            else
            {
                btnRespuesta1.ForeColor = Color.Red;
            }
        }

        private void btnRespuesta2_Click(object sender, EventArgs e)
        {
            if (btnRespuesta2.Text == Datos.respuesta)
            {
                btnRespuesta2.ForeColor = Color.LimeGreen;

                btnRespuesta1.ForeColor = Color.Red;

                btnRespuesta3.ForeColor = Color.Red;

                btnRespuesta4.ForeColor = Color.Red;
     
            }
            else
            {
                btnRespuesta2.ForeColor = Color.Red;
            }
        }

        private void btnRespuesta3_Click(object sender, EventArgs e)
        {
            if (btnRespuesta3.Text == Datos.respuesta)
            {
                btnRespuesta3.ForeColor = Color.LimeGreen;

                btnRespuesta1.ForeColor = Color.Red;

                btnRespuesta2.ForeColor = Color.Red;

                btnRespuesta4.ForeColor = Color.Red;

            }
            else
            {
                btnRespuesta3.ForeColor = Color.Red;
            }
        }

        private void btnRespuesta4_Click(object sender, EventArgs e)
        {
            if (btnRespuesta4.Text == Datos.respuesta)
            {
                btnRespuesta4.ForeColor = Color.LimeGreen;

                btnRespuesta1.ForeColor = Color.Red;

                btnRespuesta3.ForeColor = Color.Red;

                btnRespuesta2.ForeColor = Color.Red;

            }
            else
            {
                btnRespuesta4.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            this.Hide();
            frm.Show();
        }

    }   

}
