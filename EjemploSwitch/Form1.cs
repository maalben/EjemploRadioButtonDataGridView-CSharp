using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploSwitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            string nombre;
            string apellido;
            string edad;
            string genero;

            nombre = txtnombre.Text;
            apellido = txtapellido.Text;
            edad = txtedad.Text;

            if (rbhombre.Checked)
            {
                genero = "HOMBRE";
            }
            else if (rbmujer.Checked)
            {
                genero = "MUJER";
            }
            else {
                genero = "";
            }

            if (rbhombre.Checked || rbmujer.Checked) {
                dgempleado.Rows.Add(nombre, apellido, edad, genero);
                txtnombre.Text = String.Empty;
                txtapellido.Text = String.Empty;
                txtedad.Text = String.Empty;
                rbhombre.Checked = false;
                rbmujer.Checked = false;
                txtnombre.Focus();
            }
            else
            {
                MessageBox.Show("Debes marcar una opción de género");

            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbhombre.Checked = false;
            rbmujer.Checked = false;
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Debes escribir un nombre");
                txtnombre.Focus();
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(""+e.KeyChar);

            if ((e.KeyChar >= 32 && e.KeyChar <= 47) ||
                (e.KeyChar >= 58 && e.KeyChar <=255))
            {
                e.Handled = true;
            }
        }
    }
}
