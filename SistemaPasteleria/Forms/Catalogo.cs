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
            bindingSourceCatalogo.DataSource = db.Catalogos.ToList();
            bindingSourceMaterial.DataSource = db.Materials.ToList();
            Models.Catalogo objCatalogo = bindingSourceCatalogo.Current as Models.Catalogo;
            Models.Material objMaterial = bindingSourceMaterial.Current as Models.Material;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DBContext db = new DBContext();
            Models.Catalogo objCatalogo = bindingSourceCatalogo.Current as Models.Catalogo;
            Models.Material objMaterial = bindingSourceMaterial.Current as Models.Material;
            if (objCatalogo != null && objMaterial != null)
            {
                if (db.Entry<Models.Catalogo>(objCatalogo).State == EntityState.Detached)
                    db.Set<Models.Catalogo>().Attach(objCatalogo);
              //  if (objCatalogo.IdCatalogo == 0)
                    db.Entry<Models.Catalogo>(objCatalogo).State = EntityState.Added;
                //else
                  //  db.Entry<Models.Catalogo>(objCatalogo).State = EntityState.Modified;
                db.SaveChanges();
                dgvReceta.Refresh();
            }
        }
    }
}
