namespace ProyectoFinal_bd_v1.Formularios
{
    partial class Administrador
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
            this.pnlSuperiorFondo = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportesViajes = new System.Windows.Forms.Button();
            this.btnRegistroUnidades = new System.Windows.Forms.Button();
            this.btnRegistroCliente = new System.Windows.Forms.Button();
            this.pnlSuperiorFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperiorFondo
            // 
            this.pnlSuperiorFondo.BackgroundImage = global::ProyectoFinal_bd_v1.Properties.Resources.fondo___copia1;
            this.pnlSuperiorFondo.Controls.Add(this.btnRegresar);
            this.pnlSuperiorFondo.Controls.Add(this.btnSalir);
            this.pnlSuperiorFondo.Controls.Add(this.label1);
            this.pnlSuperiorFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperiorFondo.Name = "pnlSuperiorFondo";
            this.pnlSuperiorFondo.Size = new System.Drawing.Size(262, 60);
            this.pnlSuperiorFondo.TabIndex = 10;
            this.pnlSuperiorFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlSuperiorFondo_MouseDown);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.Image = global::ProyectoFinal_bd_v1.Properties.Resources.descarga__2__removebg_preview;
            this.btnRegresar.Location = new System.Drawing.Point(0, 0);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(35, 31);
            this.btnRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRegresar.TabIndex = 6;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Image = global::ProyectoFinal_bd_v1.Properties.Resources.cerrar;
            this.btnSalir.Location = new System.Drawing.Point(227, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // btnReportesViajes
            // 
            this.btnReportesViajes.BackColor = System.Drawing.Color.Teal;
            this.btnReportesViajes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnReportesViajes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesViajes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesViajes.Image = global::ProyectoFinal_bd_v1.Properties.Resources.reportes;
            this.btnReportesViajes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportesViajes.Location = new System.Drawing.Point(57, 220);
            this.btnReportesViajes.Name = "btnReportesViajes";
            this.btnReportesViajes.Size = new System.Drawing.Size(160, 60);
            this.btnReportesViajes.TabIndex = 9;
            this.btnReportesViajes.Text = "Reportes Viajes";
            this.btnReportesViajes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportesViajes.UseVisualStyleBackColor = false;
            this.btnReportesViajes.Click += new System.EventHandler(this.btnReportesViajes_Click);
            // 
            // btnRegistroUnidades
            // 
            this.btnRegistroUnidades.BackColor = System.Drawing.Color.Teal;
            this.btnRegistroUnidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistroUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroUnidades.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroUnidades.Image = global::ProyectoFinal_bd_v1.Properties.Resources.compras;
            this.btnRegistroUnidades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroUnidades.Location = new System.Drawing.Point(57, 154);
            this.btnRegistroUnidades.Name = "btnRegistroUnidades";
            this.btnRegistroUnidades.Size = new System.Drawing.Size(160, 60);
            this.btnRegistroUnidades.TabIndex = 7;
            this.btnRegistroUnidades.Text = "Registro Unidades";
            this.btnRegistroUnidades.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroUnidades.UseVisualStyleBackColor = false;
            this.btnRegistroUnidades.Click += new System.EventHandler(this.btnRegistroUnidades_Click);
            // 
            // btnRegistroCliente
            // 
            this.btnRegistroCliente.BackColor = System.Drawing.Color.Teal;
            this.btnRegistroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnRegistroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroCliente.Image = global::ProyectoFinal_bd_v1.Properties.Resources.clientes;
            this.btnRegistroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroCliente.Location = new System.Drawing.Point(57, 88);
            this.btnRegistroCliente.Name = "btnRegistroCliente";
            this.btnRegistroCliente.Size = new System.Drawing.Size(160, 60);
            this.btnRegistroCliente.TabIndex = 6;
            this.btnRegistroCliente.Text = "Registro Cliente";
            this.btnRegistroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistroCliente.UseVisualStyleBackColor = false;
            this.btnRegistroCliente.Click += new System.EventHandler(this.btnRegistroCliente_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_bd_v1.Properties.Resources.hermoso_fondo_degradado_blanco_108128_131;
            this.ClientSize = new System.Drawing.Size(259, 357);
            this.Controls.Add(this.pnlSuperiorFondo);
            this.Controls.Add(this.btnReportesViajes);
            this.Controls.Add(this.btnRegistroUnidades);
            this.Controls.Add(this.btnRegistroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.pnlSuperiorFondo.ResumeLayout(false);
            this.pnlSuperiorFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperiorFondo;
        private System.Windows.Forms.PictureBox btnRegresar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReportesViajes;
        private System.Windows.Forms.Button btnRegistroUnidades;
        private System.Windows.Forms.Button btnRegistroCliente;
    }
}