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
    public partial class login : Form
    {
        MySqlConnection con = new MySqlConnection();
        string cadena;

        public login()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("user.png");

        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_user.Select();
            txt_user.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadena = "server=localhost;user id=root; database=proyecto2; password=";
            con.ConnectionString = cadena;
            con.Open();
            MySqlDataAdapter da= new MySqlDataAdapter("Select count(*) from vs_users where username='"+txt_user.Text+"' and password='"+txt_password.Text+"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    menu ss = new menu();
                    ss.Show();
                }
            else
                {
                    MessageBox.Show("Datos Incorrectos", "Alerta");
                    txt_user.Clear();
                    txt_password.Clear();
                    txt_user.Focus();
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
