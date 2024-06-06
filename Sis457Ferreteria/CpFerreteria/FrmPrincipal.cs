using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpFerreteria
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnCaProductos_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmProducto());
        }

        private void btnAdUsuario_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmUsuario());
        }
    }
}
