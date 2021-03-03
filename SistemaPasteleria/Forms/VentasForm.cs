using SistemaPasteleria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPasteleria.Forms
{
    public partial class VentasForm : Form
    {
        DBContext db;
        public VentasForm()
        {
            InitializeComponent();
            db = new DBContext();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            LoadData();
            Receta receta = recetaBindingSource.Current as Receta;

            if (receta != null)
            {
                lblTotal.Text = receta.Precio.ToString();
            }else
            {
                lblTotal.Text = "0.0";
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Receta receta = recetaBindingSource.Current as Receta;
            txtCantidad.Value = 1;
            lblTotal.Text = (receta.Precio * double.Parse((txtCantidad.Value).ToString())).ToString();
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = (double.Parse(lblPrecio.Text) * double.Parse((txtCantidad.Value).ToString())).ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (int.Parse(lblIdReceta.Text) != 0)
            {
                Venta venta = new Venta();
                venta.Cantidad = (double) txtCantidad.Value;
                venta.IdReceta = int.Parse(lblIdReceta.Text);
                venta.PrecioUnitario = double.Parse(lblPrecio.Text);
                venta.Fecha = DateTime.Now;

                db.Ventas.Add(venta);
                db.SaveChanges();

                Receta receta = recetaBindingSource.Current as Receta;
                txtCantidad.Value = 1;
                lblTotal.Text = (receta.Precio * double.Parse((txtCantidad.Value).ToString())).ToString();

                MetroFramework.MetroMessageBox.Show(this, "La venta se ha realizado con éxito");
            }
        }

        public void LoadData(string buscador = null)
        {

            if (string.IsNullOrEmpty(buscador))
            {
                recetaBindingSource.DataSource = db.Recetas.ToList();
            }
            else
            {
                recetaBindingSource.DataSource = db.Recetas.Where(x => x.Nombre.ToLower().Contains(buscador.ToLower())).ToList();

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                LoadData();
            }
            else
            {
                LoadData(txtBuscar.Text);
            }
        }
    }
}
