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
using SistemaPasteleria.Models;

namespace SistemaPasteleria.Forms
{
    public partial class Catalogo : Form
    {
        Models.Catalogo modelCata = new Models.Catalogo();
        Models.Material modelMaterial = new Models.Material();
        public Catalogo()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Catalogo_Load(object sender, EventArgs e)
        {
            DBContext db = new DBContext();
        }


        //ME DIO PEDO PARA HACER EL SELECT, NO SE QUE PEDO
        public void cargarGrid()
        {
            DBContext db = new DBContext();
          //  dgvReceta.DataSource = db.Materials.ToList<modelMaterial>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //crear encabezado
            DBContext db = new DBContext();
            parametrosCatalogo();
            db.Catalogos.Add(modelCata);
            db.SaveChanges();
            //no se si se puede usar el mismo obj, no quise probar
            //crear detalle de encabezado
            DBContext dbMaterial = new DBContext();
            parametrosDetalleCatalogo();
            dbMaterial.Materials.Add(modelMaterial);
            dbMaterial.SaveChanges();
            MessageBox.Show("Se agrego");
        }

        public void parametrosCatalogo()
        {
            modelCata.IdCatalogo = Convert.ToInt32( txtIdCatalogo.Text);
            modelCata.Nombre = txtCatalogo.Text.Trim();
        }

        public void parametrosDetalleCatalogo()
        {
            // modelMaterial.IdCatalogo = Convert.ToInt32(txtIdCatalogo.Text);
            modelMaterial.IdMaterial = Convert.ToInt32(txtIdMateria.Text.Trim());
            modelMaterial.IdCatalogo = Convert.ToInt32(txtIdCatalogo.Text);
            modelMaterial.CantidadInicial = Convert.ToDouble(txtcantInicial.Text.Trim());
            modelMaterial.CantidadDisponible = Convert.ToDouble(txtcantInicial.Text.Trim());
            modelMaterial.PrecioGramo = Convert.ToDouble(txtprecioGr.Text.Trim());
            modelMaterial.Precio = Convert.ToDouble(txtPrecioFin.Text.Trim());
        }

        //no funciono
        public void metodoUno()
        {
           // Models.Catalogo objCatalogo = bindingSourceCatalogo.Current as Models.Catalogo;
            //if (objCatalogo != null)
            //{
                /*
                if (db.Entry<Models.Catalogo>(objCatalogo).State == EntityState.Detached)
                    db.Set<Models.Catalogo>().Attach(objCatalogo);
                if (objCatalogo.IdCatalogo == 0)
                    db.Entry<Models.Catalogo>(objCatalogo).State = EntityState.Added;
                else
                    db.Entry<Models.Catalogo>(objCatalogo).State = EntityState.Modified;
                db.SaveChanges();
                dgvReceta.Refresh();*/
        //    }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCatalogo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
