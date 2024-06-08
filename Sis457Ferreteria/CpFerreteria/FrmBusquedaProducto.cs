using CadFerreteria;
using ClnFerreteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpFerreteria
{
    public partial class FrmBusquedaProducto : Form
    {
        public Producto _producto { get; set; }
        public FrmBusquedaProducto()
        {
            InitializeComponent();
        }

        private void FrmBusquedaProducto_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void listar()
        {
            var lista = ProductoCln.listarPa(txtParametro.Text.Trim());
            dgvListaProducto.DataSource = lista;
            dgvListaProducto.Columns["id"].Visible = false;
            dgvListaProducto.Columns["estado"].Visible = false;
            dgvListaProducto.Columns["codigo"].HeaderText = "Código";
            dgvListaProducto.Columns["descripcion"].HeaderText = "Descripción";
            dgvListaProducto.Columns["marca"].HeaderText = "Marca";
            dgvListaProducto.Columns["unidadMedida"].HeaderText = "Unidad de Medida";
            dgvListaProducto.Columns["precioVenta"].HeaderText = "Precio de Venta";
            dgvListaProducto.Columns["stock"].HeaderText = "Stock";
            dgvListaProducto.Columns["usuarioRegistro"].Visible = false;
            dgvListaProducto.Columns["fechaRegistro"].Visible = false;
            dgvListaProducto.Columns["idCategoria"].Visible = false;
            dgvListaProducto.Enabled = lista.Count > 0;
            dgvListaProducto.Enabled = lista.Count > 0;
            if (lista.Count > 0) dgvListaProducto.Rows[0].Cells["codigo"].Selected = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar();
        }

        private void txtParametro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) listar();
        }

        private void dgvListaProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            if(row >= 0 && column > 0)
            {
                _producto = new Producto()
                {
                    id = Convert.ToInt32(dgvListaProducto.Rows[row].Cells["id"].Value.ToString()),
                    codigo = dgvListaProducto.Rows[row].Cells["codigo"].Value.ToString(),
                    descripcion = dgvListaProducto.Rows[row].Cells["descripcion"].Value.ToString(),
                    precioVenta = Convert.ToDecimal(dgvListaProducto.Rows[row].Cells["precioVenta"].Value.ToString()),
                    stock = Convert.ToInt32(dgvListaProducto.Rows[row].Cells["stock"].Value.ToString())
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
