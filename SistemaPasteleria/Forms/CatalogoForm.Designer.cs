
namespace SistemaPasteleria.Forms
{
    partial class CatalogoForm
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
            this.dgDatos = new MetroFramework.Controls.MetroGrid();
            this.idCatalogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioGramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.htmlLabel8 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtPrecioTotal = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel6 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtPrecioGr = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.catalogoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.htmlLabel7 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtCantidadDisp = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel5 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtCantidadInicial = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel4 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtidMaterial = new MetroFramework.Controls.MetroTextBox();
            this.txtidCatalogo = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.btnAgregar = new MetroFramework.Controls.MetroButton();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.txtBuscador = new MetroFramework.Controls.MetroTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.AutoGenerateColumns = false;
            this.dgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCatalogoDataGridViewTextBoxColumn,
            this.Catalogo,
            this.CantidadInicial,
            this.CantidadDisponible,
            this.PrecioGramo,
            this.Precio});
            this.dgDatos.DataSource = this.materialBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDatos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgDatos.EnableHeadersVisualStyles = false;
            this.dgDatos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgDatos.Location = new System.Drawing.Point(43, 441);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            this.dgDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDatos.RowHeadersWidth = 51;
            this.dgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDatos.RowTemplate.Height = 24;
            this.dgDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDatos.Size = new System.Drawing.Size(843, 244);
            this.dgDatos.TabIndex = 0;
            this.dgDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellClick);
            // 
            // idCatalogoDataGridViewTextBoxColumn
            // 
            this.idCatalogoDataGridViewTextBoxColumn.DataPropertyName = "IdCatalogo";
            this.idCatalogoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idCatalogoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCatalogoDataGridViewTextBoxColumn.Name = "idCatalogoDataGridViewTextBoxColumn";
            this.idCatalogoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCatalogoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Catalogo
            // 
            this.Catalogo.DataPropertyName = "Catalogo";
            this.Catalogo.HeaderText = "Nombre";
            this.Catalogo.MinimumWidth = 6;
            this.Catalogo.Name = "Catalogo";
            this.Catalogo.ReadOnly = true;
            this.Catalogo.Width = 125;
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.DataPropertyName = "CantidadInicial";
            this.CantidadInicial.HeaderText = "CantidadI nicial";
            this.CantidadInicial.MinimumWidth = 6;
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.ReadOnly = true;
            this.CantidadInicial.Width = 125;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.DataPropertyName = "CantidadDisponible";
            this.CantidadDisponible.HeaderText = "Cantidad Disponible";
            this.CantidadDisponible.MinimumWidth = 6;
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.ReadOnly = true;
            this.CantidadDisponible.Width = 125;
            // 
            // PrecioGramo
            // 
            this.PrecioGramo.DataPropertyName = "PrecioGramo";
            this.PrecioGramo.HeaderText = "Precio Gramo";
            this.PrecioGramo.MinimumWidth = 6;
            this.PrecioGramo.Name = "PrecioGramo";
            this.PrecioGramo.ReadOnly = true;
            this.PrecioGramo.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio Total";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(SistemaPasteleria.Models.Material);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.htmlLabel8);
            this.metroPanel1.Controls.Add(this.txtPrecioTotal);
            this.metroPanel1.Controls.Add(this.htmlLabel6);
            this.metroPanel1.Controls.Add(this.txtPrecioGr);
            this.metroPanel1.Controls.Add(this.txtId);
            this.metroPanel1.Controls.Add(this.htmlLabel7);
            this.metroPanel1.Controls.Add(this.txtCantidadDisp);
            this.metroPanel1.Controls.Add(this.htmlLabel5);
            this.metroPanel1.Controls.Add(this.txtCantidadInicial);
            this.metroPanel1.Controls.Add(this.htmlLabel4);
            this.metroPanel1.Controls.Add(this.htmlLabel3);
            this.metroPanel1.Controls.Add(this.txtidMaterial);
            this.metroPanel1.Controls.Add(this.txtidCatalogo);
            this.metroPanel1.Controls.Add(this.btnCancel);
            this.metroPanel1.Controls.Add(this.btnUpdate);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.Controls.Add(this.txtNombre);
            this.metroPanel1.Controls.Add(this.btnAgregar);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(43, 64);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(894, 315);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // htmlLabel8
            // 
            this.htmlLabel8.AutoScroll = true;
            this.htmlLabel8.AutoScrollMinSize = new System.Drawing.Size(86, 25);
            this.htmlLabel8.AutoSize = false;
            this.htmlLabel8.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel8.Location = new System.Drawing.Point(17, 197);
            this.htmlLabel8.Name = "htmlLabel8";
            this.htmlLabel8.Size = new System.Drawing.Size(157, 37);
            this.htmlLabel8.TabIndex = 19;
            this.htmlLabel8.Text = "Precio total: ";
            // 
            // txtPrecioTotal
            // 
            // 
            // 
            // 
            this.txtPrecioTotal.CustomButton.Image = null;
            this.txtPrecioTotal.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtPrecioTotal.CustomButton.Name = "";
            this.txtPrecioTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioTotal.CustomButton.TabIndex = 1;
            this.txtPrecioTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioTotal.CustomButton.UseSelectable = true;
            this.txtPrecioTotal.CustomButton.Visible = false;
            this.txtPrecioTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Precio", true));
            this.txtPrecioTotal.Lines = new string[0];
            this.txtPrecioTotal.Location = new System.Drawing.Point(217, 193);
            this.txtPrecioTotal.MaxLength = 32767;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.PasswordChar = '\0';
            this.txtPrecioTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioTotal.SelectedText = "";
            this.txtPrecioTotal.SelectionLength = 0;
            this.txtPrecioTotal.SelectionStart = 0;
            this.txtPrecioTotal.ShortcutsEnabled = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(208, 23);
            this.txtPrecioTotal.TabIndex = 18;
            this.txtPrecioTotal.UseSelectable = true;
            this.txtPrecioTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel6
            // 
            this.htmlLabel6.AutoScroll = true;
            this.htmlLabel6.AutoScrollMinSize = new System.Drawing.Size(100, 25);
            this.htmlLabel6.AutoSize = false;
            this.htmlLabel6.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel6.Location = new System.Drawing.Point(497, 154);
            this.htmlLabel6.Name = "htmlLabel6";
            this.htmlLabel6.Size = new System.Drawing.Size(136, 37);
            this.htmlLabel6.TabIndex = 17;
            this.htmlLabel6.Text = "Precio Gramo: ";
            // 
            // txtPrecioGr
            // 
            // 
            // 
            // 
            this.txtPrecioGr.CustomButton.Image = null;
            this.txtPrecioGr.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtPrecioGr.CustomButton.Name = "";
            this.txtPrecioGr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioGr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioGr.CustomButton.TabIndex = 1;
            this.txtPrecioGr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioGr.CustomButton.UseSelectable = true;
            this.txtPrecioGr.CustomButton.Visible = false;
            this.txtPrecioGr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "PrecioGramo", true));
            this.txtPrecioGr.Lines = new string[0];
            this.txtPrecioGr.Location = new System.Drawing.Point(660, 154);
            this.txtPrecioGr.MaxLength = 32767;
            this.txtPrecioGr.Name = "txtPrecioGr";
            this.txtPrecioGr.PasswordChar = '\0';
            this.txtPrecioGr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioGr.SelectedText = "";
            this.txtPrecioGr.SelectionLength = 0;
            this.txtPrecioGr.SelectionStart = 0;
            this.txtPrecioGr.ShortcutsEnabled = true;
            this.txtPrecioGr.Size = new System.Drawing.Size(208, 23);
            this.txtPrecioGr.TabIndex = 16;
            this.txtPrecioGr.UseSelectable = true;
            this.txtPrecioGr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioGr.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catalogoBindingSource, "IdCatalogo", true));
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(216, 13);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(208, 23);
            this.txtId.TabIndex = 7;
            this.txtId.UseSelectable = true;
            this.txtId.Visible = false;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // catalogoBindingSource
            // 
            this.catalogoBindingSource.DataSource = typeof(SistemaPasteleria.Models.Catalogo);
            // 
            // htmlLabel7
            // 
            this.htmlLabel7.AutoScroll = true;
            this.htmlLabel7.AutoScrollMinSize = new System.Drawing.Size(129, 25);
            this.htmlLabel7.AutoSize = false;
            this.htmlLabel7.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel7.Location = new System.Drawing.Point(15, 154);
            this.htmlLabel7.Name = "htmlLabel7";
            this.htmlLabel7.Size = new System.Drawing.Size(187, 37);
            this.htmlLabel7.TabIndex = 15;
            this.htmlLabel7.Text = "Cantidad disponible:";
            // 
            // txtCantidadDisp
            // 
            // 
            // 
            // 
            this.txtCantidadDisp.CustomButton.Image = null;
            this.txtCantidadDisp.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtCantidadDisp.CustomButton.Name = "";
            this.txtCantidadDisp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidadDisp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadDisp.CustomButton.TabIndex = 1;
            this.txtCantidadDisp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadDisp.CustomButton.UseSelectable = true;
            this.txtCantidadDisp.CustomButton.Visible = false;
            this.txtCantidadDisp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CantidadDisponible", true));
            this.txtCantidadDisp.Lines = new string[0];
            this.txtCantidadDisp.Location = new System.Drawing.Point(215, 150);
            this.txtCantidadDisp.MaxLength = 32767;
            this.txtCantidadDisp.Name = "txtCantidadDisp";
            this.txtCantidadDisp.PasswordChar = '\0';
            this.txtCantidadDisp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadDisp.SelectedText = "";
            this.txtCantidadDisp.SelectionLength = 0;
            this.txtCantidadDisp.SelectionStart = 0;
            this.txtCantidadDisp.ShortcutsEnabled = true;
            this.txtCantidadDisp.Size = new System.Drawing.Size(208, 23);
            this.txtCantidadDisp.TabIndex = 14;
            this.txtCantidadDisp.UseSelectable = true;
            this.txtCantidadDisp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadDisp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel5
            // 
            this.htmlLabel5.AutoScroll = true;
            this.htmlLabel5.AutoScrollMinSize = new System.Drawing.Size(105, 25);
            this.htmlLabel5.AutoSize = false;
            this.htmlLabel5.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel5.Location = new System.Drawing.Point(497, 104);
            this.htmlLabel5.Name = "htmlLabel5";
            this.htmlLabel5.Size = new System.Drawing.Size(152, 47);
            this.htmlLabel5.TabIndex = 13;
            this.htmlLabel5.Text = "Cantidad Inicial:";
            // 
            // txtCantidadInicial
            // 
            // 
            // 
            // 
            this.txtCantidadInicial.CustomButton.Image = null;
            this.txtCantidadInicial.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtCantidadInicial.CustomButton.Name = "";
            this.txtCantidadInicial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCantidadInicial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCantidadInicial.CustomButton.TabIndex = 1;
            this.txtCantidadInicial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCantidadInicial.CustomButton.UseSelectable = true;
            this.txtCantidadInicial.CustomButton.Visible = false;
            this.txtCantidadInicial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CantidadInicial", true));
            this.txtCantidadInicial.Lines = new string[0];
            this.txtCantidadInicial.Location = new System.Drawing.Point(660, 104);
            this.txtCantidadInicial.MaxLength = 32767;
            this.txtCantidadInicial.Name = "txtCantidadInicial";
            this.txtCantidadInicial.PasswordChar = '\0';
            this.txtCantidadInicial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCantidadInicial.SelectedText = "";
            this.txtCantidadInicial.SelectionLength = 0;
            this.txtCantidadInicial.SelectionStart = 0;
            this.txtCantidadInicial.ShortcutsEnabled = true;
            this.txtCantidadInicial.Size = new System.Drawing.Size(208, 23);
            this.txtCantidadInicial.TabIndex = 12;
            this.txtCantidadInicial.UseSelectable = true;
            this.txtCantidadInicial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCantidadInicial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // htmlLabel4
            // 
            this.htmlLabel4.AutoScroll = true;
            this.htmlLabel4.AutoScrollMinSize = new System.Drawing.Size(80, 25);
            this.htmlLabel4.AutoSize = false;
            this.htmlLabel4.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel4.Location = new System.Drawing.Point(497, 61);
            this.htmlLabel4.Name = "htmlLabel4";
            this.htmlLabel4.Size = new System.Drawing.Size(136, 37);
            this.htmlLabel4.TabIndex = 11;
            this.htmlLabel4.Text = "txtIdMateria";
            this.htmlLabel4.Visible = false;
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(81, 25);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel3.Location = new System.Drawing.Point(15, 104);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(157, 37);
            this.htmlLabel3.TabIndex = 9;
            this.htmlLabel3.Text = "IdCatalogo: ";
            this.htmlLabel3.Visible = false;
            // 
            // txtidMaterial
            // 
            // 
            // 
            // 
            this.txtidMaterial.CustomButton.Image = null;
            this.txtidMaterial.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtidMaterial.CustomButton.Name = "";
            this.txtidMaterial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtidMaterial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtidMaterial.CustomButton.TabIndex = 1;
            this.txtidMaterial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtidMaterial.CustomButton.UseSelectable = true;
            this.txtidMaterial.CustomButton.Visible = false;
            this.txtidMaterial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "IdMaterial", true));
            this.txtidMaterial.Lines = new string[0];
            this.txtidMaterial.Location = new System.Drawing.Point(660, 61);
            this.txtidMaterial.MaxLength = 32767;
            this.txtidMaterial.Name = "txtidMaterial";
            this.txtidMaterial.PasswordChar = '\0';
            this.txtidMaterial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtidMaterial.SelectedText = "";
            this.txtidMaterial.SelectionLength = 0;
            this.txtidMaterial.SelectionStart = 0;
            this.txtidMaterial.ShortcutsEnabled = true;
            this.txtidMaterial.Size = new System.Drawing.Size(208, 23);
            this.txtidMaterial.TabIndex = 10;
            this.txtidMaterial.UseSelectable = true;
            this.txtidMaterial.Visible = false;
            this.txtidMaterial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtidMaterial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtidCatalogo
            // 
            // 
            // 
            // 
            this.txtidCatalogo.CustomButton.Image = null;
            this.txtidCatalogo.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtidCatalogo.CustomButton.Name = "";
            this.txtidCatalogo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtidCatalogo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtidCatalogo.CustomButton.TabIndex = 1;
            this.txtidCatalogo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtidCatalogo.CustomButton.UseSelectable = true;
            this.txtidCatalogo.CustomButton.Visible = false;
            this.txtidCatalogo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "IdCatalogo", true));
            this.txtidCatalogo.Lines = new string[0];
            this.txtidCatalogo.Location = new System.Drawing.Point(216, 100);
            this.txtidCatalogo.MaxLength = 32767;
            this.txtidCatalogo.Name = "txtidCatalogo";
            this.txtidCatalogo.PasswordChar = '\0';
            this.txtidCatalogo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtidCatalogo.SelectedText = "";
            this.txtidCatalogo.SelectionLength = 0;
            this.txtidCatalogo.SelectionStart = 0;
            this.txtidCatalogo.ShortcutsEnabled = true;
            this.txtidCatalogo.Size = new System.Drawing.Size(208, 23);
            this.txtidCatalogo.TabIndex = 8;
            this.txtidCatalogo.UseSelectable = true;
            this.txtidCatalogo.Visible = false;
            this.txtidCatalogo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtidCatalogo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(255, 273);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(148, 273);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(64, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(15, 61);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(157, 37);
            this.htmlLabel1.TabIndex = 4;
            this.htmlLabel1.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Catalogo", true));
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(216, 57);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(208, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.Click += new System.EventHandler(this.txtNombre_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 273);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 27);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseSelectable = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(56, 25);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel2.Location = new System.Drawing.Point(748, 385);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(168, 33);
            this.htmlLabel2.TabIndex = 2;
            this.htmlLabel2.Text = "Buscar:";
            // 
            // txtBuscador
            // 
            // 
            // 
            // 
            this.txtBuscador.CustomButton.Image = null;
            this.txtBuscador.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtBuscador.CustomButton.Name = "";
            this.txtBuscador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBuscador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBuscador.CustomButton.TabIndex = 1;
            this.txtBuscador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBuscador.CustomButton.UseSelectable = true;
            this.txtBuscador.CustomButton.Visible = false;
            this.txtBuscador.Lines = new string[0];
            this.txtBuscador.Location = new System.Drawing.Point(748, 411);
            this.txtBuscador.MaxLength = 32767;
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.PasswordChar = '\0';
            this.txtBuscador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscador.SelectedText = "";
            this.txtBuscador.SelectionLength = 0;
            this.txtBuscador.SelectionStart = 0;
            this.txtBuscador.ShortcutsEnabled = true;
            this.txtBuscador.Size = new System.Drawing.Size(156, 23);
            this.txtBuscador.TabIndex = 3;
            this.txtBuscador.UseSelectable = true;
            this.txtBuscador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBuscador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Catalogo";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Catalogo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // CatalogoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 698);
            this.Controls.Add(this.txtBuscador);
            this.Controls.Add(this.htmlLabel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.dgDatos);
            this.Name = "CatalogoForm";
            this.Text = "CatalogoForm";
            this.Load += new System.EventHandler(this.CatalogoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid dgDatos;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroButton btnAgregar;
        private System.Windows.Forms.BindingSource catalogoBindingSource;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Controls.MetroTextBox txtBuscador;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel6;
        private MetroFramework.Controls.MetroTextBox txtPrecioGr;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel7;
        private MetroFramework.Controls.MetroTextBox txtCantidadDisp;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel5;
        private MetroFramework.Controls.MetroTextBox txtCantidadInicial;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel4;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroTextBox txtidMaterial;
        private MetroFramework.Controls.MetroTextBox txtidCatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCatalogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioGramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel8;
        private MetroFramework.Controls.MetroTextBox txtPrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}