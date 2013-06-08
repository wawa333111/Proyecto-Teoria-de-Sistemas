using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teoria_de_Sistemas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void foco(string nombre)
        {
            foreach (Form i in this.MdiChildren)
                if (i.Text == nombre)
                    i.Focus();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Inventario.visible)
            {
                Inventario inventario = new Inventario();
                inventario.MDI = this;
                inventario.Show();
            }
            else foco("Inventario");
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Ventas.visible)
            {
                Ventas ventas = new Ventas();
                ventas.MDI = this;
                ventas.Show();
            }
            else foco("Ventas");
        }
    }
}
