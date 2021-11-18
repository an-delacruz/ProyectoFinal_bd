namespace ProyectoFinal_bd_v1.Formularios
{
    partial class CajaPanel
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
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.grbCaja = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkDisponibleCaja = new System.Windows.Forms.CheckBox();
            this.btnEliminarCaja = new System.Windows.Forms.Button();
            this.btnModificarCaja = new System.Windows.Forms.Button();
            this.btnAgregarCaja = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNumeroCaja = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlacasCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.grbCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCaja
            // 
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaja.Location = new System.Drawing.Point(80, 340);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.Size = new System.Drawing.Size(775, 164);
            this.dgvCaja.TabIndex = 19;
            this.dgvCaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaja_CellClick);
            this.dgvCaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaja_CellContentClick);
            // 
            // grbCaja
            // 
            this.grbCaja.Controls.Add(this.panel2);
            this.grbCaja.Controls.Add(this.panel1);
            this.grbCaja.Controls.Add(this.chkDisponibleCaja);
            this.grbCaja.Controls.Add(this.btnEliminarCaja);
            this.grbCaja.Controls.Add(this.btnModificarCaja);
            this.grbCaja.Controls.Add(this.btnAgregarCaja);
            this.grbCaja.Controls.Add(this.label14);
            this.grbCaja.Controls.Add(this.label15);
            this.grbCaja.Controls.Add(this.txtNumeroCaja);
            this.grbCaja.Controls.Add(this.label16);
            this.grbCaja.Controls.Add(this.txtPlacasCaja);
            this.grbCaja.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCaja.ForeColor = System.Drawing.Color.White;
            this.grbCaja.Location = new System.Drawing.Point(148, 74);
            this.grbCaja.Name = "grbCaja";
            this.grbCaja.Size = new System.Drawing.Size(631, 260);
            this.grbCaja.TabIndex = 18;
            this.grbCaja.TabStop = false;
            this.grbCaja.Text = "Caja";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(256, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 1);
            this.panel2.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(256, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 1);
            this.panel1.TabIndex = 37;
            // 
            // chkDisponibleCaja
            // 
            this.chkDisponibleCaja.AutoSize = true;
            this.chkDisponibleCaja.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDisponibleCaja.ForeColor = System.Drawing.Color.Transparent;
            this.chkDisponibleCaja.Location = new System.Drawing.Point(263, 175);
            this.chkDisponibleCaja.Name = "chkDisponibleCaja";
            this.chkDisponibleCaja.Size = new System.Drawing.Size(137, 29);
            this.chkDisponibleCaja.TabIndex = 36;
            this.chkDisponibleCaja.Text = "Disponible";
            this.chkDisponibleCaja.UseVisualStyleBackColor = true;
            this.chkDisponibleCaja.Visible = false;
            // 
            // btnEliminarCaja
            // 
            this.btnEliminarCaja.BackColor = System.Drawing.Color.LightCyan;
            this.btnEliminarCaja.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCaja.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarCaja.Location = new System.Drawing.Point(499, 192);
            this.btnEliminarCaja.Name = "btnEliminarCaja";
            this.btnEliminarCaja.Size = new System.Drawing.Size(109, 41);
            this.btnEliminarCaja.TabIndex = 35;
            this.btnEliminarCaja.Text = "Eliminar";
            this.btnEliminarCaja.UseVisualStyleBackColor = false;
            this.btnEliminarCaja.Click += new System.EventHandler(this.btnEliminarCaja_Click);
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.BackColor = System.Drawing.Color.LightCyan;
            this.btnModificarCaja.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCaja.ForeColor = System.Drawing.Color.Black;
            this.btnModificarCaja.Location = new System.Drawing.Point(499, 119);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(109, 41);
            this.btnModificarCaja.TabIndex = 34;
            this.btnModificarCaja.Text = "Modificar";
            this.btnModificarCaja.UseVisualStyleBackColor = false;
            this.btnModificarCaja.Click += new System.EventHandler(this.btnModificarCaja_Click);
            // 
            // btnAgregarCaja
            // 
            this.btnAgregarCaja.BackColor = System.Drawing.Color.LightCyan;
            this.btnAgregarCaja.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCaja.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCaja.Location = new System.Drawing.Point(499, 46);
            this.btnAgregarCaja.Name = "btnAgregarCaja";
            this.btnAgregarCaja.Size = new System.Drawing.Size(109, 41);
            this.btnAgregarCaja.TabIndex = 33;
            this.btnAgregarCaja.Text = "Agregar";
            this.btnAgregarCaja.UseVisualStyleBackColor = false;
            this.btnAgregarCaja.Click += new System.EventHandler(this.btnAgregarCaja_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(83, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "Placas caja: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(80, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 26;
            this.label15.Text = "Numero Caja:";
            // 
            // txtNumeroCaja
            // 
            this.txtNumeroCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtNumeroCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroCaja.Location = new System.Drawing.Point(256, 121);
            this.txtNumeroCaja.Name = "txtNumeroCaja";
            this.txtNumeroCaja.Size = new System.Drawing.Size(144, 23);
            this.txtNumeroCaja.TabIndex = 29;
            this.txtNumeroCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCaja_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(83, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Disponible:";
            this.label16.Visible = false;
            // 
            // txtPlacasCaja
            // 
            this.txtPlacasCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.txtPlacasCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlacasCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPlacasCaja.Location = new System.Drawing.Point(256, 59);
            this.txtPlacasCaja.Name = "txtPlacasCaja";
            this.txtPlacasCaja.Size = new System.Drawing.Size(144, 23);
            this.txtPlacasCaja.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(376, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 75);
            this.label1.TabIndex = 17;
            this.label1.Text = "CAJA";
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnMenuPrincipal.Image = global::ProyectoFinal_bd_v1.Properties.Resources.house_32;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(934, 12);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(36, 34);
            this.btnMenuPrincipal.TabIndex = 20;
            this.btnMenuPrincipal.TabStop = false;
            this.btnMenuPrincipal.Visible = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // CajaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.dgvCaja);
            this.Controls.Add(this.grbCaja);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CajaPanel";
            this.Text = "CajaPanel";
            this.Load += new System.EventHandler(this.CajaPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.grbCaja.ResumeLayout(false);
            this.grbCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnMenuPrincipal;
        private System.Windows.Forms.DataGridView dgvCaja;
        private System.Windows.Forms.GroupBox grbCaja;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkDisponibleCaja;
        private System.Windows.Forms.Button btnEliminarCaja;
        private System.Windows.Forms.Button btnModificarCaja;
        private System.Windows.Forms.Button btnAgregarCaja;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNumeroCaja;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlacasCaja;
        private System.Windows.Forms.Label label1;
    }
}