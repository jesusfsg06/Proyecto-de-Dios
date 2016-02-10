using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto2
{
    public partial class registro : Form
    {
        public registro()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        crud obcrud = new crud();
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "")
            {
                MessageBox.Show("El nombre No Puede Ir en Blanco");
                txt_nombre.Select();
                txt_nombre.Focus();
            }
            else
            {
                if (txt_usuario.Text == "")
                {
                    MessageBox.Show("El Usuario No Puede Ir en Blanco");
                    txt_usuario.Select();
                    txt_usuario.Focus();
                }
                else
                {
                    if (txt_clave.Text == "")
                    {
                        MessageBox.Show("La Clave No Puede Ir en Blanco");
                        txt_clave.Select();
                        txt_clave.Focus();
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
                            if (txt_denominacion.Text == "")
                            {
                                MessageBox.Show("La denominacion No Puede Ir en Blanco");
                                txt_denominacion.Select();
                                txt_denominacion.Focus();
                            }
                            else
                            {
                                if (textBox2.Text == "")
                                {
                                    MessageBox.Show("El nombre No Puede Ir en Blanco");
                                    textBox2.Select();
                                    textBox2.Focus();
                                }
                                else
                                {
                                    if (txt_direccion1.Text == "")
                                    {
                                        MessageBox.Show("La Direccion No Puede Ir en Blanco");
                                        txt_direccion1.Select();
                                        txt_direccion1.Focus();
                                    }
                                    else
                                    {
                                        if (txt_phone.Text == "")
                                        {
                                            MessageBox.Show("El Telefono No Puede Ir en Blanco");
                                            txt_phone.Select();
                                            txt_phone.Focus();
                                        }
                                        else
                                        {

                                            string sql = "insert into vs_users (username, password, nombre, birthday, gender, direction, phone) values ('" + this.txt_usuario.Text + "','" + this.txt_clave.Text + "','" + this.txt_nombre.Text + "','" + this.dateTimePicker1.Value + "','" + this.cbx_genero.Text + "','" + this.txt_direccion.Text + "','" + this.txt_tel.Text + "')";
                                            if (obcrud.insertar(sql))
                                            {
                                                string sql2 = "insert into vs_church (name, denomination, country, address, fax) value('" + this.textBox2.Text + "','" + this.txt_denominacion.Text + "','" + this.cbx_pais.Text + "','" + this.txt_direccion1.Text + "','" + this.txt_fax.Text + "')";
                                                if (obcrud.insertar(sql2))
                                                {
                                                    menu mn = new menu();
                                                    mn.Show();
                                                }
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
            }

        }
        private void registro_Load(object sender, EventArgs e)
        {

        }
}
}
