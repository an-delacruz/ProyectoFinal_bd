namespace ProyectoFinal_bd_v1.Formularios
{
    partial class RegistrarViajePanel
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
            this.grpViaje = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarViaje = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarViaje = new System.Windows.Forms.Button();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.tabOperador = new System.Windows.Forms.TabControl();
            this.tabOPPERADOR = new System.Windows.Forms.TabPage();
            this.dgvOperadorLista = new System.Windows.Forms.DataGridView();
            this.tabTractor = new System.Windows.Forms.TabPage();
            this.dgvTractorLista = new System.Windows.Forms.DataGridView();
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.dgvCajaLista = new System.Windows.Forms.DataGridView();
            this.grbUnidad = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboOperadores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTractor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCaja = new System.Windows.Forms.ComboBox();
            this.lblClaveOrigen = new System.Windows.Forms.Label();
            this.lblClienteDestino = new System.Windows.Forms.Label();
            this.cboClienteOrigen = new System.Windows.Forms.ComboBox();
            this.cboClienteDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.grpViaje.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.tabOperador.SuspendLayout();
            this.tabOPPERADOR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadorLista)).BeginInit();
            this.tabTractor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTractorLista)).BeginInit();
            this.tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajaLista)).BeginInit();
            this.grbUnidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpViaje
            // 
            this.grpViaje.Controls.Add(this.groupBox1);
            this.grpViaje.Controls.Add(this.dgvViajes);
            this.grpViaje.Controls.Add(this.tabOperador);
            this.grpViaje.Controls.Add(this.grbUnidad);
            this.grpViaje.Controls.Add(this.lblClaveOrigen);
            this.grpViaje.Controls.Add(this.lblClienteDestino);
            this.grpViaje.Controls.Add(this.cboClienteOrigen);
            this.grpViaje.Controls.Add(this.cboClienteDestino);
            this.grpViaje.Controls.Add(this.label2);
            this.grpViaje.Controls.Add(this.lblOrigen);
            this.grpViaje.Controls.Add(this.cboDestino);
            this.grpViaje.Controls.Add(this.cboOrigen);
            this.grpViaje.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViaje.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpViaje.Location = new System.Drawing.Point(13, 21);
            this.grpViaje.Name = "grpViaje";
            this.grpViaje.Size = new System.Drawing.Size(974, 646);
            this.grpViaje.TabIndex = 5;
            this.grpViaje.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarViaje);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminarViaje);
            this.groupBox1.Location = new System.Drawing.Point(16, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 63);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // btnAgregarViaje
            // 
            this.btnAgregarViaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarViaje.Location = new System.Drawing.Point(6, 20);
            this.btnAgregarViaje.Name = "btnAgregarViaje";
            this.btnAgregarViaje.Size = new System.Drawing.Size(100, 34);
            this.btnAgregarViaje.TabIndex = 16;
            this.btnAgregarViaje.Text = "Agregar viaje";
            this.btnAgregarViaje.UseVisualStyleBackColor = true;
            this.btnAgregarViaje.Click += new System.EventHandler(this.btnAgregarViaje_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(82, 60);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 34);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarViaje
            // 
            this.btnEliminarViaje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminarViaje.Location = new System.Drawing.Point(140, 21);
            this.btnEliminarViaje.Name = "btnEliminarViaje";
            this.btnEliminarViaje.Size = new System.Drawing.Size(100, 34);
            this.btnEliminarViaje.TabIndex = 22;
            this.btnEliminarViaje.Text = "Eliminar viaje";
            this.btnEliminarViaje.UseVisualStyleBackColor = true;
            this.btnEliminarViaje.Click += new System.EventHandler(this.btnEliminarViaje_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Location = new System.Drawing.Point(16, 325);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(943, 302);
            this.dgvViajes.TabIndex = 5;
            this.dgvViajes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellClick);
            this.dgvViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViajes_CellContentClick);
            // 
            // tabOperador
            // 
            this.tabOperador.Controls.Add(this.tabOPPERADOR);
            this.tabOperador.Controls.Add(this.tabTractor);
            this.tabOperador.Controls.Add(this.tabCaja);
            this.tabOperador.Location = new System.Drawing.Point(546, 20);
            this.tabOperador.Name = "tabOperador";
            this.tabOperador.SelectedIndex = 0;
            this.tabOperador.Size = new System.Drawing.Size(422, 279);
            this.tabOperador.TabIndex = 6;
            // 
            // tabOPPERADOR
            // 
            this.tabOPPERADOR.Controls.Add(this.dgvOperadorLista);
            this.tabOPPERADOR.Location = new System.Drawing.Point(4, 32);
            this.tabOPPERADOR.Name = "tabOPPERADOR";
            this.tabOPPERADOR.Padding = new System.Windows.Forms.Padding(3);
            this.tabOPPERADOR.Size = new System.Drawing.Size(414, 243);
            this.tabOPPERADOR.TabIndex = 0;
            this.tabOPPERADOR.Text = "Operador";
            this.tabOPPERADOR.UseVisualStyleBackColor = true;
            // 
            // dgvOperadorLista
            // 
            this.dgvOperadorLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperadorLista.Location = new System.Drawing.Point(0, 0);
            this.dgvOperadorLista.Name = "dgvOperadorLista";
            this.dgvOperadorLista.Size = new System.Drawing.Size(409, 253);
            this.dgvOperadorLista.TabIndex = 0;
            // 
            // tabTractor
            // 
            this.tabTractor.Controls.Add(this.dgvTractorLista);
            this.tabTractor.Location = new System.Drawing.Point(4, 32);
            this.tabTractor.Name = "tabTractor";
            this.tabTractor.Padding = new System.Windows.Forms.Padding(3);
            this.tabTractor.Size = new System.Drawing.Size(414, 243);
            this.tabTractor.TabIndex = 1;
            this.tabTractor.Text = "Tractor";
            this.tabTractor.UseVisualStyleBackColor = true;
            // 
            // dgvTractorLista
            // 
            this.dgvTractorLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTractorLista.Location = new System.Drawing.Point(0, 0);
            this.dgvTractorLista.Name = "dgvTractorLista";
            this.dgvTractorLista.Size = new System.Drawing.Size(409, 253);
            this.dgvTractorLista.TabIndex = 1;
            // 
            // tabCaja
            // 
            this.tabCaja.Controls.Add(this.dgvCajaLista);
            this.tabCaja.Location = new System.Drawing.Point(4, 32);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaja.Size = new System.Drawing.Size(414, 243);
            this.tabCaja.TabIndex = 2;
            this.tabCaja.Text = "Caja";
            this.tabCaja.UseVisualStyleBackColor = true;
            // 
            // dgvCajaLista
            // 
            this.dgvCajaLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajaLista.Location = new System.Drawing.Point(0, 0);
            this.dgvCajaLista.Name = "dgvCajaLista";
            this.dgvCajaLista.Size = new System.Drawing.Size(409, 253);
            this.dgvCajaLista.TabIndex = 1;
            // 
            // grbUnidad
            // 
            this.grbUnidad.Controls.Add(this.label4);
            this.grbUnidad.Controls.Add(this.cboOperadores);
            this.grbUnidad.Controls.Add(this.label3);
            this.grbUnidad.Controls.Add(this.cboTractor);
            this.grbUnidad.Controls.Add(this.label1);
            this.grbUnidad.Controls.Add(this.cboCaja);
            this.grbUnidad.ForeColor = System.Drawing.SystemColors.Control;
            this.grbUnidad.Location = new System.Drawing.Point(282, 30);
            this.grbUnidad.Name = "grbUnidad";
            this.grbUnidad.Size = new System.Drawing.Size(253, 212);
            this.grbUnidad.TabIndex = 21;
            this.grbUnidad.TabStop = false;
            this.grbUnidad.Text = "Unidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Operador";
            // 
            // cboOperadores
            // 
            this.cboOperadores.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOperadores.FormattingEnabled = true;
            this.cboOperadores.Location = new System.Drawing.Point(95, 31);
            this.cboOperadores.Name = "cboOperadores";
            this.cboOperadores.Size = new System.Drawing.Size(152, 31);
            this.cboOperadores.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tractor";
            // 
            // cboTractor
            // 
            this.cboTractor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTractor.FormattingEnabled = true;
            this.cboTractor.Location = new System.Drawing.Point(95, 98);
            this.cboTractor.Name = "cboTractor";
            this.cboTractor.Size = new System.Drawing.Size(152, 31);
            this.cboTractor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Caja";
            // 
            // cboCaja
            // 
            this.cboCaja.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaja.FormattingEnabled = true;
            this.cboCaja.Location = new System.Drawing.Point(95, 162);
            this.cboCaja.Name = "cboCaja";
            this.cboCaja.Size = new System.Drawing.Size(152, 31);
            this.cboCaja.TabIndex = 4;
            // 
            // lblClaveOrigen
            // 
            this.lblClaveOrigen.AutoSize = true;
            this.lblClaveOrigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveOrigen.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClaveOrigen.Location = new System.Drawing.Point(23, 24);
            this.lblClaveOrigen.Name = "lblClaveOrigen";
            this.lblClaveOrigen.Size = new System.Drawing.Size(115, 23);
            this.lblClaveOrigen.TabIndex = 20;
            this.lblClaveOrigen.Text = "Cliente origen";
            // 
            // lblClienteDestino
            // 
            this.lblClienteDestino.AutoSize = true;
            this.lblClienteDestino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteDestino.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClienteDestino.Location = new System.Drawing.Point(144, 24);
            this.lblClienteDestino.Name = "lblClienteDestino";
            this.lblClienteDestino.Size = new System.Drawing.Size(124, 23);
            this.lblClienteDestino.TabIndex = 19;
            this.lblClienteDestino.Text = "Cliente destino";
            // 
            // cboClienteOrigen
            // 
            this.cboClienteOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClienteOrigen.FormattingEnabled = true;
            this.cboClienteOrigen.Location = new System.Drawing.Point(18, 61);
            this.cboClienteOrigen.Name = "cboClienteOrigen";
            this.cboClienteOrigen.Size = new System.Drawing.Size(120, 32);
            this.cboClienteOrigen.TabIndex = 18;
            // 
            // cboClienteDestino
            // 
            this.cboClienteDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClienteDestino.FormattingEnabled = true;
            this.cboClienteDestino.Location = new System.Drawing.Point(148, 61);
            this.cboClienteDestino.Name = "cboClienteDestino";
            this.cboClienteDestino.Size = new System.Drawing.Size(120, 32);
            this.cboClienteDestino.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(174, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOrigen.Location = new System.Drawing.Point(53, 107);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(62, 23);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen";
            // 
            // cboDestino
            // 
            this.cboDestino.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(156, 142);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(120, 31);
            this.cboDestino.TabIndex = 1;
            // 
            // cboOrigen
            // 
            this.cboOrigen.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(19, 142);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(131, 31);
            this.cboOrigen.TabIndex = 0;
            // 
            // RegistrarViajePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 688);
            this.Controls.Add(this.grpViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarViajePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarViajePanel";
            this.Load += new System.EventHandler(this.RegistrarViajePanel_Load);
            this.grpViaje.ResumeLayout(false);
            this.grpViaje.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.tabOperador.ResumeLayout(false);
            this.tabOPPERADOR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperadorLista)).EndInit();
            this.tabTractor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTractorLista)).EndInit();
            this.tabCaja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajaLista)).EndInit();
            this.grbUnidad.ResumeLayout(false);
            this.grbUnidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpViaje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarViaje;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarViaje;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.TabControl tabOperador;
        private System.Windows.Forms.TabPage tabOPPERADOR;
        private System.Windows.Forms.DataGridView dgvOperadorLista;
        private System.Windows.Forms.TabPage tabTractor;
        private System.Windows.Forms.DataGridView dgvTractorLista;
        private System.Windows.Forms.TabPage tabCaja;
        private System.Windows.Forms.DataGridView dgvCajaLista;
        private System.Windows.Forms.GroupBox grbUnidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboOperadores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTractor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCaja;
        private System.Windows.Forms.Label lblClaveOrigen;
        private System.Windows.Forms.Label lblClienteDestino;
        private System.Windows.Forms.ComboBox cboClienteOrigen;
        private System.Windows.Forms.ComboBox cboClienteDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.ComboBox cboOrigen;
    }
}