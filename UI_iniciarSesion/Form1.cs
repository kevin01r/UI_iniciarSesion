using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_crearCuenta;

namespace UI_iniciarSesion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            UI_crearCuenta.Form1 frmCrearCuenta = new UI_crearCuenta.Form1();
            frmCrearCuenta.Show();
        }
    }
}
