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
using System.Data.Entity;

namespace SistemaPasteleria.Forms
{
    public partial class RecetaForm : MetroFramework.Forms.MetroForm
    {
        DBContext db;
        public RecetaForm()
        {
            InitializeComponent();
            db = new DBContext();
        }

        private void RecetaForm_Load(object sender, EventArgs e)
        {
            LoadData();
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            CleanInputs();
        }

        public void LoadData(string buscador = null) {

            if (string.IsNullOrEmpty(buscador))
            {
                recetaBindingSource.DataSource = db.Recetas.ToList();
                recetaBindingSource.Add(new Receta());
            }
            else {
                recetaBindingSource.DataSource = db.Recetas.Where(x => x.Nombre.ToLower().Contains(buscador.ToLower())).ToList();

            }
        }

        public void CleanInputs() {

            recetaBindingSource.MoveLast();
            Receta receta = recetaBindingSource.Current as Receta;

            if (receta !=  null)
            {
                if (receta.IdReceta != 0)
                {
                    recetaBindingSource.Add(new Receta());
                    recetaBindingSource.MoveLast();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LoadData();
            CleanInputs();

            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Receta receta = recetaBindingSource.Current as Receta;

            db.Recetas.Add(receta);
            db.SaveChangesAsync();

            MetroFramework.MetroMessageBox.Show(this, "La receta se ha agregado correctamente");
            LoadData();
            CleanInputs();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Receta receta = recetaBindingSource.Current as Receta;

            db.Entry<Receta>(receta).State = EntityState.Modified;
            db.SaveChangesAsync();
            MetroFramework.MetroMessageBox.Show(this, "La receta se ha actualizado correctamente");
            LoadData();
            CleanInputs();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                LoadData();
                CleanInputs();
            }
            else {
                LoadData(txtBuscar.Text);
                CleanInputs();
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Receta receta = recetaBindingSource.Current as Receta;

            if (receta.IdReceta == 0)
            {
                btnCancelar.Enabled = false;
                btnActualizar.Enabled = false;
                btnAgregar.Enabled = true;
            }
            else {
                btnCancelar.Enabled = true;
                btnActualizar.Enabled = true;
                btnAgregar.Enabled = false;
            }
        }
    }
}
