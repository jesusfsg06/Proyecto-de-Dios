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
    public partial class miembros : Form
    {
        MySqlConnection con = new MySqlConnection();
        DataSet ds;
        string cadena;
        
        public miembros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void fotoperfil_Click(object sender, EventArgs e)
        {

        }

        private void dgregistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        crud obcrud = new crud();

        private void miembros_Load(object sender, EventArgs e)
        {
            MySqlConnection cn;
            MySqlCommand cmd;
            MySqlDataReader dr;

            try
            {
                cn = new MySqlConnection("server=localhost;user id=root; database=proyecto2; password=");
                cn.Open();
                cmd = new MySqlCommand("select first_name, last_name, Id, gender, telefono, direccion, charge, state, entry_date from vs_members where hidden=0", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    this.dg_miembros.Rows.Add(dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8));

                }
            }
            catch (Exception ex)
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
                if (txt_apellido.Text == "")
                {
                    MessageBox.Show("El Apellido No Puede Ir en Blanco");
                    txt_apellido.Select();
                    txt_apellido.Focus();
                }
                else
                {
                    if (txt_cedula.Text == "")
                    {
                        MessageBox.Show("La Cedula No Puede Ir en Blanco");
                        txt_cedula.Select();
                        txt_cedula.Focus();
                    }
                    else
                    {
                        if (txt_direccion.Text == "")
                        {
                            MessageBox.Show("La Direccion No Puede Ir en Blanco");
                            txt_direccion.Select();
                            txt_direccion.Focus();
                        }
                        else
                        {
                            {
                                if (txt_telefono.Text == "")
                                {
                                    MessageBox.Show("El Telefono No Puede Ir en Blanco");
                                    txt_telefono.Select();
                                    txt_telefono.Focus();
                                }
                                else
                                {
                                    string sql = "insert into vs_members (first_name, last_name, Id, gender, telefono, direccion, charge, state, entry_date) values ('" + this.txt_nombre.Text + "','" + this.txt_apellido.Text + "','" + this.txt_cedula.Text + "','" + this.cbx_genero.Text + "','" + this.txt_telefono.Text + "','" + this.txt_direccion.Text + "','" + this.txt_charge.Text + "','" + this.cbx_estado.Text + "','" + this.dateTimePicker1.Value + "')";
                                    if (obcrud.insertar(sql))
                                    {
                                        MessageBox.Show("Se ha agregado Correctamente");
                                        dg_miembros.Refresh();
                                    }
                                    else
                                    {
                                        MessageBox.Show("No Se ha Podido insertar");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            actualizar_miembros mb = new actualizar_miembros();
            mb.Show();
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            object celda;

            celda = dg_miembros.CurrentCell.Value;

            string condicion = "first_name='" + celda + "'";
            if (obcrud.actualizar("vs_members", "hidden = 1", condicion))
            {
                dg_miembros.Refresh();
                int fill = dg_miembros.CurrentRow.Index;
                dg_miembros.Rows.RemoveAt(fill);
            }
            else
            {
                MessageBox.Show("No Se ha Podido Eliminar, correctamente. Debe seleccionar el nombre y luego darle a Eliminar.");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
