namespace ProyectoFinal_bd_v1.Formularios
{
    partial class FacturaPanel
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
            this.grbDatosFactura = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabMercancia = new System.Windows.Forms.TabControl();
            this.tabMercanciaFactura = new System.Windows.Forms.TabPage();
            this.grbMercanciaFactura = new System.Windows.Forms.GroupBox();
            this.txtClaveMercancia = new System.Windows.Forms.TextBox();
            this.dgvMercanciaFactura = new System.Windows.Forms.DataGridView();
            this.lblClaveMercancia = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregarMercAFactura = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.tabMercanciaRegistro = new System.Windows.Forms.TabPage();
            this.grpMercancia = new System.Windows.Forms.GroupBox();
            this.dgvRegistroMercancia = new System.Windows.Forms.DataGridView();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtVolumen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcionMercancia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerarFactura = new System.Windows.Forms.Button();
            this.btnAgregarFactura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFlete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboConceptoIva = new System.Windows.Forms.ComboBox();
            this.txtClaveViaje = new System.Windows.Forms.TextBox();
            this.grbDatosFactura.SuspendLayout();
            this.tabMercancia.SuspendLayout();
            this.tabMercanciaFactura.SuspendLayout();
            this.grbMercanciaFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercanciaFactura)).BeginInit();
            this.tabMercanciaRegistro.SuspendLayout();
            this.grpMercancia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroMercancia)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDatosFactura
            // 
            this.grbDatosFactura.BackColor = System.Drawing.Color.Transparent;
            this.grbDatosFactura.Controls.Add(this.panel1);
            this.grbDatosFactura.Controls.Add(this.panel3);
            this.grbDatosFactura.Controls.Add(this.tabMercancia);
            this.grbDatosFactura.Controls.Add(this.btnGenerarFactura);
            this.grbDatosFactura.Controls.Add(this.btnAgregarFactura);
            this.grbDatosFactura.Controls.Add(this.label3);
            this.grbDatosFactura.Controls.Add(this.txtFlete);
            this.grbDatosFactura.Controls.Add(this.label5);
            this.grbDatosFactura.Controls.Add(this.label11);
            this.grbDatosFactura.Controls.Add(this.cboConceptoIva);
            this.grbDatosFactura.Controls.Add(this.txtClaveViaje);
            this.grbDatosFactura.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosFactura.ForeColor = System.Drawing.SystemColors.Control;
            this.grbDatosFactura.Location = new System.Drawing.Point(26, 98);
            this.grbDatosFactura.Name = "grbDatosFactura";
            this.grbDatosFactura.Size = new System.Drawing.Size(924, 537);
            this.grbDatosFactura.TabIndex = 29;
            this.grbDatosFactura.TabStop = false;
            this.grbDatosFactura.Text = "FACTURA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(179, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 1);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(192, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 1);
            this.panel3.TabIndex = 30;
            // 
            // tabMercancia
            // 
            this.tabMercancia.Controls.Add(this.tabMercanciaFactura);
            this.tabMercancia.Controls.Add(this.tabMercanciaRegistro);
            this.tabMercancia.Location = new System.Drawing.Point(67, 240);
            this.tabMercancia.Name = "tabMercancia";
            this.tabMercancia.SelectedIndex = 0;
            this.tabMercancia.Size = new System.Drawing.Size(787, 247);
            this.tabMercancia.TabIndex = 29;
            // 
            // tabMercanciaFactura
            // 
            this.tabMercanciaFactura.Controls.Add(this.grbMercanciaFactura);
            this.tabMercanciaFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabMercanciaFactura.Location = new System.Drawing.Point(4, 31);
            this.tabMercanciaFactura.Name = "tabMercanciaFactura";
            this.tabMercanciaFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabMercanciaFactura.Size = new System.Drawing.Size(779, 212);
            this.tabMercanciaFactura.TabIndex = 0;
            this.tabMercanciaFactura.Text = "Mercancia(Factura)";
            this.tabMercanciaFactura.UseVisualStyleBackColor = true;
            // 
            // grbMercanciaFactura
            // 
            this.grbMercanciaFactura.Controls.Add(this.txtClaveMercancia);
            this.grbMercanciaFactura.Controls.Add(this.dgvMercanciaFactura);
            this.grbMercanciaFactura.Controls.Add(this.lblClaveMercancia);
            this.grbMercanciaFactura.Controls.Add(this.label8);
            this.grbMercanciaFactura.Controls.Add(this.btnAgregarMercAFactura);
            this.grbMercanciaFactura.Controls.Add(this.txtCantidad);
            this.grbMercanciaFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbMercanciaFactura.Location = new System.Drawing.Point(6, 6);
            this.grbMercanciaFactura.Name = "grbMercanciaFactura";
            this.grbMercanciaFactura.Size = new System.Drawing.Size(757, 193);
            this.grbMercanciaFactura.TabIndex = 30;
            this.grbMercanciaFactura.TabStop = false;
            // 
            // txtClaveMercancia
            // 
            this.txtClaveMercancia.Location = new System.Drawing.Point(66, 42);
            this.txtClaveMercancia.Name = "txtClaveMercancia";
            this.txtClaveMercancia.Size = new System.Drawing.Size(100, 30);
            this.txtClaveMercancia.TabIndex = 17;
            this.txtClaveMercancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveMercancia_KeyPress);
            // 
            // dgvMercanciaFactura
            // 
            this.dgvMercanciaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMercanciaFactura.Location = new System.Drawing.Point(191, 17);
            this.dgvMercanciaFactura.Name = "dgvMercanciaFactura";
            this.dgvMercanciaFactura.Size = new System.Drawing.Size(560, 170);
            this.dgvMercanciaFactura.TabIndex = 15;
            // 
            // lblClaveMercancia
            // 
            this.lblClaveMercancia.AutoSize = true;
            this.lblClaveMercancia.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblClaveMercancia.Location = new System.Drawing.Point(38, 17);
            this.lblClaveMercancia.Name = "lblClaveMercancia";
            this.lblClaveMercancia.Size = new System.Drawing.Size(147, 22);
            this.lblClaveMercancia.TabIndex = 16;
            this.lblClaveMercancia.Text = "Clave Mercancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(70, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cantidad";
            // 
            // btnAgregarMercAFactura
            // 
            this.btnAgregarMercAFactura.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAgregarMercAFactura.Location = new System.Drawing.Point(70, 136);
            this.btnAgregarMercAFactura.Name = "btnAgregarMercAFactura";
            this.btnAgregarMercAFactura.Size = new System.Drawing.Size(92, 33);
            this.btnAgregarMercAFactura.TabIndex = 18;
            this.btnAgregarMercAFactura.Text = "Agregar";
            this.btnAgregarMercAFactura.UseVisualStyleBackColor = true;
            this.btnAgregarMercAFactura.Click += new System.EventHandler(this.btnAgregarMercAFactura_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(66, 100);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 30);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // tabMercanciaRegistro
            // 
            this.tabMercanciaRegistro.Controls.Add(this.grpMercancia);
            this.tabMercanciaRegistro.Location = new System.Drawing.Point(4, 31);
            this.tabMercanciaRegistro.Name = "tabMercanciaRegistro";
            this.tabMercanciaRegistro.Padding = new System.Windows.Forms.Padding(3);
            this.tabMercanciaRegistro.Size = new System.Drawing.Size(779, 212);
            this.tabMercanciaRegistro.TabIndex = 1;
            this.tabMercanciaRegistro.Text = "Mercancia(Registro)";
            this.tabMercanciaRegistro.UseVisualStyleBackColor = true;
            // 
            // grpMercancia
            // 
            this.grpMercancia.Controls.Add(this.dgvRegistroMercancia);
            this.grpMercancia.Controls.Add(this.cmbUnidadMedida);
            this.grpMercancia.Controls.Add(this.btnAgregar);
            this.grpMercancia.Controls.Add(this.txtPrecioUnitario);
            this.grpMercancia.Controls.Add(this.label12);
            this.grpMercancia.Controls.Add(this.label10);
            this.grpMercancia.Controls.Add(this.txtVolumen);
            this.grpMercancia.Controls.Add(this.label9);
            this.grpMercancia.Controls.Add(this.txtPeso);
            this.grpMercancia.Controls.Add(this.label1);
            this.grpMercancia.Controls.Add(this.txtDescripcionMercancia);
            this.grpMercancia.Controls.Add(this.label7);
            this.grpMercancia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpMercancia.Location = new System.Drawing.Point(6, 9);
            this.grpMercancia.Name = "grpMercancia";
            this.grpMercancia.Size = new System.Drawing.Size(757, 193);
            this.grpMercancia.TabIndex = 17;
            this.grpMercancia.TabStop = false;
            this.grpMercancia.Text = "Mercancia";
            // 
            // dgvRegistroMercancia
            // 
            this.dgvRegistroMercancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroMercancia.Location = new System.Drawing.Point(333, 19);
            this.dgvRegistroMercancia.Name = "dgvRegistroMercancia";
            this.dgvRegistroMercancia.Size = new System.Drawing.Size(418, 168);
            this.dgvRegistroMercancia.TabIndex = 28;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Items.AddRange(new object[] {
            "Mililitros",
            "Litros",
            "Gramos",
            "Kilogramos"});
            this.cmbUnidadMedida.Location = new System.Drawing.Point(174, 115);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(104, 30);
            this.cmbUnidadMedida.TabIndex = 27;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAgregar.Location = new System.Drawing.Point(218, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 31);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Location = new System.Drawing.Point(145, 154);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(104, 30);
            this.txtPrecioUnitario.TabIndex = 25;
            this.txtPrecioUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioUnitario_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(12, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Precio unitario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(12, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 22);
            this.label10.TabIndex = 20;
            this.label10.Text = "Unidad de medida: ";
            // 
            // txtVolumen
            // 
            this.txtVolumen.Location = new System.Drawing.Point(102, 82);
            this.txtVolumen.Name = "txtVolumen";
            this.txtVolumen.Size = new System.Drawing.Size(57, 30);
            this.txtVolumen.TabIndex = 19;
            this.txtVolumen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVolumen_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(12, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Volumen: ";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(60, 51);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(55, 30);
            this.txtPeso.TabIndex = 17;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Peso:";
            // 
            // txtDescripcionMercancia
            // 
            this.txtDescripcionMercancia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcionMercancia.Location = new System.Drawing.Point(121, 23);
            this.txtDescripcionMercancia.Name = "txtDescripcionMercancia";
            this.txtDescripcionMercancia.Size = new System.Drawing.Size(128, 30);
            this.txtDescripcionMercancia.TabIndex = 15;
            this.txtDescripcionMercancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcionMercancia_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Descripcion: ";
            // 
            // btnGenerarFactura
            // 
            this.btnGenerarFactura.BackColor = System.Drawing.Color.LightCyan;
            this.btnGenerarFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarFactura.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGenerarFactura.Location = new System.Drawing.Point(591, 166);
            this.btnGenerarFactura.Name = "btnGenerarFactura";
            this.btnGenerarFactura.Size = new System.Drawing.Size(102, 55);
            this.btnGenerarFactura.TabIndex = 28;
            this.btnGenerarFactura.Text = "Generar factura";
            this.btnGenerarFactura.UseVisualStyleBackColor = false;
            this.btnGenerarFactura.Click += new System.EventHandler(this.btnGenerarFactura_Click);
            // 
            // btnAgregarFactura
            // 
            this.btnAgregarFactura.BackColor = System.Drawing.Color.LightCyan;
            this.btnAgregarFactura.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFactura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregarFactura.Location = new System.Drawing.Point(591, 102);
            this.btnAgregarFactura.Name = "btnAgregarFactura";
            this.btnAgregarFactura.Size = new System.Drawing.Size(102, 37);
            this.btnAgregarFactura.TabIndex = 27;
            this.btnAgregarFactura.Text = "Agregar";
            this.btnAgregarFactura.UseVisualStyleBackColor = false;
            this.btnAgregarFactura.Click += new System.EventHandler(this.btnAgregarFactura_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(383, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Iva:";
            // 
            // txtFlete
            // 
            this.txtFlete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFlete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlete.ForeColor = System.Drawing.SystemColors.Control;
            this.txtFlete.Location = new System.Drawing.Point(179, 141);
            this.txtFlete.Name = "txtFlete";
            this.txtFlete.Size = new System.Drawing.Size(100, 24);
            this.txtFlete.TabIndex = 23;
            this.txtFlete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlete_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Clave viaje:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(114, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Flete: ";
            // 
            // cboConceptoIva
            // 
            this.cboConceptoIva.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboConceptoIva.FormattingEnabled = true;
            this.cboConceptoIva.Location = new System.Drawing.Point(430, 106);
            this.cboConceptoIva.Name = "cboConceptoIva";
            this.cboConceptoIva.Size = new System.Drawing.Size(134, 31);
            this.cboConceptoIva.TabIndex = 10;
            // 
            // txtClaveViaje
            // 
            this.txtClaveViaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtClaveViaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClaveViaje.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveViaje.ForeColor = System.Drawing.SystemColors.Control;
            this.txtClaveViaje.Location = new System.Drawing.Point(192, 104);
            this.txtClaveViaje.Name = "txtClaveViaje";
            this.txtClaveViaje.Size = new System.Drawing.Size(134, 24);
            this.txtClaveViaje.TabIndex = 11;
            this.txtClaveViaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClaveViaje_KeyPress);
            // 
            // FacturaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 688);
            this.Controls.Add(this.grbDatosFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FacturaPanel";
            this.Text = "FacturaPanel";
            this.Load += new System.EventHandler(this.FacturaPanel_Load);
            this.grbDatosFactura.ResumeLayout(false);
            this.grbDatosFactura.PerformLayout();
            this.tabMercancia.ResumeLayout(false);
            this.tabMercanciaFactura.ResumeLayout(false);
            this.grbMercanciaFactura.ResumeLayout(false);
            this.grbMercanciaFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMercanciaFactura)).EndInit();
            this.tabMercanciaRegistro.ResumeLayout(false);
            this.grpMercancia.ResumeLayout(false);
            this.grpMercancia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroMercancia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabMercancia;
        private System.Windows.Forms.TabPage tabMercanciaFactura;
        private System.Windows.Forms.GroupBox grbMercanciaFactura;
        private System.Windows.Forms.TextBox txtClaveMercancia;
        private System.Windows.Forms.DataGridView dgvMercanciaFactura;
        private System.Windows.Forms.Label lblClaveMercancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregarMercAFactura;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TabPage tabMercanciaRegistro;
        private System.Windows.Forms.GroupBox grpMercancia;
        private System.Windows.Forms.DataGridView dgvRegistroMercancia;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtVolumen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcionMercancia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerarFactura;
        private System.Windows.Forms.Button btnAgregarFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFlete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboConceptoIva;
        private System.Windows.Forms.TextBox txtClaveViaje;
    }
}