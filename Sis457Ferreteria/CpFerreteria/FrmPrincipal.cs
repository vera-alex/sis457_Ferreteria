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
        FrmAutenticacion frmAutenticacion;

        public FrmPrincipal(FrmAutenticacion frmAutenticacion)
        {
            InitializeComponent();
            this.frmAutenticacion = frmAutenticacion;
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

        private void btnCVVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmVenta());
        }

        private void btnReRegistroVentas_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmReporteVenta());
        }

        private void btnReRegistroCompras_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmReporteCompra());
        }

        private void btnAdEmpleado_Click(object sender, EventArgs e)
        {
            abrirFormulario(new FrmEmpleado());
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAutenticacion.Visible = true;
        }
    }
}
