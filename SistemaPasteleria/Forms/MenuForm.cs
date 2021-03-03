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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private const int sizeGrid = 10;
        private const int areMouse = 132;
        private const int botonIzquierdo = 17;
        private Rectangle rectangleGrid;

        //protected override void OnSizeChanged(EventArgs e)
        //{
        //    base.OnSizeChanged(e);

        //    var region = new Region(new Rectangle(0, 0, ClientRectangle.Width, ClientRectangle.Height));

        //    rectangleGrid = new Rectangle(ClientRectangle.Width - sizeGrid, ClientRectangle.Height - sizeGrid, sizeGrid, sizeGrid);

        //    region.Exclude(rectangleGrid);

        //    pnlPrincipal.Region = region;
        //    Invalidate();

            

        //}

        //protected override void WndProc(ref Message sms)
        //{
        //    base.WndProc(ref sms);

        //    switch (sms.Msg)
        //    {
        //        case areMouse:
        //            base.WndProc(ref sms);
        //            var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
        //            if (!rectangleGrid.Contains(RefPoint))
        //            {
        //                break;
        //            }

        //            sms.Result = new IntPtr(botonIzquierdo);
        //            break;
        //        default:
        //            base.WndProc(ref sms);
        //            break;
        //    }
        //}

        //protected override void OnPaint(PaintEventArgs e)
        //{
        //    SolidBrush solidBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
        //    e.Graphics.FillRectangle(solidBrush, rectangleGrid);
        //    base.OnPaint(e);
        //    ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangleGrid);
        //}

        int lx, ly;
        int sw, sh;


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Size = new Size(sw, sh);
            Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "¿Estás Seguro de Cerrar el Programa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnShowCatalogo_Click(object sender, EventArgs e)
        {
            AbrirFormularios<CatalogoForm>();
        }

        private void btnShowVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<VentasForm>();
        }

        private void btnShowRecetas_Click(object sender, EventArgs e)
        {
            AbrirFormularios<RecetaForm>();
        }

        private void btnShowMateriales_Click(object sender, EventArgs e)
        {
            AbrirFormularios<MaterialsForm>();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = Location.X;
            ly = Location.Y;
            sw = Size.Width;
            sh = Size.Height;

            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Location = Screen.PrimaryScreen.WorkingArea.Location;

            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir : Form, new() 
        {
            Form Formualrios;

            pnlContenedor.Controls.Clear();

            Formualrios = pnlContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();

            if (Formualrios == null)
            {
                Formualrios = new FormularioAbrir
                {
                    TopLevel = false,
                    Dock = DockStyle.Fill
                };

                pnlContenedor.Controls.Add(Formualrios);
                pnlContenedor.Tag = Formualrios;

                Formualrios.Show();
                Formualrios.BringToFront();
            }
            else {
                Formualrios.BringToFront();
            }

        }
    }
}
