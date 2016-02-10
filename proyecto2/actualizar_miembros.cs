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
    public partial class actualizar_miembros : Form
    {
        public actualizar_miembros()
        {
            InitializeComponent();
        }
        crud obcrud = new crud();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agregar_miembros_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = obcrud.consultar3("vs_members", "hidden= 0");
            this.comboBox1.DisplayMember = "first_name";
            this.comboBox1.ValueMember = "member_Id";
            this.comboBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string campos = "first_name ='" + this.txt_nombre.Text + "',last_name ='" + this.txt_apellido.Text + "',Id ='" + this.txt_cedula.Text + "',gender ='" + this.cbx_genero.Text + "',telefono ='" + this.txt_telefono.Text + "',direccion ='" + this.txt_direccion.Text + "',charge ='" + this.txt_charge.Text + "',state ='" + this.cbx_estado.Text + "',entry_date ='" + this.dateTimePicker1.Value+ "'";
            if (obcrud.actualizar("vs_members", campos, "member_Id = '" + this.comboBox1.SelectedValue.ToString() + "'"))
            {
                MessageBox.Show("Se a Actualizado Correctamente");
                miembros mb = new miembros();
                mb.Show();
            }
            else
            {
                MessageBox.Show("no se pudo actualizar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
