namespace Capa_Presentacion
{
    partial class Fertilizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFertilizaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idFertilizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.necesitaNPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tieneNPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaCalculado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbCultivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNPKActual = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNPKNecesario = new System.Windows.Forms.TextBox();
            this.dgvEtapas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.Etapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.npk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgPorDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kgPorEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFertilizaciones
            // 
            this.dgvFertilizaciones.AllowUserToAddRows = false;
            this.dgvFertilizaciones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFertilizaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFertilizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFertilizaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFertilizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFertilizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFertilizaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFertilizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilizaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFertilizacion,
            this.cultivo,
            this.necesitaNPK,
            this.tieneNPK,
            this.diaCalculado});
            this.dgvFertilizaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFertilizaciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFertilizaciones.DoubleBuffered = true;
            this.dgvFertilizaciones.EnableHeadersVisualStyles = false;
            this.dgvFertilizaciones.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dgvFertilizaciones.HeaderForeColor = System.Drawing.Color.White;
            this.dgvFertilizaciones.Location = new System.Drawing.Point(15, 67);
            this.dgvFertilizaciones.Name = "dgvFertilizaciones";
            this.dgvFertilizaciones.ReadOnly = true;
            this.dgvFertilizaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFertilizaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFertilizaciones.RowHeadersVisible = false;
            this.dgvFertilizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFertilizaciones.Size = new System.Drawing.Size(350, 252);
            this.dgvFertilizaciones.TabIndex = 54;
            // 
            // idFertilizacion
            // 
            this.idFertilizacion.DataPropertyName = "idFertilizacion";
            this.idFertilizacion.HeaderText = "ID Fertilizacion";
            this.idFertilizacion.Name = "idFertilizacion";
            this.idFertilizacion.ReadOnly = true;
            this.idFertilizacion.Visible = false;
            // 
            // cultivo
            // 
            this.cultivo.DataPropertyName = "cultivo";
            this.cultivo.HeaderText = "Cultivo";
            this.cultivo.Name = "cultivo";
            this.cultivo.ReadOnly = true;
            // 
            // necesitaNPK
            // 
            this.necesitaNPK.DataPropertyName = "necesitaNPK";
            this.necesitaNPK.HeaderText = "NPK Necesario";
            this.necesitaNPK.Name = "necesitaNPK";
            this.necesitaNPK.ReadOnly = true;
            // 
            // tieneNPK
            // 
            this.tieneNPK.DataPropertyName = "tieneNPK";
            dataGridViewCellStyle3.NullValue = "0,0,0";
            this.tieneNPK.DefaultCellStyle = dataGridViewCellStyle3;
            this.tieneNPK.HeaderText = "NPK Actual";
            this.tieneNPK.Name = "tieneNPK";
            this.tieneNPK.ReadOnly = true;
            // 
            // diaCalculado
            // 
            this.diaCalculado.DataPropertyName = "diaCalculado";
            this.diaCalculado.HeaderText = "Día";
            this.diaCalculado.Name = "diaCalculado";
            this.diaCalculado.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(13, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 39);
            this.label6.TabIndex = 68;
            this.label6.Text = "Fertilizaciones";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(157)))), ((int)(((byte)(43)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(15, 508);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 40);
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(233, 508);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 40);
            this.btnAgregar.TabIndex = 70;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // cbCultivo
            // 
            this.cbCultivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCultivo.FormattingEnabled = true;
            this.cbCultivo.Items.AddRange(new object[] {
            "Maíz",
            "Sorgo",
            "Soya",
            "Caña",
            "Cebolla"});
            this.cbCultivo.Location = new System.Drawing.Point(140, 344);
            this.cbCultivo.Name = "cbCultivo";
            this.cbCultivo.Size = new System.Drawing.Size(123, 21);
            this.cbCultivo.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 72;
            this.label3.Text = "Cultivo:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 400);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "NPK Actual:";
            // 
            // txtNPKActual
            // 
            this.txtNPKActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNPKActual.Location = new System.Drawing.Point(140, 402);
            this.txtNPKActual.MaxLength = 20;
            this.txtNPKActual.Name = "txtNPKActual";
            this.txtNPKActual.Size = new System.Drawing.Size(123, 20);
            this.txtNPKActual.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 459);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "NPK Necesario:";
            // 
            // txtNPKNecesario
            // 
            this.txtNPKNecesario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNPKNecesario.Location = new System.Drawing.Point(140, 461);
            this.txtNPKNecesario.MaxLength = 20;
            this.txtNPKNecesario.Name = "txtNPKNecesario";
            this.txtNPKNecesario.Size = new System.Drawing.Size(123, 20);
            this.txtNPKNecesario.TabIndex = 78;
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEtapas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEtapas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEtapas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEtapas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEtapas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEtapas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Etapa,
            this.Dias,
            this.npk,
            this.kgPorDia,
            this.kgPorEtapa,
            this.porcentaje});
            this.dgvEtapas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEtapas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEtapas.DoubleBuffered = true;
            this.dgvEtapas.EnableHeadersVisualStyles = false;
            this.dgvEtapas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dgvEtapas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEtapas.Location = new System.Drawing.Point(459, 67);
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvEtapas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEtapas.RowHeadersVisible = false;
            this.dgvEtapas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapas.Size = new System.Drawing.Size(493, 252);
            this.dgvEtapas.TabIndex = 79;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(660, 342);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(132, 40);
            this.btnCalcular.TabIndex = 80;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // Etapa
            // 
            this.Etapa.HeaderText = "Etapa";
            this.Etapa.Name = "Etapa";
            this.Etapa.ReadOnly = true;
            // 
            // Dias
            // 
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.Dias.DefaultCellStyle = dataGridViewCellStyle7;
            this.Dias.HeaderText = "Días";
            this.Dias.Name = "Dias";
            // 
            // npk
            // 
            this.npk.HeaderText = "N P K";
            this.npk.Name = "npk";
            this.npk.ReadOnly = true;
            // 
            // kgPorDia
            // 
            this.kgPorDia.HeaderText = "Kg por día";
            this.kgPorDia.Name = "kgPorDia";
            // 
            // kgPorEtapa
            // 
            this.kgPorEtapa.HeaderText = "Kg por etapa";
            this.kgPorEtapa.Name = "kgPorEtapa";
            this.kgPorEtapa.ReadOnly = true;
            // 
            // porcentaje
            // 
            this.porcentaje.HeaderText = "Porcentaje";
            this.porcentaje.Name = "porcentaje";
            // 
            // Fertilizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNPKNecesario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNPKActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCultivo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvFertilizaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fertilizaciones";
            this.Text = "Fertilizaciones";
            this.Load += new System.EventHandler(this.Fertilizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFertilizaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbCultivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNPKActual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNPKNecesario;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEtapas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFertilizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn necesitaNPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn tieneNPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaCalculado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn npk;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgPorDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn kgPorEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
    }
}