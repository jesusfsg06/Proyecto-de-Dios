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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miembros mb = new miembros();
            mb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            muebles mb = new muebles();
            mb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            diezmo de = new diezmo();
            de.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ofrenda of = new ofrenda();
            of.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            actualizar_miembros mb = new actualizar_miembros();
            mb.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            actualizar_muebles mb = new actualizar_muebles();
            mb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            agregar_ofrenda of = new agregar_ofrenda();
            of.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            actualizar_ofrenda ao = new actualizar_ofrenda();
            ao.Show();
        }

        private void nuevoMiembroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro re = new registro();
            re.Show();
        }

        private void nuevoMiembroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            miembros mi = new miembros();
            mi.Show();
        }

        private void nuevosMueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muebles mu = new muebles();
            mu.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diezmo di = new diezmo();
            di.Show();
        }

        private void agregarOfrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofrenda of = new ofrenda();
            of.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            miembros mi = new miembros();
            mi.Show();
        }

        private void mueblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            muebles mu = new muebles();
            mu.Show();
        }

        private void diezmosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diezmo di = new diezmo();
            di.Show();
        }

        private void ofrendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofrenda of = new ofrenda();
            of.Show();
        }

        private void miembrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            actualizar_miembros am = new actualizar_miembros();
            am.Show();
        }

        private void mueblesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            actualizar_muebles amu = new actualizar_muebles();
            amu.Show();
        }

        private void diezmosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            actualizar_ofrenda ao = new actualizar_ofrenda();
            ao.Show();
        }

        private void ofrendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregar_ofrenda aof = new agregar_ofrenda();
            aof.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acercade ac = new acercade();
            ac.Show();
        }
    }
}
