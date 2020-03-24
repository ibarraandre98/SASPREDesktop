namespace Capa_Presentacion
{
    partial class Cultivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cultivos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageListPlantas = new System.Windows.Forms.ImageList(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularEstado = new System.Windows.Forms.Button();
            this.btnCosechar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpCosecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPlantado = new System.Windows.Forms.DateTimePicker();
            this.cbPlanta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCultivo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.IDCultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cultivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plantado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cosecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarUnCultivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDisponible = new System.Windows.Forms.Label();
            this.picCultivo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCultivo)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListPlantas
            // 
            this.imageListPlantas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPlantas.ImageStream")));
            this.imageListPlantas.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPlantas.Images.SetKeyName(0, "MAÍZFINAL.jpg");
            this.imageListPlantas.Images.SetKeyName(1, "SORGO.png");
            this.imageListPlantas.Images.SetKeyName(2, "SOYA.jpg");
            this.imageListPlantas.Images.SetKeyName(3, "CAÑA.jpg");
            this.imageListPlantas.Images.SetKeyName(4, "CEBOLLA.png");
            this.imageListPlantas.Images.SetKeyName(5, "SOYA2.jpg");
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(539, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 26);
            this.dateTimePicker1.TabIndex = 66;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnCalcularEstado
            // 
            this.btnCalcularEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcularEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnCalcularEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularEstado.FlatAppearance.BorderSize = 0;
            this.btnCalcularEstado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnCalcularEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCalcularEstado.ForeColor = System.Drawing.Color.White;
            this.btnCalcularEstado.Location = new System.Drawing.Point(609, 384);
            this.btnCalcularEstado.Name = "btnCalcularEstado";
            this.btnCalcularEstado.Size = new System.Drawing.Size(155, 40);
            this.btnCalcularEstado.TabIndex = 65;
            this.btnCalcularEstado.Text = "Calcular estado";
            this.btnCalcularEstado.UseVisualStyleBackColor = false;
            this.btnCalcularEstado.Click += new System.EventHandler(this.btnCalcularEstado_Click);
            // 
            // btnCosechar
            // 
            this.btnCosechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCosechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnCosechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCosechar.FlatAppearance.BorderSize = 0;
            this.btnCosechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnCosechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCosechar.ForeColor = System.Drawing.Color.White;
            this.btnCosechar.Location = new System.Drawing.Point(785, 384);
            this.btnCosechar.Name = "btnCosechar";
            this.btnCosechar.Size = new System.Drawing.Size(155, 40);
            this.btnCosechar.TabIndex = 64;
            this.btnCosechar.Text = "Cosechar";
            this.btnCosechar.UseVisualStyleBackColor = false;
            this.btnCosechar.Click += new System.EventHandler(this.btnCosechar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(176)))), ((int)(((byte)(115)))));
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(785, 63);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(155, 40);
            this.btnExportar.TabIndex = 63;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantidad.Location = new System.Drawing.Point(539, 523);
            this.txtCantidad.MaxLength = 4;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 26);
            this.txtCantidad.TabIndex = 62;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(325, 526);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Cantidad (metro):";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 486);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "Fecha tentativa de cosecha:";
            // 
            // dtpCosecha
            // 
            this.dtpCosecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpCosecha.CustomFormat = "yyyy-MM-dd";
            this.dtpCosecha.Location = new System.Drawing.Point(539, 481);
            this.dtpCosecha.Name = "dtpCosecha";
            this.dtpCosecha.Size = new System.Drawing.Size(240, 26);
            this.dtpCosecha.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 450);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Fecha de plantado:";
            // 
            // dtpPlantado
            // 
            this.dtpPlantado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpPlantado.CalendarFont = new System.Drawing.Font("Corbel", 8.25F);
            this.dtpPlantado.CustomFormat = "yyyy-MM-dd";
            this.dtpPlantado.Location = new System.Drawing.Point(539, 444);
            this.dtpPlantado.Name = "dtpPlantado";
            this.dtpPlantado.Size = new System.Drawing.Size(240, 26);
            this.dtpPlantado.TabIndex = 57;
            this.dtpPlantado.ValueChanged += new System.EventHandler(this.dtpPlantado_ValueChanged);
            // 
            // cbPlanta
            // 
            this.cbPlanta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanta.FormattingEnabled = true;
            this.cbPlanta.Items.AddRange(new object[] {
            "Maíz",
            "Sorgo",
            "Soya",
            "Caña",
            "Cebolla"});
            this.cbPlanta.Location = new System.Drawing.Point(42, 384);
            this.cbPlanta.Name = "cbPlanta";
            this.cbPlanta.Size = new System.Drawing.Size(255, 28);
            this.cbPlanta.TabIndex = 56;
            this.cbPlanta.SelectedIndexChanged += new System.EventHandler(this.cbPlanta_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(37, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 26);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar un cultivo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCultivo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCultivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCultivo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCultivo,
            this.Usuario,
            this.Cultivo,
            this.Plantado,
            this.Cosecha,
            this.Cantidad,
            this.Estado});
            this.dgvCultivo.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCultivo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCultivo.DoubleBuffered = true;
            this.dgvCultivo.EnableHeadersVisualStyles = false;
            this.dgvCultivo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.dgvCultivo.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCultivo.Location = new System.Drawing.Point(42, 113);
            this.dgvCultivo.Name = "dgvCultivo";
            this.dgvCultivo.ReadOnly = true;
            this.dgvCultivo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCultivo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCultivo.RowHeadersVisible = false;
            this.dgvCultivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCultivo.Size = new System.Drawing.Size(898, 252);
            this.dgvCultivo.TabIndex = 53;
            this.dgvCultivo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // IDCultivo
            // 
            this.IDCultivo.DataPropertyName = "IDCultivo";
            this.IDCultivo.HeaderText = "IDCultivo";
            this.IDCultivo.Name = "IDCultivo";
            this.IDCultivo.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "Usuario_Cultivo";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Cultivo
            // 
            this.Cultivo.DataPropertyName = "Cultivo";
            this.Cultivo.HeaderText = "Cultivo";
            this.Cultivo.Name = "Cultivo";
            this.Cultivo.ReadOnly = true;
            this.Cultivo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Plantado
            // 
            this.Plantado.DataPropertyName = "Fecha_Plantado";
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.Plantado.DefaultCellStyle = dataGridViewCellStyle3;
            this.Plantado.HeaderText = "Fecha Plantado";
            this.Plantado.Name = "Plantado";
            this.Plantado.ReadOnly = true;
            // 
            // Cosecha
            // 
            this.Cosecha.DataPropertyName = "Fecha_Cosecha";
            dataGridViewCellStyle4.Format = "D";
            dataGridViewCellStyle4.NullValue = null;
            this.Cosecha.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cosecha.HeaderText = "Fecha Cosecha";
            this.Cosecha.Name = "Cosecha";
            this.Cosecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // txtBuscarUnCultivo
            // 
            this.txtBuscarUnCultivo.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.txtBuscarUnCultivo.Location = new System.Drawing.Point(201, 65);
            this.txtBuscarUnCultivo.Name = "txtBuscarUnCultivo";
            this.txtBuscarUnCultivo.Size = new System.Drawing.Size(232, 33);
            this.txtBuscarUnCultivo.TabIndex = 36;
            this.txtBuscarUnCultivo.TextChanged += new System.EventHandler(this.txtBuscarUnCultivo_TextChanged);
            this.txtBuscarUnCultivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarUnCultivo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label6.Location = new System.Drawing.Point(35, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 39);
            this.label6.TabIndex = 67;
            this.label6.Text = "Administrar cultivos";
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
            this.btnAgregar.Location = new System.Drawing.Point(507, 599);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 40);
            this.btnAgregar.TabIndex = 52;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(164)))), ((int)(((byte)(46)))));
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(157)))), ((int)(((byte)(43)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(329, 599);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(155, 40);
            this.btnEditar.TabIndex = 51;
            this.btnEditar.Text = "Eliminar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 565);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Cantidad (Kgs):";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(539, 562);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 26);
            this.textBox1.TabIndex = 69;
            // 
            // lblDisponible
            // 
            this.lblDisponible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDisponible.AutoSize = true;
            this.lblDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponible.Location = new System.Drawing.Point(682, 565);
            this.lblDisponible.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisponible.Name = "lblDisponible";
            this.lblDisponible.Size = new System.Drawing.Size(87, 20);
            this.lblDisponible.TabIndex = 70;
            this.lblDisponible.Text = "Disponible:";
            // 
            // picCultivo
            // 
            this.picCultivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picCultivo.Image = global::Capa_Presentacion.Properties.Resources.MAÍZFINAL;
            this.picCultivo.Location = new System.Drawing.Point(42, 440);
            this.picCultivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCultivo.Name = "picCultivo";
            this.picCultivo.Size = new System.Drawing.Size(255, 199);
            this.picCultivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCultivo.TabIndex = 32;
            this.picCultivo.TabStop = false;
            // 
            // Cultivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(969, 681);
            this.Controls.Add(this.lblDisponible);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCalcularEstado);
            this.Controls.Add(this.btnCosechar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCultivo);
            this.Controls.Add(this.dtpCosecha);
            this.Controls.Add(this.dtpPlantado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbPlanta);
            this.Controls.Add(this.txtBuscarUnCultivo);
            this.Controls.Add(this.dgvCultivo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cultivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdministrarCultivos2";
            this.Load += new System.EventHandler(this.AdministrarCultivos2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCultivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCultivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarUnCultivo;
        private System.Windows.Forms.PictureBox picCultivo;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCultivo;
        private System.Windows.Forms.ComboBox cbPlanta;
        private System.Windows.Forms.ImageList imageListPlantas;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpCosecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPlantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cultivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plantado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cosecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btnCalcularEstado;
        private System.Windows.Forms.Button btnCosechar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDisponible;
    }
}