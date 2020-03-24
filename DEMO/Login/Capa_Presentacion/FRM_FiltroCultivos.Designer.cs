namespace Capa_Presentacion
{
    partial class FRM_FiltroCultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_FiltroCultivos));
            this.btn_crear_reporte = new System.Windows.Forms.Button();
            this.cmb_cultivo = new System.Windows.Forms.ComboBox();
            this.cmb_plantado = new System.Windows.Forms.ComboBox();
            this.cmb_cosecha = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_crear_reporte
            // 
            this.btn_crear_reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btn_crear_reporte.FlatAppearance.BorderSize = 0;
            this.btn_crear_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_crear_reporte.ForeColor = System.Drawing.Color.White;
            this.btn_crear_reporte.Location = new System.Drawing.Point(159, 217);
            this.btn_crear_reporte.Name = "btn_crear_reporte";
            this.btn_crear_reporte.Size = new System.Drawing.Size(145, 40);
            this.btn_crear_reporte.TabIndex = 0;
            this.btn_crear_reporte.Text = "Aceptar";
            this.btn_crear_reporte.UseVisualStyleBackColor = false;
            this.btn_crear_reporte.Click += new System.EventHandler(this.btn_crear_reporte_Click);
            // 
            // cmb_cultivo
            // 
            this.cmb_cultivo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cmb_cultivo.FormattingEnabled = true;
            this.cmb_cultivo.Location = new System.Drawing.Point(194, 73);
            this.cmb_cultivo.Name = "cmb_cultivo";
            this.cmb_cultivo.Size = new System.Drawing.Size(247, 34);
            this.cmb_cultivo.TabIndex = 1;
            // 
            // cmb_plantado
            // 
            this.cmb_plantado.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cmb_plantado.FormattingEnabled = true;
            this.cmb_plantado.Location = new System.Drawing.Point(194, 115);
            this.cmb_plantado.Name = "cmb_plantado";
            this.cmb_plantado.Size = new System.Drawing.Size(247, 34);
            this.cmb_plantado.TabIndex = 2;
            // 
            // cmb_cosecha
            // 
            this.cmb_cosecha.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.cmb_cosecha.FormattingEnabled = true;
            this.cmb_cosecha.Location = new System.Drawing.Point(194, 159);
            this.cmb_cosecha.Name = "cmb_cosecha";
            this.cmb_cosecha.Size = new System.Drawing.Size(247, 34);
            this.cmb_cosecha.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 35);
            this.panel1.TabIndex = 145;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 33);
            this.label2.TabIndex = 145;
            this.label2.Text = "Filtro cultivos";
            // 
            // btnCer
            // 
            this.btnCer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCer.BackgroundImage")));
            this.btnCer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCer.FlatAppearance.BorderSize = 0;
            this.btnCer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(15)))), ((int)(((byte)(33)))));
            this.btnCer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnCer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCer.Location = new System.Drawing.Point(422, 0);
            this.btnCer.Name = "btnCer";
            this.btnCer.Size = new System.Drawing.Size(50, 35);
            this.btnCer.TabIndex = 20;
            this.btnCer.UseVisualStyleBackColor = true;
            this.btnCer.Click += new System.EventHandler(this.btnCer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 146;
            this.label1.Text = "Cultivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 26);
            this.label3.TabIndex = 147;
            this.label3.Text = "Fecha plantado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 26);
            this.label4.TabIndex = 148;
            this.label4.Text = "Fecha de cosecha";
            // 
            // FRM_FiltroCultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(472, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_cosecha);
            this.Controls.Add(this.cmb_plantado);
            this.Controls.Add(this.cmb_cultivo);
            this.Controls.Add(this.btn_crear_reporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_FiltroCultivos";
            this.Text = "FRM_FiltroCultivos";
            this.Load += new System.EventHandler(this.FRM_FiltroCultivos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear_reporte;
        private System.Windows.Forms.ComboBox cmb_cultivo;
        private System.Windows.Forms.ComboBox cmb_plantado;
        private System.Windows.Forms.ComboBox cmb_cosecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}