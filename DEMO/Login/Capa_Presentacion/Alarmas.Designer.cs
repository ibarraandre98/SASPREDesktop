namespace Capa_Presentacion
{
    partial class Alarmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarmas));
            this.dgvAlmacen = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.lbDias = new System.Windows.Forms.Label();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lbCult = new System.Windows.Forms.Label();
            this.txtCultivo = new System.Windows.Forms.ComboBox();
            this.lbTem = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlmacen
            // 
            this.dgvAlmacen.AllowUserToAddRows = false;
            this.dgvAlmacen.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlmacen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlmacen.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlmacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlmacen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlmacen.DoubleBuffered = true;
            this.dgvAlmacen.EnableHeadersVisualStyles = false;
            this.dgvAlmacen.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dgvAlmacen.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlmacen.Location = new System.Drawing.Point(35, 67);
            this.dgvAlmacen.Name = "dgvAlmacen";
            this.dgvAlmacen.ReadOnly = true;
            this.dgvAlmacen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvAlmacen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlmacen.RowHeadersVisible = false;
            this.dgvAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlmacen.Size = new System.Drawing.Size(746, 417);
            this.dgvAlmacen.TabIndex = 154;
            this.dgvAlmacen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlarmas_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(36, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 39);
            this.label1.TabIndex = 153;
            this.label1.Text = "Alarmas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(800, 66);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 40);
            this.btnAgregar.TabIndex = 143;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(800, 506);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(145, 40);
            this.btnGuardar.TabIndex = 140;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(800, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 40);
            this.btnCancelar.TabIndex = 147;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(800, 112);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 40);
            this.btnEditar.TabIndex = 142;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbNombre.AutoSize = true;
            this.lbNombre.Enabled = false;
            this.lbNombre.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lbNombre.ForeColor = System.Drawing.Color.DimGray;
            this.lbNombre.Location = new System.Drawing.Point(47, 506);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(82, 26);
            this.lbNombre.TabIndex = 144;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtNombre.Location = new System.Drawing.Point(141, 506);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 33);
            this.txtNombre.TabIndex = 141;
            // 
            // lbMax
            // 
            this.lbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMax.AutoSize = true;
            this.lbMax.Enabled = false;
            this.lbMax.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lbMax.ForeColor = System.Drawing.Color.DimGray;
            this.lbMax.Location = new System.Drawing.Point(383, 506);
            this.lbMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(81, 26);
            this.lbMax.TabIndex = 156;
            this.lbMax.Text = "Maxima";
            // 
            // txtMax
            // 
            this.txtMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMax.Enabled = false;
            this.txtMax.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMax.Location = new System.Drawing.Point(471, 503);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(217, 33);
            this.txtMax.TabIndex = 155;
            // 
            // lbMin
            // 
            this.lbMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMin.AutoSize = true;
            this.lbMin.Enabled = false;
            this.lbMin.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lbMin.ForeColor = System.Drawing.Color.DimGray;
            this.lbMin.Location = new System.Drawing.Point(383, 545);
            this.lbMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(78, 26);
            this.lbMin.TabIndex = 158;
            this.lbMin.Text = "Minima";
            // 
            // txtMin
            // 
            this.txtMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMin.Enabled = false;
            this.txtMin.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtMin.Location = new System.Drawing.Point(471, 545);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(217, 33);
            this.txtMin.TabIndex = 157;
            // 
            // lbDias
            // 
            this.lbDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbDias.AutoSize = true;
            this.lbDias.Enabled = false;
            this.lbDias.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lbDias.ForeColor = System.Drawing.Color.DimGray;
            this.lbDias.Location = new System.Drawing.Point(47, 545);
            this.lbDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDias.Name = "lbDias";
            this.lbDias.Size = new System.Drawing.Size(72, 26);
            this.lbDias.TabIndex = 160;
            this.lbDias.Text = "N° dias";
            // 
            // txtDias
            // 
            this.txtDias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDias.Enabled = false;
            this.txtDias.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtDias.Location = new System.Drawing.Point(141, 545);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(217, 33);
            this.txtDias.TabIndex = 159;
            // 
            // lbCult
            // 
            this.lbCult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCult.AutoSize = true;
            this.lbCult.Enabled = false;
            this.lbCult.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lbCult.ForeColor = System.Drawing.Color.DimGray;
            this.lbCult.Location = new System.Drawing.Point(47, 584);
            this.lbCult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCult.Name = "lbCult";
            this.lbCult.Size = new System.Drawing.Size(71, 26);
            this.lbCult.TabIndex = 162;
            this.lbCult.Text = "Cultivo";
            // 
            // txtCultivo
            // 
            this.txtCultivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCultivo.Enabled = false;
            this.txtCultivo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtCultivo.FormattingEnabled = true;
            this.txtCultivo.Items.AddRange(new object[] {
            "Admin",
            "Estudiante"});
            this.txtCultivo.Location = new System.Drawing.Point(141, 584);
            this.txtCultivo.Name = "txtCultivo";
            this.txtCultivo.Size = new System.Drawing.Size(217, 34);
            this.txtCultivo.Sorted = true;
            this.txtCultivo.TabIndex = 163;
            this.txtCultivo.SelectedIndexChanged += new System.EventHandler(this.TxtCultivo_SelectedIndexChanged);
            // 
            // lbTem
            // 
            this.lbTem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbTem.AutoSize = true;
            this.lbTem.Enabled = false;
            this.lbTem.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.lbTem.ForeColor = System.Drawing.Color.DimGray;
            this.lbTem.Location = new System.Drawing.Point(695, 548);
            this.lbTem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTem.Name = "lbTem";
            this.lbTem.Size = new System.Drawing.Size(120, 26);
            this.lbTem.TabIndex = 164;
            this.lbTem.Text = "Temperatura";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(800, 158);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(145, 40);
            this.btnEliminar.TabIndex = 165;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(374, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 166;
            this.label2.Text = "Descripcion";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDesc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtDesc.Location = new System.Drawing.Point(514, 584);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(230, 33);
            this.txtDesc.TabIndex = 167;
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(576, 638);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 168;
            this.txtId.Visible = false;
            // 
            // Alarmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbTem);
            this.Controls.Add(this.txtCultivo);
            this.Controls.Add(this.lbCult);
            this.Controls.Add(this.lbDias);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.lbMin);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lbMax);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.dgvAlmacen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarmas";
            this.Text = "Alarmas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label lbDias;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lbCult;
        private System.Windows.Forms.ComboBox txtCultivo;
        private System.Windows.Forms.Label lbTem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtId;
    }
}