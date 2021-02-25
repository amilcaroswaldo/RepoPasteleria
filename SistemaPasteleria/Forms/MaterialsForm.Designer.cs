
namespace SistemaPasteleria.Forms
{
    partial class MaterialsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioGramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDisponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cbCatalogo = new MetroFramework.Controls.MetroComboBox();
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCantidadDisponible = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioGramo = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtCantidadInicial = new MetroFramework.Controls.MetroTextBox();
            this.txtIdMaterial = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialDataGridViewTextBoxColumn,
            this.catalogoDataGridViewTextBoxColumn,
            this.cantidadInicialDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.precioGramoDataGridViewTextBoxColumn,
            this.cantidadDisponibleDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.materialBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(38, 448);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1062, 252);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellClick);
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // catalogoDataGridViewTextBoxColumn
            // 
            this.catalogoDataGridViewTextBoxColumn.DataPropertyName = "Catalogo";
            this.catalogoDataGridViewTextBoxColumn.HeaderText = "Catalogo";
            this.catalogoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.catalogoDataGridViewTextBoxColumn.Name = "catalogoDataGridViewTextBoxColumn";
            this.catalogoDataGridViewTextBoxColumn.ReadOnly = true;
            this.catalogoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadInicialDataGridViewTextBoxColumn
            // 
            this.cantidadInicialDataGridViewTextBoxColumn.DataPropertyName = "CantidadInicial";
            this.cantidadInicialDataGridViewTextBoxColumn.HeaderText = "CantidadInicial";
            this.cantidadInicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadInicialDataGridViewTextBoxColumn.Name = "cantidadInicialDataGridViewTextBoxColumn";
            this.cantidadInicialDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadInicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioGramoDataGridViewTextBoxColumn
            // 
            this.precioGramoDataGridViewTextBoxColumn.DataPropertyName = "PrecioGramo";
            this.precioGramoDataGridViewTextBoxColumn.HeaderText = "PrecioGramo";
            this.precioGramoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioGramoDataGridViewTextBoxColumn.Name = "precioGramoDataGridViewTextBoxColumn";
            this.precioGramoDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioGramoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDisponibleDataGridViewTextBoxColumn
            // 
            this.cantidadDisponibleDataGridViewTextBoxColumn.DataPropertyName = "CantidadDisponible";
            this.cantidadDisponibleDataGridViewTextBoxColumn.HeaderText = "CantidadDisponible";
            this.cantidadDisponibleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDisponibleDataGridViewTextBoxColumn.Name = "cantidadDisponibleDataGridViewTextBoxColumn";
            this.cantidadDisponibleDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDisponibleDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(SistemaPasteleria.Models.Material);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.cbCatalogo);
            this.metroPanel1.Controls.Add(this.txtCantidadDisponible);
            this.metroPanel1.Controls.Add(this.txtPrecioGramo);
            this.metroPanel1.Controls.Add(this.txtPrecio);
            this.metroPanel1.Controls.Add(this.txtCantidadInicial);
            this.metroPanel1.Controls.Add(this.txtIdMaterial);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(38, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(930, 293);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Catalogo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Costo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(191, 232);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(169, 23);
            this.metroButton1.TabIndex = 8;
            this.metroButton1.Text = "Agregar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cbCatalogo
            // 
            this.cbCatalogo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.materialBindingSource, "Catalogo", true));
            this.cbCatalogo.DataSource = this.catalogoBindingSource;
            this.cbCatalogo.DisplayMember = "Nombre";
            this.cbCatalogo.FormattingEnabled = true;
            this.cbCatalogo.ItemHeight = 24;
            this.cbCatalogo.Location = new System.Drawing.Point(191, 158);
            this.cbCatalogo.Name = "cbCatalogo";
            this.cbCatalogo.Size = new System.Drawing.Size(184, 30);
            this.cbCatalogo.TabIndex = 7;
            this.cbCatalogo.UseSelectable = true;
            this.cbCatalogo.ValueMember = "IdCatalogo";
            this.cbCatalogo.SelectedIndexChanged += new System.EventHandler(this.cbCatalogo_SelectedIndexChanged);
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataSource = typeof(SistemaPasteleria.Models.Catalogo);
            // 
            // txtCantidadDisponible
            // 
            // 
            // 
            // 
            this.txtCantidadDisponible.CustomButton.Image = null;
            this.txtCantidadDisponible.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCantidadDisponible.CustomButton.Name = "";
            this.txtCantidadDisponible.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidadDisponible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadDisponible.CustomButton.TabIndex = 1;
            this.txtCantidadDisponible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadDisponible.CustomButton.UseSelectable = true;
            this.txtCantidadDisponible.CustomButton.Visible = false;
            this.txtCantidadDisponible.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CantidadDisponible", true));
            this.txtCantidadDisponible.Lines = new string[0];
            this.txtCantidadDisponible.Location = new System.Drawing.Point(534, 158);
            this.txtCantidadDisponible.MaxLength = 32767;
            this.txtCantidadDisponible.Name = "txtCantidadDisponible";
            this.txtCantidadDisponible.PasswordChar = '\0';
            this.txtCantidadDisponible.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadDisponible.SelectedText = "";
            this.txtCantidadDisponible.SelectionLength = 0;
            this.txtCantidadDisponible.SelectionStart = 0;
            this.txtCantidadDisponible.ShortcutsEnabled = true;
            this.txtCantidadDisponible.Size = new System.Drawing.Size(184, 23);
            this.txtCantidadDisponible.TabIndex = 6;
            this.txtCantidadDisponible.UseSelectable = true;
            this.txtCantidadDisponible.Visible = false;
            this.txtCantidadDisponible.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadDisponible.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadDisponible.Click += new System.EventHandler(this.txtCantidadDisponible_Click);
            // 
            // txtPrecioGramo
            // 
            // 
            // 
            // 
            this.txtPrecioGramo.CustomButton.Image = null;
            this.txtPrecioGramo.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtPrecioGramo.CustomButton.Name = "";
            this.txtPrecioGramo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioGramo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioGramo.CustomButton.TabIndex = 1;
            this.txtPrecioGramo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioGramo.CustomButton.UseSelectable = true;
            this.txtPrecioGramo.CustomButton.Visible = false;
            this.txtPrecioGramo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "PrecioGramo", true));
            this.txtPrecioGramo.Lines = new string[0];
            this.txtPrecioGramo.Location = new System.Drawing.Point(534, 112);
            this.txtPrecioGramo.MaxLength = 32767;
            this.txtPrecioGramo.Name = "txtPrecioGramo";
            this.txtPrecioGramo.PasswordChar = '\0';
            this.txtPrecioGramo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioGramo.SelectedText = "";
            this.txtPrecioGramo.SelectionLength = 0;
            this.txtPrecioGramo.SelectionStart = 0;
            this.txtPrecioGramo.ShortcutsEnabled = true;
            this.txtPrecioGramo.Size = new System.Drawing.Size(184, 23);
            this.txtPrecioGramo.TabIndex = 5;
            this.txtPrecioGramo.UseSelectable = true;
            this.txtPrecioGramo.Visible = false;
            this.txtPrecioGramo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioGramo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioGramo.Click += new System.EventHandler(this.txtPrecioGramo_Click);
            // 
            // txtPrecio
            // 
            // 
            // 
            // 
            this.txtPrecio.CustomButton.Image = null;
            this.txtPrecio.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtPrecio.CustomButton.Name = "";
            this.txtPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecio.CustomButton.TabIndex = 1;
            this.txtPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecio.CustomButton.UseSelectable = true;
            this.txtPrecio.CustomButton.Visible = false;
            this.txtPrecio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Precio", true));
            this.txtPrecio.Lines = new string[0];
            this.txtPrecio.Location = new System.Drawing.Point(191, 106);
            this.txtPrecio.MaxLength = 32767;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.PasswordChar = '\0';
            this.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecio.SelectedText = "";
            this.txtPrecio.SelectionLength = 0;
            this.txtPrecio.SelectionStart = 0;
            this.txtPrecio.ShortcutsEnabled = true;
            this.txtPrecio.Size = new System.Drawing.Size(184, 23);
            this.txtPrecio.TabIndex = 4;
            this.txtPrecio.UseSelectable = true;
            this.txtPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecio.Click += new System.EventHandler(this.txtPrecio_Click);
            // 
            // txtCantidadInicial
            // 
            // 
            // 
            // 
            this.txtCantidadInicial.CustomButton.Image = null;
            this.txtCantidadInicial.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCantidadInicial.CustomButton.Name = "";
            this.txtCantidadInicial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidadInicial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadInicial.CustomButton.TabIndex = 1;
            this.txtCantidadInicial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadInicial.CustomButton.UseSelectable = true;
            this.txtCantidadInicial.CustomButton.Visible = false;
            this.txtCantidadInicial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CantidadInicial", true));
            this.txtCantidadInicial.Lines = new string[0];
            this.txtCantidadInicial.Location = new System.Drawing.Point(191, 61);
            this.txtCantidadInicial.MaxLength = 32767;
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.PasswordChar = '\0';
            this.txtCantidadInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadInicial.SelectedText = "";
            this.txtCantidadInicial.SelectionLength = 0;
            this.txtCantidadInicial.SelectionStart = 0;
            this.txtCantidadInicial.ShortcutsEnabled = true;
            this.txtCantidadInicial.Size = new System.Drawing.Size(184, 23);
            this.txtCantidadInicial.TabIndex = 3;
            this.txtCantidadInicial.UseSelectable = true;
            this.txtCantidadInicial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadInicial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadInicial.Click += new System.EventHandler(this.txtCantidadInicial_Click);
            // 
            // txtIdMaterial
            // 
            // 
            // 
            // 
            this.txtIdMaterial.CustomButton.Image = null;
            this.txtIdMaterial.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtIdMaterial.CustomButton.Name = "";
            this.txtIdMaterial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIdMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdMaterial.CustomButton.TabIndex = 1;
            this.txtIdMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdMaterial.CustomButton.UseSelectable = true;
            this.txtIdMaterial.CustomButton.Visible = false;
            this.txtIdMaterial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "IdMaterial", true));
            this.txtIdMaterial.Lines = new string[0];
            this.txtIdMaterial.Location = new System.Drawing.Point(534, 67);
            this.txtIdMaterial.MaxLength = 32767;
            this.txtIdMaterial.Name = "txtIdMaterial";
            this.txtIdMaterial.PasswordChar = '\0';
            this.txtIdMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdMaterial.SelectedText = "";
            this.txtIdMaterial.SelectionLength = 0;
            this.txtIdMaterial.SelectionStart = 0;
            this.txtIdMaterial.ShortcutsEnabled = true;
            this.txtIdMaterial.Size = new System.Drawing.Size(184, 23);
            this.txtIdMaterial.TabIndex = 2;
            this.txtIdMaterial.UseSelectable = true;
            this.txtIdMaterial.Visible = false;
            this.txtIdMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdMaterial.Click += new System.EventHandler(this.txtIdMaterial_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(151, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(38, 387);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(334, 29);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "Materiales en inventario";
            this.htmlLabel1.Click += new System.EventHandler(this.htmlLabel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(569, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(636, 412);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(168, 22);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // MaterialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 723);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGrid1);
            this.Name = "MaterialsForm";
            this.Text = "MaterialsForm";
            this.Load += new System.EventHandler(this.MaterialsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox cbCatalogo;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private MetroFramework.Controls.MetroTextBox txtCantidadDisponible;
        private MetroFramework.Controls.MetroTextBox txtPrecioGramo;
        private MetroFramework.Controls.MetroTextBox txtPrecio;
        private MetroFramework.Controls.MetroTextBox txtCantidadInicial;
        private MetroFramework.Controls.MetroTextBox txtIdMaterial;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioGramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDisponibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}