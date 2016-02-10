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
    public partial class actualizar_muebles : Form
    {
        public actualizar_muebles()
        {
            InitializeComponent();
        }
        crud obcrud = new crud();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void actualizar_muebles_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = obcrud.consultar3("vs_church_items","hidden= 0");
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.ValueMember = "item_Id";
            this.comboBox1.Refresh();
            

        }

        private void button1_Click(object sender, EventArgs e)
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
                    if (txt_valor.Text == "")
                    {
                        MessageBox.Show("La Cantidad No Puede Ir en Blanco");
                        txt_valor.Select();
                        txt_valor.Focus();
                    }
                    else
                    {
                        string campos = "name ='" + this.txt_nombre.Text + "',amount ='" + this.txt_cantidad.Text + "',value ='" + this.txt_valor.Text + "',buy_date ='" + this.dateTimePicker1.Value + "',state ='" + this.cbx_estado.Text + "',notes ='" + this.richTextBox1.Text + "'";
                        if (obcrud.actualizar("vs_church_items", campos, "item_Id = '" + this.comboBox1.SelectedValue.ToString() + "'"))
                        {
                            MessageBox.Show("Se a Actualizado Correctamente");
                            muebles mb = new muebles();
                            mb.Show();
                        }
                        else
                        {
                            MessageBox.Show("no se pudo actualizar");
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
