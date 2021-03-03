using SistemaPasteleria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPasteleria.Forms
{
    public partial class CatalogoForm : Form
    {
        public CatalogoForm()
        {
            InitializeComponent();
        }

        private void CatalogoForm_Load(object sender, EventArgs e)
        {
            //Para cargar datos al grid
            loadData();
            btnUpdate.Enabled = false;
            btnAgregar.Enabled = true;

            //Para que no aparezaca una dato del grid seleccionado
            cleanInputs();
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Models.Catalogo newCatalogo = getInformation();
            Models.Material newMaterial = getMaterial(newCatalogo);

            if (!string.IsNullOrEmpty(newCatalogo.Nombre))
            {
                using (DBContext db = new DBContext())
                {
                    //Para crear encabezado de materia prima
                    db.Catalogos.Add(newCatalogo);
                    db.Materials.Add(newMaterial);
                    db.SaveChangesAsync();

                    //Notificar que el dato se aguardo correctamente
                    MetroFramework.MetroMessageBox.Show(this, "El dato se ha agrego correctamente");

                    //Refrescar el grid y traer los datos de la base
                    loadData();
                    cleanInputs();
                }
            }
        }

        private Models.Catalogo getInformation()
        {
            Models.Catalogo catalogo = new Models.Catalogo();
            catalogo.Nombre = txtNombre.Text;

            return catalogo;
        }

        private Models.Material getMaterial(Models.Catalogo cat)
        {
            Models.Material material = new Models.Material();
            //material.IdCatalogo = Convert.ToInt32(txtId.Text.Trim());
            material.Catalogo = cat;
            material.CantidadDisponible = Convert.ToDouble(txtCantidadDisp.Text.Trim());
            material.CantidadInicial = Convert.ToDouble(txtCantidadInicial.Text.Trim());
            material.Precio = Convert.ToDouble(txtPrecioTotal.Text.Trim());
            material.PrecioGramo = Convert.ToDouble(txtPrecioGr.Text.Trim());
            return material;
        }
        private void loadData(string busqueda = null)
        {
            using (DBContext db = new DBContext())
            {
                if (string.IsNullOrEmpty(busqueda))
                {
                    catalogoBindingSource.DataSource = db.Catalogos.ToList();
                    materialBindingSource.DataSource = db.Materials.ToList();

                }
                else {
                    //Funcion para buscar y cargar los datos de la busqueda en el grid
                  //  catalogoBindingSource.DataSource = db.Catalogos.Where(x => x.Nombre.ToLower().Contains(busqueda.ToLower())).ToList();
                    materialBindingSource.DataSource = db.Catalogos.Where(x => x.Nombre.ToLower().Contains(busqueda.ToLower())).ToList();
                }
            }
        }

        private void dgDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnAgregar.Enabled = false;
            btnCancel.Enabled = true;
            DBContext db = new DBContext();
            catalogoBindingSource.DataSource = db.Catalogos.Where(x => x.Nombre.ToLower().Contains(txtNombre.Text)).ToList();
        }

        public void cleanInputs() {

            //Se mueve al ultimo dato de la tabla
            materialBindingSource.MoveLast();
            //Se obtiene el valor del ultimo dato de la tabla
            Models.Catalogo obj = catalogoBindingSource.Current as Models.Catalogo;
            Models.Material obj2 = materialBindingSource.Current as Models.Material;

            //Se pregunta si es un objeto de base de datos o es uno vacio
            if (obj.IdCatalogo != 0)
            {
                //De ser un objeto de la base de datos, se agrega un nuevo objeto vacio
                catalogoBindingSource.Add(new Models.Catalogo());
                materialBindingSource.Add(new Models.Material());
                //Y se mueve a dicho objeto.
                catalogoBindingSource.MoveLast();
                materialBindingSource.MoveLast();
            }         
            btnUpdate.Enabled = false;
            btnAgregar.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cleanInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //es recomondable usar otro contexto, aun asi no me funciono
            //Models.Catalogo catalogo = catalogoBindingSource.Current as Models.Catalogo;
            Models.Material material = materialBindingSource.Current as Models.Material;
            using (DBContext context = new DBContext()) {
                context.Entry<Models.Material>(material).State = EntityState.Modified;
              //  context.Entry<Models.Catalogo>(catalogo).State = EntityState.Modified;
                context.SaveChangesAsync();
                MetroFramework.MetroMessageBox.Show(this, "El dato se ha actualizado correctamente");
                dgDatos.Refresh();
              //  cleanInputs();

            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscador.Text))
            {
                loadData();
                cleanInputs();
            }
            else {
                loadData(txtBuscador.Text);
                cleanInputs();
                //MetroFramework.MetroMessageBox.Show(this, "El dato que se busca es: " + txtBuscador.Text);
            }
        }
    }
}
