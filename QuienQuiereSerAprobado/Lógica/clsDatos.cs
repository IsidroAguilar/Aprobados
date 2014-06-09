using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace QuienQuiereSerAprobado.Lógica
{
    class clsDatos
    {
        Random random = new Random();
        OleDbCommand command = new OleDbCommand();
        OleDbDataReader read;
        OleDbConnection conexion = new OleDbConnection();

        #region "VARIABLES LALO"
        public List<int> listaNumerosRespuestas = new List<int>(4);
        private List<int> listaNumerosPreguntas = new List<int>(4);
        public int maximo { get; set; }
        public int numpregunta { get; set; }
        public string pregunta { get; set; }
        public string respuesta { get; set; }
        public int contador;
        #endregion


        public clsDatos()
        {

        }

        public void GenerarRandomPregunta() //Se genera el número random de pregunta de la 1 hasta X 
        {
            int aleatorio = random.Next(1, 11);
            while (listaNumerosPreguntas.Contains(aleatorio)) // Si se repite el número de pregunta se genera un nuevo número aleatorio
            {
                aleatorio = random.Next(1, 11);
            }
            listaNumerosPreguntas.Add(aleatorio); // Se agrega el número de pregunta a la lista.
            numpregunta = aleatorio; // Es la variable que definirá el número de pregunta en el juego.
            RealizarPregunta(); // Recurre a la consulta para regresar la pregunta.
        }

        public void GenerarRandomRespuestas() //Se genera el número random de respuestas de la 1 hasta 4 (Con el fin de que queden en desordén las repsuestas) 
        {
            int aleatorio = random.Next(1, 5);
            while (contador < 4)
            {
                while (listaNumerosRespuestas.Contains(aleatorio))
                // Si se repite la posición de respuesta se genera un nuevo número aleatorio
                {
                    aleatorio = random.Next(1, 5);
                }
                listaNumerosRespuestas.Add(aleatorio); // Se agrega posición de respuesta a la lista.
                contador++;
            }
        }

        private void RealizarPregunta() // Se hace la consulta a la base de datos para extraer la pregunta.
        {
            conexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD.mdb;Persist Security Info=False";
            command.Connection = conexion;
            try
            {
                string consulta = "SELECT Respuesta FROM 1erSemestre WHERE ID = " + numpregunta;
                command.CommandText = consulta;
                conexion.Open();
                read = command.ExecuteReader();
                if (read != null)
                {
                    while (read.Read())
                    {
                        pregunta = read.GetValue(0).ToString();
                    }
                    read.Close();
                }
                conexion.Close();
            }
            catch (Exception)
            {
                read.Close();
                conexion.Close();
                throw new Exception("Failed to connect to data source");

            }
        }

        public void GenerarRespuestas()
        {
            conexion.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD.mdb;Persist Security Info=False";
            command.Connection = conexion;
            try
            {
                string consulta = "SELECT Respuesta FROM 1erSemestre WHERE ID = " + numpregunta;
                command.CommandText = consulta;
                conexion.Open();
                read = command.ExecuteReader();
                if (read != null)
                {
                    while (read.Read())
                    {
                        respuesta = read.GetValue(0).ToString();
                    }
                    read.Close();
                }
                conexion.Close();
            }
            catch (Exception)
            {
                read.Close();
                conexion.Close();
                throw new Exception("Failed to connect to data source");

            }
        }
    }
}
