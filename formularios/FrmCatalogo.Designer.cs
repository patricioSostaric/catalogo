
namespace formularios
{
    partial class FrmCatalogo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFiltroRapido = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvListaArt = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblDescSelec = new System.Windows.Forms.Label();
            this.lblPrecioSelec = new System.Windows.Forms.Label();
            this.lblMarcaSelec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombreSelec = new System.Windows.Forms.Label();
            this.btnAgCat = new System.Windows.Forms.Button();
            this.btnAgMarca = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFiltroAvanz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltroRapido
            // 
            this.txtFiltroRapido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroRapido.Location = new System.Drawing.Point(11, 52);
            this.txtFiltroRapido.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroRapido.Name = "txtFiltroRapido";
            this.txtFiltroRapido.Size = new System.Drawing.Size(147, 21);
            this.txtFiltroRapido.TabIndex = 12;
            this.txtFiltroRapido.TextChanged += new System.EventHandler(this.txtFiltroRapido_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(11, 23);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(189, 15);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "Búsqueda por marca o categoría:";
            // 
            // dgvListaArt
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvListaArt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListaArt.BackgroundColor = System.Drawing.Color.Snow;
            this.dgvListaArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArt.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaArt.Location = new System.Drawing.Point(11, 112);
            this.dgvListaArt.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaArt.MultiSelect = false;
            this.dgvListaArt.Name = "dgvListaArt";
            this.dgvListaArt.RowHeadersWidth = 62;
            this.dgvListaArt.RowTemplate.Height = 28;
            this.dgvListaArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArt.Size = new System.Drawing.Size(707, 221);
            this.dgvListaArt.TabIndex = 13;
            this.dgvListaArt.SelectionChanged += new System.EventHandler(this.dgvListaArt_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(889, 70);
            this.pbxArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(277, 263);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxArticulo.TabIndex = 22;
            this.pbxArticulo.TabStop = false;
            // 
            // lblDescSelec
            // 
            this.lblDescSelec.AutoSize = true;
            this.lblDescSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescSelec.Location = new System.Drawing.Point(895, 466);
            this.lblDescSelec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescSelec.Name = "lblDescSelec";
            this.lblDescSelec.Size = new System.Drawing.Size(86, 17);
            this.lblDescSelec.TabIndex = 37;
            this.lblDescSelec.Text = "Descripción:";
            // 
            // lblPrecioSelec
            // 
            this.lblPrecioSelec.AutoSize = true;
            this.lblPrecioSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSelec.Location = new System.Drawing.Point(895, 449);
            this.lblPrecioSelec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioSelec.Name = "lblPrecioSelec";
            this.lblPrecioSelec.Size = new System.Drawing.Size(52, 17);
            this.lblPrecioSelec.TabIndex = 36;
            this.lblPrecioSelec.Text = "Precio:";
            // 
            // lblMarcaSelec
            // 
            this.lblMarcaSelec.AutoSize = true;
            this.lblMarcaSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaSelec.Location = new System.Drawing.Point(896, 432);
            this.lblMarcaSelec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarcaSelec.Name = "lblMarcaSelec";
            this.lblMarcaSelec.Size = new System.Drawing.Size(51, 17);
            this.lblMarcaSelec.TabIndex = 33;
            this.lblMarcaSelec.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(896, 384);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Características:";
            // 
            // lblNombreSelec
            // 
            this.lblNombreSelec.AutoSize = true;
            this.lblNombreSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSelec.Location = new System.Drawing.Point(895, 415);
            this.lblNombreSelec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreSelec.Name = "lblNombreSelec";
            this.lblNombreSelec.Size = new System.Drawing.Size(62, 17);
            this.lblNombreSelec.TabIndex = 35;
            this.lblNombreSelec.Text = "Nombre:";
            // 
            // btnAgCat
            // 
            this.btnAgCat.Location = new System.Drawing.Point(249, 530);
            this.btnAgCat.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgCat.Name = "btnAgCat";
            this.btnAgCat.Size = new System.Drawing.Size(147, 30);
            this.btnAgCat.TabIndex = 43;
            this.btnAgCat.Text = "Agregar Categoria";
            this.btnAgCat.UseVisualStyleBackColor = true;
            this.btnAgCat.Click += new System.EventHandler(this.btnAgCat_Click);
            // 
            // btnAgMarca
            // 
            this.btnAgMarca.Location = new System.Drawing.Point(14, 530);
            this.btnAgMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgMarca.Name = "btnAgMarca";
            this.btnAgMarca.Size = new System.Drawing.Size(147, 30);
            this.btnAgMarca.TabIndex = 42;
            this.btnAgMarca.Text = "Agregar Marca";
            this.btnAgMarca.UseVisualStyleBackColor = true;
            this.btnAgMarca.Click += new System.EventHandler(this.btnAgMarca_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(277, 487);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 30);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Location = new System.Drawing.Point(150, 487);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(95, 30);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(17, 487);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 30);
            this.btnAgregar.TabIndex = 41;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCampo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCriterio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFiltroAvanz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 384);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(652, 65);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro Avanzado";
            // 
            // cmbCampo
            // 
            this.cmbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Location = new System.Drawing.Point(58, 26);
            this.cmbCampo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(106, 21);
            this.cmbCampo.TabIndex = 6;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Campo:";
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Location = new System.Drawing.Point(238, 27);
            this.cmbCriterio.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(123, 21);
            this.cmbCriterio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Criterio:";
            // 
            // txtFiltroAvanz
            // 
            this.txtFiltroAvanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAvanz.Location = new System.Drawing.Point(417, 27);
            this.txtFiltroAvanz.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroAvanz.Name = "txtFiltroAvanz";
            this.txtFiltroAvanz.Size = new System.Drawing.Size(124, 21);
            this.txtFiltroAvanz.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filtro:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(556, 23);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(65, 23);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 611);
            this.Controls.Add(this.btnAgCat);
            this.Controls.Add(this.btnAgMarca);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDescSelec);
            this.Controls.Add(this.lblPrecioSelec);
            this.Controls.Add(this.lblMarcaSelec);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreSelec);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvListaArt);
            this.Controls.Add(this.txtFiltroRapido);
            this.Controls.Add(this.lblFiltro);
            this.MaximumSize = new System.Drawing.Size(1270, 650);
            this.MinimumSize = new System.Drawing.Size(1270, 650);
            this.Name = "FrmCatalogo";
            this.Text = "FrmCatalogo";
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltroRapido;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgvListaArt;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblDescSelec;
        private System.Windows.Forms.Label lblPrecioSelec;
        private System.Windows.Forms.Label lblMarcaSelec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombreSelec;
        private System.Windows.Forms.Button btnAgCat;
        private System.Windows.Forms.Button btnAgMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFiltroAvanz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFiltrar;
    }
}