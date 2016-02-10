using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto2
{
    public partial class conection : Form
    {
        MySqlConnection conexion = new MySqlConnection();
        string cadena;

        public conection()
        {
            InitializeComponent();
        }

        private void conection_Load(object sender, EventArgs e)
        {
            try
            {
                cadena = "server=localhost;user id=root; database=proyecto2; password=";
                conexion.ConnectionString = cadena;
                conexion.Open();
                MessageBox.Show("Conectada");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Conexion Fallida" + Convert.ToString(ex));
            }
        }
    }
}
