namespace Capa_Presentacion
{
    partial class Insecticidas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idInsecticida = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label5 = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(44, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Insecticida";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(44, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(44, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaga que elimina";
            // 
            // idInsecticida
            // 
            this.idInsecticida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.idInsecticida.Enabled = false;
            this.idInsecticida.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.idInsecticida.Location = new System.Drawing.Point(524, 636);
            this.idInsecticida.Name = "idInsecticida";
            this.idInsecticida.Size = new System.Drawing.Size(257, 33);
            this.idInsecticida.TabIndex = 5;
            this.idInsecticida.Visible = false;
            // 
            // nombre
            // 
            this.nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nombre.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.nombre.Location = new System.Drawing.Point(227, 446);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(257, 33);
            this.nombre.TabIndex = 6;
            // 
            // precio
            // 
            this.precio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.precio.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.precio.Location = new System.Drawing.Point(227, 485);
            this.precio.MaxLength = 8;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(257, 33);
            this.precio.TabIndex = 7;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Huevecillos de mosca pinta",
            "Mosca pinta comiendo cultivo",
            "Gusano Barrenador",
            "Pulgon amarillo",
            "Chinche de encaje",
            "Piojo harinoso de la vid",
            "Trips Frankliniella",
            "Gusano soldado",
            "Larva minador de la hoja",
            "Minador de la hoja adulto",
            "Presencia Gusano de la Panoja",
            "Inicio desarrollo Gusano Cogollero",
            "Inicio desarrollo Mosca Midge",
            "Pulgon amarillo adulto",
            "Pulgon del cogollo",
            "Tizon de la Hoja",
            "Roya o chahuixtle",
            "Tizon de la Panoja",
            "Orugas cortadoras",
            "Orugas defoliadoras",
            "Barrenador del brote",
            "Chinches",
            "Gusano cogollero",
            "Araña roja",
            "Gusano elotero",
            "Gallina ciega"});
            this.comboBox1.Location = new System.Drawing.Point(227, 524);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 34);
            this.comboBox1.TabIndex = 8;
            // 
            // agregar
            // 
            this.agregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.agregar.FlatAppearance.BorderSize = 0;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.ForeColor = System.Drawing.Color.White;
            this.agregar.Location = new System.Drawing.Point(583, 444);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(145, 40);
            this.agregar.TabIndex = 9;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.eliminar.FlatAppearance.BorderSize = 0;
            this.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminar.ForeColor = System.Drawing.Color.White;
            this.eliminar.Location = new System.Drawing.Point(583, 562);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(145, 40);
            this.eliminar.TabIndex = 10;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // editar
            // 
            this.editar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.editar.FlatAppearance.BorderSize = 0;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(583, 504);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(145, 40);
            this.editar.TabIndex = 11;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(38, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(898, 339);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label5.Location = new System.Drawing.Point(36, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 39);
            this.label5.TabIndex = 122;
            this.label5.Text = "Insecticidas";
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.desc.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.desc.Location = new System.Drawing.Point(227, 564);
            this.desc.Multiline = true;
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(257, 33);
            this.desc.TabIndex = 123;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(44, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 124;
            this.label1.Text = "Descripcion";
            // 
            // Insecticidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.idInsecticida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insecticidas";
            this.Text = "Insecticidas";
            this.Load += new System.EventHandler(this.Insecticidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idInsecticida;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button editar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label1;
    }
}