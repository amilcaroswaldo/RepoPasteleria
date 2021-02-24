namespace SistemaPasteleria.Forms
{
    partial class Catalogo
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
            this.txtIdCatalogo = new System.Windows.Forms.TextBox();
            this.bindingSourceCatalogo = new System.Windows.Forms.BindingSource(this.components);
            this.txtCatalogo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.idMaterialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCatalogoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioGramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDisponibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceMaterial = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCatalogo
            // 
            this.txtIdCatalogo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCatalogo, "IdCatalogo", true));
            this.txtIdCatalogo.Location = new System.Drawing.Point(20, 2);
            this.txtIdCatalogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCatalogo.Name = "txtIdCatalogo";
            this.txtIdCatalogo.Size = new System.Drawing.Size(58, 20);
            this.txtIdCatalogo.TabIndex = 1;
            this.txtIdCatalogo.Text = "idCatalogo";
            // 
            // bindingSourceCatalogo
            // 
            this.bindingSourceCatalogo.DataSource = typeof(SistemaPasteleria.Models.Catalogo);
            // 
            // txtCatalogo
            // 
            this.txtCatalogo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceCatalogo, "Nombre", true));
            this.txtCatalogo.Location = new System.Drawing.Point(208, 2);
            this.txtCatalogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCatalogo.Name = "txtCatalogo";
            this.txtCatalogo.Size = new System.Drawing.Size(144, 20);
            this.txtCatalogo.TabIndex = 2;
            this.txtCatalogo.Text = "Nombre receta";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "IdMaterial", true));
            this.textBox1.Location = new System.Drawing.Point(376, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "idMaterial";
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataSource = typeof(SistemaPasteleria.Models.Material);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "IdCatalogo", true));
            this.textBox3.Location = new System.Drawing.Point(20, 38);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(66, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "idCatalogo";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CantidadInicial", true));
            this.textBox4.Location = new System.Drawing.Point(226, 25);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Cantidad inicial";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "Precio", true));
            this.textBox5.Location = new System.Drawing.Point(367, 25);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Precio";
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "PrecioGramo", true));
            this.textBox6.Location = new System.Drawing.Point(20, 61);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 20);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Precio Grama";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialBindingSource, "CantidadDisponible", true));
            this.textBox7.Location = new System.Drawing.Point(226, 61);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(76, 20);
            this.textBox7.TabIndex = 9;
            this.textBox7.Text = "Cantidad disponible";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 112);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 22);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Receta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvReceta
            // 
            this.dgvReceta.AutoGenerateColumns = false;
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMaterialDataGridViewTextBoxColumn,
            this.idCatalogoDataGridViewTextBoxColumn,
            this.cantidadInicialDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.precioGramoDataGridViewTextBoxColumn,
            this.cantidadDisponibleDataGridViewTextBoxColumn});
            this.dgvReceta.DataSource = this.materialBindingSource;
            this.dgvReceta.Location = new System.Drawing.Point(9, 251);
            this.dgvReceta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.RowTemplate.Height = 24;
            this.dgvReceta.Size = new System.Drawing.Size(602, 122);
            this.dgvReceta.TabIndex = 11;
            // 
            // idMaterialDataGridViewTextBoxColumn
            // 
            this.idMaterialDataGridViewTextBoxColumn.DataPropertyName = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.HeaderText = "IdMaterial";
            this.idMaterialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idMaterialDataGridViewTextBoxColumn.Name = "idMaterialDataGridViewTextBoxColumn";
            this.idMaterialDataGridViewTextBoxColumn.Width = 125;
            // 
            // idCatalogoDataGridViewTextBoxColumn
            // 
            this.idCatalogoDataGridViewTextBoxColumn.DataPropertyName = "IdCatalogo";
            this.idCatalogoDataGridViewTextBoxColumn.HeaderText = "IdCatalogo";
            this.idCatalogoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idCatalogoDataGridViewTextBoxColumn.Name = "idCatalogoDataGridViewTextBoxColumn";
            this.idCatalogoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadInicialDataGridViewTextBoxColumn
            // 
            this.cantidadInicialDataGridViewTextBoxColumn.DataPropertyName = "CantidadInicial";
            this.cantidadInicialDataGridViewTextBoxColumn.HeaderText = "CantidadInicial";
            this.cantidadInicialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadInicialDataGridViewTextBoxColumn.Name = "cantidadInicialDataGridViewTextBoxColumn";
            this.cantidadInicialDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.Width = 125;
            // 
            // precioGramoDataGridViewTextBoxColumn
            // 
            this.precioGramoDataGridViewTextBoxColumn.DataPropertyName = "PrecioGramo";
            this.precioGramoDataGridViewTextBoxColumn.HeaderText = "PrecioGramo";
            this.precioGramoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.precioGramoDataGridViewTextBoxColumn.Name = "precioGramoDataGridViewTextBoxColumn";
            this.precioGramoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cantidadDisponibleDataGridViewTextBoxColumn
            // 
            this.cantidadDisponibleDataGridViewTextBoxColumn.DataPropertyName = "CantidadDisponible";
            this.cantidadDisponibleDataGridViewTextBoxColumn.HeaderText = "CantidadDisponible";
            this.cantidadDisponibleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cantidadDisponibleDataGridViewTextBoxColumn.Name = "cantidadDisponibleDataGridViewTextBoxColumn";
            this.cantidadDisponibleDataGridViewTextBoxColumn.Width = 125;
            // 
            // bindingSourceMaterial
            // 
            this.bindingSourceMaterial.DataSource = typeof(SistemaPasteleria.Models.Material);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 392);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtCatalogo);
            this.Controls.Add(this.txtIdCatalogo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceCatalogo;
        private System.Windows.Forms.BindingSource bindingSourceMaterial;
        private System.Windows.Forms.TextBox txtIdCatalogo;
        private System.Windows.Forms.TextBox txtCatalogo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCatalogoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioGramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDisponibleDataGridViewTextBoxColumn;
    }
}