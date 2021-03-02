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
            loadUnidad();
            LoadData();
            catalogoBindingSource.DataSource = db.Catalogos.ToList();
            
            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            CleanInputs();
            //CleanInputsMaterial();
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
        private void loadUnidad()
        {
            var listUnidad = db.Unidades.ToList();
            if (listUnidad.Count == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    Unidad unidad = new Unidad();
                    switch (i)
                    {
                        case 0:
                            unidad.Nombre = "Gramos";
                            break;
                        case 1:
                            unidad.Nombre = "Miligramos";
                            break;
                        case 2:
                            unidad.Nombre = "Onzas";
                            break;
                        default:
                            break;
                    }
                    db.Unidades.Add(unidad);
                    db.SaveChangesAsync();
                }


                unidadBindingSource.DataSource = db.Unidades.ToList();
            }
            else
            {
                unidadBindingSource.DataSource = listUnidad;
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

        public void CleanInputsMaterial()
        {

            listaMaterialBindingSource.MoveLast();
            ListaMaterial lista = listaMaterialBindingSource.Current as ListaMaterial;

            if (lista != null)
            {
                if (lista.IdReceta != 0)
                {
                    listaMaterialBindingSource.Add(new ListaMaterial());
                    listaMaterialBindingSource.MoveLast();
                }
            }
            else {
                listaMaterialBindingSource.Add(new ListaMaterial());
                listaMaterialBindingSource.MoveLast();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LoadData();
            CleanInputs();

            btnCancelar.Enabled = false;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = true;
            dtListaM.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Receta receta = recetaBindingSource.Current as Receta;

            db.Recetas.Add(receta);
            db.SaveChangesAsync();

            if (listaMaterialBindingSource.Count > 1)
            {
                listaMaterialBindingSource.MoveLast();
                listaMaterialBindingSource.RemoveCurrent();
            }
            foreach (var item in listaMaterialBindingSource)
            {
                ListaMaterial material = item as ListaMaterial;
                material.Receta = receta;
                db.ListaMaterials.Add(material);
                db.SaveChangesAsync();
            }

            dtListaM.Rows.Clear();
            MetroFramework.MetroMessageBox.Show(this, "La receta se ha agregado correctamente");
            LoadData();
            CleanInputs();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Receta receta = recetaBindingSource.Current as Receta;

            //Para actualizar la receta.
            db.Entry<Receta>(receta).State = EntityState.Modified;
            db.SaveChangesAsync();

            //Para actualizar la lista de materiales de la receta.
            if (listaMaterialBindingSource.Count > 1)
            {
                listaMaterialBindingSource.MoveLast();
                listaMaterialBindingSource.RemoveCurrent();
            }
            foreach (var item in listaMaterialBindingSource)
            {
                ListaMaterial listaMaterial = item as ListaMaterial;
                if (listaMaterial.IdListaMaterial != 0)
                {
                    db.Entry<ListaMaterial>(listaMaterial).State = EntityState.Modified;
                    db.SaveChangesAsync();
                }
                else {
                    listaMaterial.Receta = receta;
                    db.ListaMaterials.Add(listaMaterial);
                    db.SaveChangesAsync();
                }
            }

            dtListaM.Rows.Clear();
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
                listaMaterialBindingSource.DataSource = db.ListaMaterials.Where(x => x.IdReceta == receta.IdReceta).ToList();
                listaMaterialBindingSource.Add(new ListaMaterial());
                listaMaterialBindingSource.MoveLast();
            }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            listaMaterialBindingSource.Remove(listaMaterialBindingSource.Count - 1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Models.Catalogo catalogo = catalogoBindingSource.Current as Models.Catalogo;
            Unidad unidad = unidadBindingSource.Current as Unidad;
            double cantidad = 0;
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                cantidad = double.Parse(txtCantidad.Text);
            }

            ListaMaterial listaMaterial = new ListaMaterial();
            listaMaterial.Catalogo = catalogo;
            listaMaterial.Unidad = unidad;
            listaMaterial.Cantidad = cantidad;

            if (listaMaterialBindingSource.Count > 0)
            {
                listaMaterialBindingSource.RemoveCurrent();
            }
            listaMaterialBindingSource.Add(listaMaterial);
            listaMaterialBindingSource.Add(new ListaMaterial());
            listaMaterialBindingSource.MoveLast();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtListaM.Rows.Count > 0)
            {
                if (listaMaterialBindingSource.Count > 0)
                {
                    ListaMaterial listaMaterial = listaMaterialBindingSource.Current as ListaMaterial;

                    if (listaMaterial.IdListaMaterial != 0)
                    {
                        db.ListaMaterials.Remove(listaMaterial);
                        db.SaveChangesAsync();
                    }
                    listaMaterialBindingSource.RemoveCurrent();
                    listaMaterialBindingSource.MoveLast();
                    listaMaterialBindingSource.RemoveCurrent();
                    listaMaterialBindingSource.Add(new ListaMaterial());
                }
            }
        }
    }
}
