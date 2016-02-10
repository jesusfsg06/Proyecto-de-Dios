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
    public partial class actualizar_ofrenda : Form
    {
        public actualizar_ofrenda()
        {
            InitializeComponent();
        }
        crud obcrud = new crud();
        private void button1_Click(object sender, EventArgs e)
        {
            string campos = "member_Id ='" + this.comboBox2.Text + "', money ='" + this.txt_dinero.Text + "', notes ='" + this.richTextBox1.Text + "', date ='" + this.dateTimePicker1.Value + "'";
            if (txt_dinero.Text == "")
            {
                MessageBox.Show("Monto de Dinero No Puede Ir en Blanco");
                txt_dinero.Select();
                txt_dinero.Focus();
            }
            else
            {
                if (obcrud.actualizar("vs_tithe", campos, "member_Id = '" + this.comboBox1.SelectedValue.ToString() + "'"))
                {
                    MessageBox.Show("Se a Actualizado Correctamente");
                    diezmo mb = new diezmo();
                    mb.Show();
                }
                else
                {
                    MessageBox.Show("no se pudo actualizar");
                }
            }
        }

        private void actualizar_diezmo_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = obcrud.consultar4("vs_members");
            this.comboBox1.DisplayMember = "first_name";
            this.comboBox1.ValueMember = "member_Id";
            this.comboBox1.Refresh();

            this.comboBox2.DataSource = obcrud.consultar6("vs_members");
            this.comboBox2.DisplayMember = "first_name";
            this.comboBox2.ValueMember = "member_Id";
            this.comboBox2.Refresh();
        }
    }
}
