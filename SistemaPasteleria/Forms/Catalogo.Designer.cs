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
            this.txtIdCatalogo = new System.Windows.Forms.TextBox();
            this.txtCatalogo = new System.Windows.Forms.TextBox();
            this.txtIdMateria = new System.Windows.Forms.TextBox();
            this.txtcantInicial = new System.Windows.Forms.TextBox();
            this.txtIdCata2 = new System.Windows.Forms.TextBox();
            this.txtPrecioFin = new System.Windows.Forms.TextBox();
            this.txtprecioGr = new System.Windows.Forms.TextBox();
            this.txtCantFIn = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvReceta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIdCatalogo
            // 
            this.txtIdCatalogo.Location = new System.Drawing.Point(51, 8);
            this.txtIdCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCatalogo.Name = "txtIdCatalogo";
            this.txtIdCatalogo.Size = new System.Drawing.Size(76, 22);
            this.txtIdCatalogo.TabIndex = 1;
            this.txtIdCatalogo.TextChanged += new System.EventHandler(this.txtIdCatalogo_TextChanged);
            // 
            // txtCatalogo
            // 
            this.txtCatalogo.Location = new System.Drawing.Point(270, 8);
            this.txtCatalogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatalogo.Name = "txtCatalogo";
            this.txtCatalogo.Size = new System.Drawing.Size(191, 22);
            this.txtCatalogo.TabIndex = 2;
            // 
            // txtIdMateria
            // 
            this.txtIdMateria.Location = new System.Drawing.Point(92, 45);
            this.txtIdMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdMateria.Name = "txtIdMateria";
            this.txtIdMateria.Size = new System.Drawing.Size(87, 22);
            this.txtIdMateria.TabIndex = 4;
            // 
            // txtcantInicial
            // 
            this.txtcantInicial.Location = new System.Drawing.Point(101, 84);
            this.txtcantInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantInicial.Name = "txtcantInicial";
            this.txtcantInicial.Size = new System.Drawing.Size(87, 22);
            this.txtcantInicial.TabIndex = 5;
            // 
            // txtIdCata2
            // 
            this.txtIdCata2.Location = new System.Drawing.Point(301, 45);
            this.txtIdCata2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdCata2.Name = "txtIdCata2";
            this.txtIdCata2.Size = new System.Drawing.Size(100, 22);
            this.txtIdCata2.TabIndex = 6;
            // 
            // txtPrecioFin
            // 
            this.txtPrecioFin.Location = new System.Drawing.Point(301, 115);
            this.txtPrecioFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecioFin.Name = "txtPrecioFin";
            this.txtPrecioFin.Size = new System.Drawing.Size(100, 22);
            this.txtPrecioFin.TabIndex = 7;
            // 
            // txtprecioGr
            // 
            this.txtprecioGr.Location = new System.Drawing.Point(101, 110);
            this.txtprecioGr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprecioGr.Name = "txtprecioGr";
            this.txtprecioGr.Size = new System.Drawing.Size(100, 22);
            this.txtprecioGr.TabIndex = 8;
            this.txtprecioGr.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtCantFIn
            // 
            this.txtCantFIn.Location = new System.Drawing.Point(301, 87);
            this.txtCantFIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantFIn.Name = "txtCantFIn";
            this.txtCantFIn.Size = new System.Drawing.Size(100, 22);
            this.txtCantFIn.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 170);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 27);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar Receta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvReceta
            // 
            this.dgvReceta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_catalogo,
            this.ID_Material,
            this.CantidadInicial,
            this.CantidadDisponible});
            this.dgvReceta.Location = new System.Drawing.Point(12, 218);
            this.dgvReceta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvReceta.Name = "dgvReceta";
            this.dgvReceta.RowHeadersWidth = 51;
            this.dgvReceta.RowTemplate.Height = 24;
            this.dgvReceta.Size = new System.Drawing.Size(803, 168);
            this.dgvReceta.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre receta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantiad inicial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precio Gramo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "id material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "id catalogo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Cantidad final";
            // 
            // id_catalogo
            // 
            this.id_catalogo.HeaderText = "ID Receta";
            this.id_catalogo.MinimumWidth = 6;
            this.id_catalogo.Name = "id_catalogo";
            this.id_catalogo.Width = 125;
            // 
            // ID_Material
            // 
            this.ID_Material.HeaderText = "ID Detalle";
            this.ID_Material.MinimumWidth = 6;
            this.ID_Material.Name = "ID_Material";
            this.ID_Material.Width = 125;
            // 
            // CantidadInicial
            // 
            this.CantidadInicial.HeaderText = "Cantidad Inicial";
            this.CantidadInicial.MinimumWidth = 6;
            this.CantidadInicial.Name = "CantidadInicial";
            this.CantidadInicial.Width = 125;
            // 
            // CantidadDisponible
            // 
            this.CantidadDisponible.HeaderText = "Cantidad Disponible";
            this.CantidadDisponible.MinimumWidth = 6;
            this.CantidadDisponible.Name = "CantidadDisponible";
            this.CantidadDisponible.Width = 125;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 403);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReceta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantFIn);
            this.Controls.Add(this.txtprecioGr);
            this.Controls.Add(this.txtPrecioFin);
            this.Controls.Add(this.txtIdCata2);
            this.Controls.Add(this.txtcantInicial);
            this.Controls.Add(this.txtIdMateria);
            this.Controls.Add(this.txtCatalogo);
            this.Controls.Add(this.txtIdCatalogo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIdCatalogo;
        private System.Windows.Forms.TextBox txtCatalogo;
        private System.Windows.Forms.TextBox txtIdMateria;
        private System.Windows.Forms.TextBox txtcantInicial;
        private System.Windows.Forms.TextBox txtIdCata2;
        private System.Windows.Forms.TextBox txtPrecioFin;
        private System.Windows.Forms.TextBox txtprecioGr;
        private System.Windows.Forms.TextBox txtCantFIn;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvReceta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDisponible;
    }
}