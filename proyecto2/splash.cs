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
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("server=localhost;user id=root; database=proyecto2; password=");
            this.progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT user_id FROM vs_users", cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    login entrada = new login();
                    entrada.Show();
                    this.Hide();
                    cn.Close();
                }
                else
                {
                    registro entrada = new registro();
                    entrada.Show();
                    this.Hide();
                    cn.Close();
                }

            }
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
