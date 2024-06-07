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
        private static Form formularioActual = null;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void abrirFormulario(Form formulario)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = formulario;
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

        private void btnCaCategoria_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmCategoria());
        }

        private void btnCaProveedor_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmProveedor());
        }

        private void btnCaCliente_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmCliente());
        }

        private void btnCVCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmCompra());
        }
    }
}
