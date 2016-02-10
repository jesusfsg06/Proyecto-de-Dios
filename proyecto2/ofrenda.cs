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
    public partial class ofrenda : Form
    {
        MySqlConnection con = new MySqlConnection();

        public ofrenda()
        {
            InitializeComponent();
        }
        crud obcrud = new crud();
        private void ofrenda_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = obcrud.consultar6("vs_members");
            this.comboBox1.DisplayMember = "first_name";
            this.comboBox1.ValueMember = "member_Id";
            this.comboBox1.Refresh();

            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto2; password=");
                cn.Open();
                cmd = new MySqlCommand("SELECT member_Id, money, notes, date FROM vs_offering WHERE hidden=0", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.dgofrenda.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btn_salir_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void dgofrenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (txt_dinero.Text == "")
            {
                MessageBox.Show("Monto de Dinero No Puede Ir en Blanco");
                txt_dinero.Select();
                txt_dinero.Focus();
            }
            else
            {
                string sql = "insert into vs_offering (member_Id, money, notes, date) values ('" + this.comboBox1.Text + "','" + this.txt_dinero.Text + "','" + this.richTextBox1.Text + "','" + this.dateTimePicker1.Value + "')";
                if (obcrud.insertar(sql))
                {
                    MessageBox.Show("Se ha agregado Correctamente");
                    dgofrenda.Refresh();

                }
                else
                {
                    MessageBox.Show("No Se ha Podido insertar");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object celda;

            celda = dgofrenda.CurrentCell.Value;

            string condicion = "member_Id='" + celda + "'";
            if (obcrud.actualizar("vs_offering", "hidden = 1", condicion))
            {
                dgofrenda.Refresh();
                int fill = dgofrenda.CurrentRow.Index;
                dgofrenda.Rows.RemoveAt(fill);
            }
            else
            {
                MessageBox.Show("No Se ha Podido Eliminar, correctamente. Debe seleccionar el nombre y luego darle a Eliminar.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agregar_ofrenda ao = new agregar_ofrenda();
            ao.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            miembros mb = new miembros();
            mb.Show();
        }
    }
}
