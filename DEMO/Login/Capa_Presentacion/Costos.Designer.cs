namespace Capa_Presentacion
{
    partial class Costos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costos));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCultivo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnElimiar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.cbCultivo = new System.Windows.Forms.ComboBox();
            this.lbCultivo = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.BtnExp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 39);
            this.label1.TabIndex = 71;
            this.label1.Text = "Costos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(671, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 130;
            // 
            // dgvCultivo
            // 
            this.dgvCultivo.AllowUserToAddRows = false;
            this.dgvCultivo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCultivo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCultivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCultivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCultivo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCultivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCultivo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCultivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCultivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCultivo.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCultivo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCultivo.DoubleBuffered = true;
            this.dgvCultivo.EnableHeadersVisualStyles = false;
            this.dgvCultivo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dgvCultivo.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCultivo.Location = new System.Drawing.Point(29, 73);
            this.dgvCultivo.MultiSelect = false;
            this.dgvCultivo.Name = "dgvCultivo";
            this.dgvCultivo.ReadOnly = true;
            this.dgvCultivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCultivo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCultivo.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCultivo.RowHeadersVisible = false;
            this.dgvCultivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCultivo.Size = new System.Drawing.Size(910, 367);
            this.dgvCultivo.TabIndex = 134;
            this.dgvCultivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCultivo_CellDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(341, 603);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(145, 40);
            this.btnAgregar.TabIndex = 136;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnElimiar
            // 
            this.btnElimiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnElimiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnElimiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimiar.Enabled = false;
            this.btnElimiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElimiar.ForeColor = System.Drawing.Color.White;
            this.btnElimiar.Location = new System.Drawing.Point(643, 603);
            this.btnElimiar.Name = "btnElimiar";
            this.btnElimiar.Size = new System.Drawing.Size(145, 40);
            this.btnElimiar.TabIndex = 137;
            this.btnElimiar.Text = "Eliminar";
            this.btnElimiar.UseVisualStyleBackColor = false;
            this.btnElimiar.Click += new System.EventHandler(this.btnElimiar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Enabled = false;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(492, 603);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(145, 40);
            this.btnEditar.TabIndex = 135;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbPrecio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.ForeColor = System.Drawing.Color.DimGray;
            this.lbPrecio.Location = new System.Drawing.Point(39, 560);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(81, 26);
            this.lbPrecio.TabIndex = 142;
            this.lbPrecio.Text = "Precio $";
            // 
            // cbCultivo
            // 
            this.cbCultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCultivo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cbCultivo.FormattingEnabled = true;
            this.cbCultivo.Location = new System.Drawing.Point(134, 506);
            this.cbCultivo.Name = "cbCultivo";
            this.cbCultivo.Size = new System.Drawing.Size(173, 34);
            this.cbCultivo.TabIndex = 141;
            // 
            // lbCultivo
            // 
            this.lbCultivo.AutoSize = true;
            this.lbCultivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCultivo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCultivo.ForeColor = System.Drawing.Color.DimGray;
            this.lbCultivo.Location = new System.Drawing.Point(39, 509);
            this.lbCultivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCultivo.Name = "lbCultivo";
            this.lbCultivo.Size = new System.Drawing.Size(71, 26);
            this.lbCultivo.TabIndex = 139;
            this.lbCultivo.Text = "Cultivo";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(134, 557);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(173, 33);
            this.tbPrecio.TabIndex = 140;
            this.tbPrecio.Text = "0";
            // 
            // BtnExp
            // 
            this.BtnExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.BtnExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExp.Enabled = false;
            this.BtnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExp.ForeColor = System.Drawing.Color.White;
            this.BtnExp.Location = new System.Drawing.Point(794, 603);
            this.BtnExp.Name = "BtnExp";
            this.BtnExp.Size = new System.Drawing.Size(145, 40);
            this.BtnExp.TabIndex = 143;
            this.BtnExp.Text = "Exportar";
            this.BtnExp.UseVisualStyleBackColor = false;
            this.BtnExp.Click += new System.EventHandler(this.BtnExportar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(375, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 26);
            this.label2.TabIndex = 144;
            this.label2.Text = "Descripcion";
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.descripcion.Location = new System.Drawing.Point(511, 507);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(196, 33);
            this.descripcion.TabIndex = 145;
            // 
            // Costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnExp);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.cbCultivo);
            this.Controls.Add(this.lbCultivo);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnElimiar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgvCultivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Costos";
            this.Text = "Costos";
            this.Load += new System.EventHandler(this.Costos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCultivo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnElimiar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.ComboBox cbCultivo;
        private System.Windows.Forms.Label lbCultivo;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button BtnExp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox descripcion;
    }
}