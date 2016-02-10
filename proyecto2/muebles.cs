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
using MySql.Data;
namespace proyecto2
{
    public partial class muebles : Form
    {
        public muebles()
        {
            InitializeComponent();
        }

        private void dgregistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        crud obcrud = new crud();
        private void muebles_Load(object sender, EventArgs e)
        {
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto2; password=");
                cn.Open();
                cmd = new MySqlCommand("select name, value, amount, buy_date, state, notes from vs_church_items where hidden=0",cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.dgmuebles.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5));

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("El nombre No Puede Ir en Blanco");
                txt_nombre.Select();
                txt_nombre.Focus();
            }
            else
            {
                if (txt_cantidad.Text == "")
                {
                    MessageBox.Show("La Cantidad No Puede Ir en Blanco");
                    txt_cantidad.Select();
                    txt_cantidad.Focus();
                }
                else
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("La Cantidad No Puede Ir en Blanco");
                        textBox1.Select();
                        textBox1.Focus();
                    }
                    else
                    {
                        string sql = "insert into vs_church_items (name, amount, value, buy_date, notes, state) values ('" + this.txt_nombre.Text + "','" + this.txt_cantidad.Text + "','" + this.textBox1.Text + "','" + this.dateTimePicker1.Value + "','" + this.rtb_notas.Text + "','" + this.cbx_estado.Text + "')";
                        if (obcrud.insertar(sql))
                        {
                            MessageBox.Show("Se ha agregado Correctamente");
                            dgmuebles.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("No Se ha Podido insertar");
                        }
                    }
                }
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            actualizar_muebles am = new actualizar_muebles();
            am.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object celda;
            
            celda = dgmuebles.CurrentCell.Value;

            string condicion = "name='" + celda + "'";
            if (obcrud.actualizar("vs_church_items", "hidden = 1", condicion))
            {
                dgmuebles.Refresh();
                int fill = dgmuebles.CurrentRow.Index;
                dgmuebles.Rows.RemoveAt(fill);
            }
            else
            {
                MessageBox.Show("No Se ha Podido Eliminar, correctamente. Debe seleccionar el nombre y luego darle a Eliminar.");
            }
        }

        private void btn_nuevo_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {

        }
    }
}
