namespace Capa_Presentacion
{
    partial class Gráficos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarPoligono = new System.Windows.Forms.Button();
            this.btnBorrarPoligono = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.datos = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtLati = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.Colores = new System.Windows.Forms.ColorDialog();
            this.pnlBorrarPoligono = new Capa_Presentacion.MyPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPoligonos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDetallesAgregar = new Capa_Presentacion.MyPanel();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.labelFecha1 = new System.Windows.Forms.Label();
            this.btnAgregarTerreno = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombreterreno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcultivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechacosecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtfechaplantado = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.pnlAgregarPoligono = new Capa_Presentacion.MyPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDetallesAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlBorrarPoligono.SuspendLayout();
            this.pnlDetallesAgregar.SuspendLayout();
            this.pnlAgregarPoligono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlBorrarPoligono);
            this.panel1.Controls.Add(this.btnAgregarPoligono);
            this.panel1.Controls.Add(this.pnlDetallesAgregar);
            this.panel1.Controls.Add(this.btnBorrarPoligono);
            this.panel1.Controls.Add(this.pnlAgregarPoligono);
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.datos);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtLati);
            this.panel1.Controls.Add(this.txtLong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(607, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 642);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAgregarPoligono
            // 
            this.btnAgregarPoligono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAgregarPoligono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnAgregarPoligono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPoligono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPoligono.ForeColor = System.Drawing.Color.White;
            this.btnAgregarPoligono.Location = new System.Drawing.Point(106, 28);
            this.btnAgregarPoligono.Name = "btnAgregarPoligono";
            this.btnAgregarPoligono.Size = new System.Drawing.Size(134, 45);
            this.btnAgregarPoligono.TabIndex = 165;
            this.btnAgregarPoligono.Text = "Agregar Polígono";
            this.btnAgregarPoligono.UseVisualStyleBackColor = false;
            this.btnAgregarPoligono.Click += new System.EventHandler(this.btnAgregarPoligono_Click);
            // 
            // btnBorrarPoligono
            // 
            this.btnBorrarPoligono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBorrarPoligono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnBorrarPoligono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPoligono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPoligono.ForeColor = System.Drawing.Color.White;
            this.btnBorrarPoligono.Location = new System.Drawing.Point(106, 79);
            this.btnBorrarPoligono.Name = "btnBorrarPoligono";
            this.btnBorrarPoligono.Size = new System.Drawing.Size(134, 45);
            this.btnBorrarPoligono.TabIndex = 133;
            this.btnBorrarPoligono.Text = "Borrar polígono";
            this.btnBorrarPoligono.UseVisualStyleBackColor = false;
            this.btnBorrarPoligono.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(95, 620);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(25, 20);
            this.txtusuario.TabIndex = 166;
            this.txtusuario.Text = "Admin";
            this.txtusuario.Visible = false;
            // 
            // datos
            // 
            this.datos.AllowUserToAddRows = false;
            this.datos.AllowUserToDeleteRows = false;
            this.datos.AllowUserToOrderColumns = true;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(70, 670);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(171, 26);
            this.datos.TabIndex = 155;
            this.datos.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(82, 702);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(159, 20);
            this.txtDescripcion.TabIndex = 136;
            this.txtDescripcion.Visible = false;
            // 
            // txtLati
            // 
            this.txtLati.Location = new System.Drawing.Point(147, 646);
            this.txtLati.Name = "txtLati";
            this.txtLati.Size = new System.Drawing.Size(123, 20);
            this.txtLati.TabIndex = 135;
            this.txtLati.Visible = false;
            this.txtLati.TextChanged += new System.EventHandler(this.txtLati_TextChanged);
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(20, 646);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(121, 20);
            this.txtLong.TabIndex = 134;
            this.txtLong.Visible = false;
            this.txtLong.TextChanged += new System.EventHandler(this.txtLong_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gMapControl1);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 642);
            this.panel2.TabIndex = 2;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.White;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(607, 642);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDoubleClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::Capa_Presentacion.Properties.Resources.MenuGraficosBlanco;
            this.btnMenu.Location = new System.Drawing.Point(764, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(40, 40);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlBorrarPoligono
            // 
            this.pnlBorrarPoligono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlBorrarPoligono.Controls.Add(this.button4);
            this.pnlBorrarPoligono.Controls.Add(this.button3);
            this.pnlBorrarPoligono.Controls.Add(this.label9);
            this.pnlBorrarPoligono.Controls.Add(this.cbPoligonos);
            this.pnlBorrarPoligono.Controls.Add(this.label8);
            this.pnlBorrarPoligono.Location = new System.Drawing.Point(41, 12);
            this.pnlBorrarPoligono.Name = "pnlBorrarPoligono";
            this.pnlBorrarPoligono.Size = new System.Drawing.Size(271, 204);
            this.pnlBorrarPoligono.TabIndex = 157;
            this.pnlBorrarPoligono.Visible = false;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(73, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 35);
            this.button4.TabIndex = 167;
            this.button4.Text = "Borrar polígono";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(73, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 35);
            this.button3.TabIndex = 166;
            this.button3.Text = "Regresar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(31, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 142;
            this.label9.Text = "Id del polígono:\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPoligonos
            // 
            this.cbPoligonos.FormattingEnabled = true;
            this.cbPoligonos.Location = new System.Drawing.Point(164, 54);
            this.cbPoligonos.Name = "cbPoligonos";
            this.cbPoligonos.Size = new System.Drawing.Size(62, 21);
            this.cbPoligonos.TabIndex = 141;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(64, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 140;
            this.label8.Text = "Borrar polígono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDetallesAgregar
            // 
            this.pnlDetallesAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlDetallesAgregar.Controls.Add(this.txtcantidad);
            this.pnlDetallesAgregar.Controls.Add(this.btnRegresar);
            this.pnlDetallesAgregar.Controls.Add(this.labelFecha1);
            this.pnlDetallesAgregar.Controls.Add(this.btnAgregarTerreno);
            this.pnlDetallesAgregar.Controls.Add(this.txtid);
            this.pnlDetallesAgregar.Controls.Add(this.label2);
            this.pnlDetallesAgregar.Controls.Add(this.txtnombreterreno);
            this.pnlDetallesAgregar.Controls.Add(this.label1);
            this.pnlDetallesAgregar.Controls.Add(this.txtcultivo);
            this.pnlDetallesAgregar.Controls.Add(this.label3);
            this.pnlDetallesAgregar.Controls.Add(this.txtfechacosecha);
            this.pnlDetallesAgregar.Controls.Add(this.label4);
            this.pnlDetallesAgregar.Controls.Add(this.txtfechaplantado);
            this.pnlDetallesAgregar.Controls.Add(this.label5);
            this.pnlDetallesAgregar.Controls.Add(this.label6);
            this.pnlDetallesAgregar.Controls.Add(this.txtEstado);
            this.pnlDetallesAgregar.Controls.Add(this.btnColor);
            this.pnlDetallesAgregar.Location = new System.Drawing.Point(36, 12);
            this.pnlDetallesAgregar.Name = "pnlDetallesAgregar";
            this.pnlDetallesAgregar.Size = new System.Drawing.Size(278, 511);
            this.pnlDetallesAgregar.TabIndex = 167;
            this.pnlDetallesAgregar.Visible = false;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(99, 270);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(73, 20);
            this.txtcantidad.TabIndex = 166;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(6, 452);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(129, 35);
            this.btnRegresar.TabIndex = 165;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // labelFecha1
            // 
            this.labelFecha1.AutoSize = true;
            this.labelFecha1.BackColor = System.Drawing.Color.Transparent;
            this.labelFecha1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha1.ForeColor = System.Drawing.Color.Black;
            this.labelFecha1.Location = new System.Drawing.Point(14, 13);
            this.labelFecha1.Name = "labelFecha1";
            this.labelFecha1.Size = new System.Drawing.Size(110, 23);
            this.labelFecha1.TabIndex = 138;
            this.labelFecha1.Text = "Identificador";
            this.labelFecha1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarTerreno
            // 
            this.btnAgregarTerreno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnAgregarTerreno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTerreno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTerreno.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTerreno.Location = new System.Drawing.Point(141, 452);
            this.btnAgregarTerreno.Name = "btnAgregarTerreno";
            this.btnAgregarTerreno.Size = new System.Drawing.Size(129, 35);
            this.btnAgregarTerreno.TabIndex = 131;
            this.btnAgregarTerreno.Text = "Formar Terreno";
            this.btnAgregarTerreno.UseVisualStyleBackColor = false;
            this.btnAgregarTerreno.Click += new System.EventHandler(this.BtnAgregarTerreno_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(126, 16);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(136, 20);
            this.txtid.TabIndex = 137;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(178, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 164;
            this.label2.Text = "toneladas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnombreterreno
            // 
            this.txtnombreterreno.Location = new System.Drawing.Point(89, 49);
            this.txtnombreterreno.Name = "txtnombreterreno";
            this.txtnombreterreno.Size = new System.Drawing.Size(173, 20);
            this.txtnombreterreno.TabIndex = 139;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 140;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtcultivo
            // 
            this.txtcultivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcultivo.FormattingEnabled = true;
            this.txtcultivo.Items.AddRange(new object[] {
            "Maíz",
            "Sorgo",
            "Soya",
            "Caña",
            "Cebolla"});
            this.txtcultivo.Location = new System.Drawing.Point(19, 111);
            this.txtcultivo.Name = "txtcultivo";
            this.txtcultivo.Size = new System.Drawing.Size(244, 21);
            this.txtcultivo.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 144;
            this.label3.Text = "Cultivo(Tipo)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfechacosecha
            // 
            this.txtfechacosecha.Location = new System.Drawing.Point(18, 231);
            this.txtfechacosecha.Name = "txtfechacosecha";
            this.txtfechacosecha.Size = new System.Drawing.Size(244, 20);
            this.txtfechacosecha.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 146;
            this.label4.Text = "Fecha Plantado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfechaplantado
            // 
            this.txtfechaplantado.Location = new System.Drawing.Point(19, 170);
            this.txtfechaplantado.Name = "txtfechaplantado";
            this.txtfechaplantado.Size = new System.Drawing.Size(244, 20);
            this.txtfechaplantado.TabIndex = 160;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 23);
            this.label5.TabIndex = 148;
            this.label5.Text = "Fecha cosecha";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 150;
            this.label6.Text = "Cantidad";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstado
            // 
            this.txtEstado.AutoSize = true;
            this.txtEstado.BackColor = System.Drawing.Color.Transparent;
            this.txtEstado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.ForeColor = System.Drawing.Color.Black;
            this.txtEstado.Location = new System.Drawing.Point(97, 300);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(62, 23);
            this.txtEstado.TabIndex = 152;
            this.txtEstado.Text = "Estado";
            this.txtEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnColor
            // 
            this.btnColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Location = new System.Drawing.Point(68, 382);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(129, 35);
            this.btnColor.TabIndex = 154;
            this.btnColor.Text = "Elegir color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnlAgregarPoligono
            // 
            this.pnlAgregarPoligono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlAgregarPoligono.Controls.Add(this.button1);
            this.pnlAgregarPoligono.Controls.Add(this.btnDetallesAgregar);
            this.pnlAgregarPoligono.Controls.Add(this.label7);
            this.pnlAgregarPoligono.Controls.Add(this.dataGridView1);
            this.pnlAgregarPoligono.Controls.Add(this.btnAgregar);
            this.pnlAgregarPoligono.Controls.Add(this.btnEditar);
            this.pnlAgregarPoligono.Location = new System.Drawing.Point(41, 12);
            this.pnlAgregarPoligono.Name = "pnlAgregarPoligono";
            this.pnlAgregarPoligono.Size = new System.Drawing.Size(264, 435);
            this.pnlAgregarPoligono.TabIndex = 156;
            this.pnlAgregarPoligono.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 34);
            this.button1.TabIndex = 141;
            this.button1.Text = "Cancelar operación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnDetallesAgregar
            // 
            this.btnDetallesAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetallesAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnDetallesAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetallesAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetallesAgregar.ForeColor = System.Drawing.Color.White;
            this.btnDetallesAgregar.Location = new System.Drawing.Point(138, 393);
            this.btnDetallesAgregar.Name = "btnDetallesAgregar";
            this.btnDetallesAgregar.Size = new System.Drawing.Size(123, 34);
            this.btnDetallesAgregar.TabIndex = 140;
            this.btnDetallesAgregar.Text = "Agregar detalles";
            this.btnDetallesAgregar.UseVisualStyleBackColor = false;
            this.btnDetallesAgregar.Click += new System.EventHandler(this.btnDetallesAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(64, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 23);
            this.label7.TabIndex = 139;
            this.label7.Text = "Agregar puntos";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(250, 297);
            this.dataGridView1.TabIndex = 132;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(63, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 34);
            this.btnAgregar.TabIndex = 130;
            this.btnAgregar.Text = "Agregar punto";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(143)))), ((int)(((byte)(39)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(131, 43);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(123, 34);
            this.btnEditar.TabIndex = 129;
            this.btnEditar.Text = "Remover punto";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Gráficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 642);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Gráficos";
            this.Text = "Gráficos";
            this.Load += new System.EventHandler(this.Gráficos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlBorrarPoligono.ResumeLayout(false);
            this.pnlBorrarPoligono.PerformLayout();
            this.pnlDetallesAgregar.ResumeLayout(false);
            this.pnlDetallesAgregar.PerformLayout();
            this.pnlAgregarPoligono.ResumeLayout(false);
            this.pnlAgregarPoligono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAgregarTerreno;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarPoligono;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtLati;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombreterreno;
        private System.Windows.Forms.Label labelFecha1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtEstado;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog Colores;
        private System.Windows.Forms.DataGridView datos;
        private MyPanel pnlBorrarPoligono;
        private MyPanel pnlAgregarPoligono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtcultivo;
        private System.Windows.Forms.DateTimePicker txtfechacosecha;
        private System.Windows.Forms.DateTimePicker txtfechaplantado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarPoligono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPoligonos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtusuario;
        private MyPanel pnlDetallesAgregar;
        private System.Windows.Forms.Button btnDetallesAgregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.TextBox txtcantidad;
    }
}