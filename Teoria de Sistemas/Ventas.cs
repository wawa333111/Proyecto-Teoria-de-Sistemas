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
    public partial class Ventas : Form
    {
        public static bool visible = false;

        public Ventas()
        {
            InitializeComponent();
        }

        public Form MDI
        {
            set
            {
                this.MdiParent = value;
                visible = true;
            }
        }

        private void Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            visible = false;
        }
    }
}
