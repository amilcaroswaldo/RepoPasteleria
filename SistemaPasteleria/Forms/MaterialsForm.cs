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
    public partial class MaterialsForm : MetroFramework.Forms.MetroForm
    {
        DBContext db;
        public MaterialsForm()
        {
            InitializeComponent();
            db = new DBContext();
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            catalogoBindingSource.DataSource = db.Catalogos.OrderBy(x => x.Nombre).ToList();

            loadUnidad();

            loadData();
            cleanInputs();
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
            else {
                unidadBindingSource.DataSource = listUnidad;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Material material = materialBindingSource.Current as Material;

            material.CantidadDisponible = material.CantidadInicial;
            material.PrecioGramo = (material.Precio / material.CantidadInicial);

            db.Materials.Add(material);
            db.SaveChangesAsync();
            MetroFramework.MetroMessageBox.Show(this, "Se ha agregado correctamente");

            loadData();
            cleanInputs();

        }

        private void cbCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidadDisponible_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioGramo_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCantidadInicial_Click(object sender, EventArgs e)
        {

        }

        private void txtIdMaterial_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void cleanInputs()
        {

            //Se mueve al ultimo dato de la tabla
            materialBindingSource.MoveLast();
            //Se obtiene el valor del ultimo dato de la tabla
            Material material = materialBindingSource.Current as Material;

            //Se pregunta si es un objeto de base de datos o es uno vacio
            if (material.IdMaterial != 0)
            {
                //De ser un objeto de la base de datos, se agrega un nuevo objeto vacio
                catalogoBindingSource.Add(new Material());

                //Y se mueve a dicho objeto.
                catalogoBindingSource.MoveLast();
            }

        }

        private void loadData(string busqueda = null)
        {

        
                if (string.IsNullOrEmpty(busqueda))
                {
                materialBindingSource.DataSource = db.Materials.ToList();
                materialBindingSource.Add(new Material());
                materialBindingSource.MoveLast();
            }
                else
                {
                    //Funcion para buscar y cargar los datos de la busqueda en el grid
                    materialBindingSource.DataSource = db.Materials.Where(x => x.Catalogo.Nombre.ToLower().Contains(busqueda.ToLower())).ToList();
                    materialBindingSource.Add(new Material());
                    materialBindingSource.MoveLast();
            }
            
        }

        private void htmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscar.Text))
            {
                loadData();
                cleanInputs();
            }
            else
            {
                loadData(txtBuscar.Text);
                cleanInputs();
                //MetroFramework.MetroMessageBox.Show(this, "El dato que se busca es: " + txtBuscador.Text);
            }
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            materialBindingSource.MoveLast();
        }
    }
}
