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
    public partial class Inventario : Form
    {
        public static bool visible = false;
        string consulta = "";

        public Inventario()
        {
            InitializeComponent();
            Datos.dcomboBox(comboBox1, "tipoProductos", "nombreTipoProducto");
            Datos.dcomboBox(comboBox2, "Proveedores", "nombre");
            consulta = "select "
            + "A.cantidad as Cantidad, "
            + "A.nombre as Nombre, "
            + "A.imagen as Imagen, "
            + "B.nombre as Proveedor, "
            + "C.nombreTipoProducto as Tipo, "
            + "A.descripcion as Descripción "
            + "from Productos A inner join Proveedores B on A.id_Proveedor = B.id_Proveedor "
            + "inner join tipoProductos C on A.id_tipoProducto = C.id_tipoProducto ";
            dataGridView1.DataSource = Datos.dataGrid(consulta);
        }

        public Form MDI
        {
            set
            {
                this.MdiParent = value;
                visible = true;
            }
        }

        private void Inventario_FormClosed(object sender, FormClosedEventArgs e)
        {
            visible = false;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = Datos.dataGrid(consulta
            + "where A.nombre like '" + textBox1.Text + "%' "
            + "and B.nombre like '" + (comboBox2.Text == "-Todos-" ? "%" : comboBox2.Text) + "' "
            + "and C.nombreTipoProducto like '" + (comboBox1.Text == "-Todos-" ? "%" : comboBox1.Text) + "'"
            );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Ingreso ni miercoles");
        }
    }
}
