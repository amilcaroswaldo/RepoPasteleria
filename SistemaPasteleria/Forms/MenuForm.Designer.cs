
namespace SistemaPasteleria.Forms
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRestaurar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaximizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMinimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlSlider = new System.Windows.Forms.Panel();
            this.btnShowVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShowRecetas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShowMateriales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnShowCatalogo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlSlider.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlContenedor);
            this.pnlPrincipal.Controls.Add(this.panel3);
            this.pnlPrincipal.Controls.Add(this.pnlSlider);
            this.pnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(1400, 700);
            this.pnlPrincipal.TabIndex = 0;
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.CadetBlue;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(300, 80);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1100, 620);
            this.pnlContenedor.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.btnRestaurar);
            this.panel3.Controls.Add(this.btnMaximizar);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1100, 80);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.ImageActive = null;
            this.btnRestaurar.Location = new System.Drawing.Point(927, 23);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(35, 35);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Zoom = 10;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.ImageActive = null;
            this.btnMaximizar.Location = new System.Drawing.Point(994, 23);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 35);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Zoom = 10;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.ImageActive = null;
            this.btnMinimizar.Location = new System.Drawing.Point(868, 23);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Zoom = 10;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(1053, 23);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlSlider
            // 
            this.pnlSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.pnlSlider.Controls.Add(this.btnShowVentas);
            this.pnlSlider.Controls.Add(this.btnShowRecetas);
            this.pnlSlider.Controls.Add(this.btnShowMateriales);
            this.pnlSlider.Controls.Add(this.btnShowCatalogo);
            this.pnlSlider.Controls.Add(this.bunifuSeparator1);
            this.pnlSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSlider.Location = new System.Drawing.Point(0, 0);
            this.pnlSlider.Name = "pnlSlider";
            this.pnlSlider.Size = new System.Drawing.Size(300, 700);
            this.pnlSlider.TabIndex = 0;
            // 
            // btnShowVentas
            // 
            this.btnShowVentas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowVentas.BorderRadius = 7;
            this.btnShowVentas.ButtonText = "Ventas";
            this.btnShowVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowVentas.Iconimage")));
            this.btnShowVentas.Iconimage_right = null;
            this.btnShowVentas.Iconimage_right_Selected = null;
            this.btnShowVentas.Iconimage_Selected = null;
            this.btnShowVentas.IconMarginLeft = 0;
            this.btnShowVentas.IconMarginRight = 0;
            this.btnShowVentas.IconRightVisible = true;
            this.btnShowVentas.IconRightZoom = 0D;
            this.btnShowVentas.IconVisible = true;
            this.btnShowVentas.IconZoom = 90D;
            this.btnShowVentas.IsTab = false;
            this.btnShowVentas.Location = new System.Drawing.Point(2, 321);
            this.btnShowVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowVentas.Name = "btnShowVentas";
            this.btnShowVentas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowVentas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowVentas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowVentas.selected = false;
            this.btnShowVentas.Size = new System.Drawing.Size(296, 59);
            this.btnShowVentas.TabIndex = 5;
            this.btnShowVentas.Text = "Ventas";
            this.btnShowVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowVentas.Textcolor = System.Drawing.Color.White;
            this.btnShowVentas.TextFont = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowVentas.Click += new System.EventHandler(this.btnShowVentas_Click);
            // 
            // btnShowRecetas
            // 
            this.btnShowRecetas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowRecetas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowRecetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowRecetas.BorderRadius = 7;
            this.btnShowRecetas.ButtonText = "Recetas";
            this.btnShowRecetas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowRecetas.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowRecetas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowRecetas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowRecetas.Iconimage")));
            this.btnShowRecetas.Iconimage_right = null;
            this.btnShowRecetas.Iconimage_right_Selected = null;
            this.btnShowRecetas.Iconimage_Selected = null;
            this.btnShowRecetas.IconMarginLeft = 0;
            this.btnShowRecetas.IconMarginRight = 0;
            this.btnShowRecetas.IconRightVisible = true;
            this.btnShowRecetas.IconRightZoom = 0D;
            this.btnShowRecetas.IconVisible = true;
            this.btnShowRecetas.IconZoom = 90D;
            this.btnShowRecetas.IsTab = false;
            this.btnShowRecetas.Location = new System.Drawing.Point(0, 261);
            this.btnShowRecetas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowRecetas.Name = "btnShowRecetas";
            this.btnShowRecetas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowRecetas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowRecetas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowRecetas.selected = false;
            this.btnShowRecetas.Size = new System.Drawing.Size(296, 59);
            this.btnShowRecetas.TabIndex = 4;
            this.btnShowRecetas.Text = "Recetas";
            this.btnShowRecetas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowRecetas.Textcolor = System.Drawing.Color.White;
            this.btnShowRecetas.TextFont = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRecetas.Click += new System.EventHandler(this.btnShowRecetas_Click);
            // 
            // btnShowMateriales
            // 
            this.btnShowMateriales.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowMateriales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowMateriales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowMateriales.BorderRadius = 7;
            this.btnShowMateriales.ButtonText = "Materiales";
            this.btnShowMateriales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowMateriales.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowMateriales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowMateriales.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowMateriales.Iconimage")));
            this.btnShowMateriales.Iconimage_right = null;
            this.btnShowMateriales.Iconimage_right_Selected = null;
            this.btnShowMateriales.Iconimage_Selected = null;
            this.btnShowMateriales.IconMarginLeft = 0;
            this.btnShowMateriales.IconMarginRight = 0;
            this.btnShowMateriales.IconRightVisible = true;
            this.btnShowMateriales.IconRightZoom = 0D;
            this.btnShowMateriales.IconVisible = true;
            this.btnShowMateriales.IconZoom = 90D;
            this.btnShowMateriales.IsTab = false;
            this.btnShowMateriales.Location = new System.Drawing.Point(0, 177);
            this.btnShowMateriales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowMateriales.Name = "btnShowMateriales";
            this.btnShowMateriales.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowMateriales.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowMateriales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowMateriales.selected = false;
            this.btnShowMateriales.Size = new System.Drawing.Size(296, 59);
            this.btnShowMateriales.TabIndex = 3;
            this.btnShowMateriales.Text = "Materiales";
            this.btnShowMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowMateriales.Textcolor = System.Drawing.Color.White;
            this.btnShowMateriales.TextFont = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMateriales.Click += new System.EventHandler(this.btnShowMateriales_Click);
            // 
            // btnShowCatalogo
            // 
            this.btnShowCatalogo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowCatalogo.BorderRadius = 7;
            this.btnShowCatalogo.ButtonText = "Catálogo de Materiales";
            this.btnShowCatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowCatalogo.DisabledColor = System.Drawing.Color.Gray;
            this.btnShowCatalogo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnShowCatalogo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnShowCatalogo.Iconimage")));
            this.btnShowCatalogo.Iconimage_right = null;
            this.btnShowCatalogo.Iconimage_right_Selected = null;
            this.btnShowCatalogo.Iconimage_Selected = null;
            this.btnShowCatalogo.IconMarginLeft = 0;
            this.btnShowCatalogo.IconMarginRight = 0;
            this.btnShowCatalogo.IconRightVisible = true;
            this.btnShowCatalogo.IconRightZoom = 0D;
            this.btnShowCatalogo.IconVisible = true;
            this.btnShowCatalogo.IconZoom = 90D;
            this.btnShowCatalogo.IsTab = false;
            this.btnShowCatalogo.Location = new System.Drawing.Point(0, 96);
            this.btnShowCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowCatalogo.Name = "btnShowCatalogo";
            this.btnShowCatalogo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btnShowCatalogo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnShowCatalogo.OnHoverTextColor = System.Drawing.Color.White;
            this.btnShowCatalogo.selected = false;
            this.btnShowCatalogo.Size = new System.Drawing.Size(296, 59);
            this.btnShowCatalogo.TabIndex = 2;
            this.btnShowCatalogo.Text = "Catálogo de Materiales";
            this.btnShowCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCatalogo.Textcolor = System.Drawing.Color.White;
            this.btnShowCatalogo.TextFont = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCatalogo.Click += new System.EventHandler(this.btnShowCatalogo_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(4, 61);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(289, 43);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel3;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.pnlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1400, 600);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.pnlPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlSlider.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlSlider;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnRestaurar;
        private Bunifu.Framework.UI.BunifuImageButton btnMaximizar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimizar;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowCatalogo;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowMateriales;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnShowRecetas;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}