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

namespace QuienQuiereSerAprobado
{
            

    public partial class frmPreguntas : Form
    {
        #region VARIABLES
        private int pregunta = 0;
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader read;
        OleDbConnection conexion = new OleDbConnection();
        #endregion
        public frmPreguntas()
        {
            InitializeComponent();
        }

        private void frmPreguntas_Load(object sender, EventArgs e)
        {
           conexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD.mdb;Persist Security Info=False";
           command.Connection = conexion;
            BackgroundImage = QuienQuiereSerAprobado.Properties.Resources.frmPreguntasAzul;

            Random random = new Random();
            pregunta = random.Next(0, 11);
            RealizarPregunta();
        }

        private void RealizarPregunta()
        {
            try
            {
                string consulta = "SELECT Pregunta FROM 1erSemestre WHERE ID = " + pregunta;
                command.CommandText = consulta;
                conexion.Open();
                read = command.ExecuteReader();
                if (read != null)
                {
                    while (read.Read())
                    {
                        lblPregunta.Text = read.GetValue(0).ToString();
                        read.Close();
                    }
                }
                conexion.Close();
            }
            catch (Exception)
            {
                read.Close();
                conexion.Close();
                MessageBox.Show("Failed to connect to data source");
            }
        }
    }

}
