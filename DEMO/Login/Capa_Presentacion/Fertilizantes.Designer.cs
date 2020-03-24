namespace Capa_Presentacion
{
    partial class Fertilizantes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvFertilizantes = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IDCultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insecticida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosisComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpocadeControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.comboCultivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPlaga = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizantes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFertilizantes
            // 
            this.dgvFertilizantes.AllowUserToAddRows = false;
            this.dgvFertilizantes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvFertilizantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFertilizantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFertilizantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFertilizantes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvFertilizantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFertilizantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFertilizantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFertilizantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFertilizantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCultivo,
            this.Cultivo,
            this.Plaga,
            this.Insecticida,
            this.Dosis,
            this.NombreComercial,
            this.DosisComercial,
            this.EpocadeControl});
            this.dgvFertilizantes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFertilizantes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFertilizantes.DoubleBuffered = true;
            this.dgvFertilizantes.EnableHeadersVisualStyles = false;
            this.dgvFertilizantes.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dgvFertilizantes.HeaderForeColor = System.Drawing.Color.White;
            this.dgvFertilizantes.Location = new System.Drawing.Point(35, 155);
            this.dgvFertilizantes.Name = "dgvFertilizantes";
            this.dgvFertilizantes.ReadOnly = true;
            this.dgvFertilizantes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvFertilizantes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvFertilizantes.RowHeadersVisible = false;
            this.dgvFertilizantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFertilizantes.Size = new System.Drawing.Size(897, 454);
            this.dgvFertilizantes.TabIndex = 56;
            // 
            // IDCultivo
            // 
            this.IDCultivo.DataPropertyName = "Id";
            this.IDCultivo.HeaderText = "ID";
            this.IDCultivo.Name = "IDCultivo";
            this.IDCultivo.ReadOnly = true;
            // 
            // Cultivo
            // 
            this.Cultivo.DataPropertyName = "Cultivo";
            this.Cultivo.HeaderText = "Cultivo";
            this.Cultivo.Name = "Cultivo";
            this.Cultivo.ReadOnly = true;
            // 
            // Plaga
            // 
            this.Plaga.DataPropertyName = "Plaga";
            this.Plaga.HeaderText = "Plaga";
            this.Plaga.Name = "Plaga";
            this.Plaga.ReadOnly = true;
            this.Plaga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Insecticida
            // 
            this.Insecticida.DataPropertyName = "Insecticida";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.Insecticida.DefaultCellStyle = dataGridViewCellStyle3;
            this.Insecticida.HeaderText = "Insecticida";
            this.Insecticida.Name = "Insecticida";
            this.Insecticida.ReadOnly = true;
            // 
            // Dosis
            // 
            this.Dosis.DataPropertyName = "Dosis";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.Dosis.DefaultCellStyle = dataGridViewCellStyle4;
            this.Dosis.HeaderText = "Dosis";
            this.Dosis.Name = "Dosis";
            this.Dosis.ReadOnly = true;
            // 
            // NombreComercial
            // 
            this.NombreComercial.DataPropertyName = "Nombre Comercial";
            this.NombreComercial.HeaderText = "Nombre Comercial";
            this.NombreComercial.Name = "NombreComercial";
            this.NombreComercial.ReadOnly = true;
            // 
            // DosisComercial
            // 
            this.DosisComercial.DataPropertyName = "Dosis Comercial";
            this.DosisComercial.HeaderText = "Dosis Comercial";
            this.DosisComercial.Name = "DosisComercial";
            this.DosisComercial.ReadOnly = true;
            // 
            // EpocadeControl
            // 
            this.EpocadeControl.DataPropertyName = "Epoca de Control";
            this.EpocadeControl.HeaderText = "Epoca de Control";
            this.EpocadeControl.Name = "EpocadeControl";
            this.EpocadeControl.ReadOnly = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtBuscar.ForeColor = System.Drawing.Color.Gray;
            this.txtBuscar.Location = new System.Drawing.Point(35, 82);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(200, 33);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            this.txtBuscar.MouseLeave += new System.EventHandler(this.txtBuscar_MouseLeave);
            // 
            // comboCultivo
            // 
            this.comboCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCultivo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.comboCultivo.FormattingEnabled = true;
            this.comboCultivo.Location = new System.Drawing.Point(685, 82);
            this.comboCultivo.Name = "comboCultivo";
            this.comboCultivo.Size = new System.Drawing.Size(247, 34);
            this.comboCultivo.TabIndex = 2;
            this.comboCultivo.SelectedIndexChanged += new System.EventHandler(this.comboCultivo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(604, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Planta:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboPlaga
            // 
            this.comboPlaga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPlaga.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.comboPlaga.FormattingEnabled = true;
            this.comboPlaga.Location = new System.Drawing.Point(316, 82);
            this.comboPlaga.Name = "comboPlaga";
            this.comboPlaga.Size = new System.Drawing.Size(247, 34);
            this.comboPlaga.TabIndex = 4;
            this.comboPlaga.SelectedIndexChanged += new System.EventHandler(this.comboPlaga_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(241, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plaga:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(787, 629);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exportar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 39);
            this.label1.TabIndex = 65;
            this.label1.Text = "Fertilizantes";
            // 
            // Fertilizantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCultivo);
            this.Controls.Add(this.dgvFertilizantes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPlaga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fertilizantes";
            this.Text = "Fertilizantes";
            this.Load += new System.EventHandler(this.Fertilizantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFertilizantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvFertilizantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insecticida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosisComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpocadeControl;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox comboCultivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPlaga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}