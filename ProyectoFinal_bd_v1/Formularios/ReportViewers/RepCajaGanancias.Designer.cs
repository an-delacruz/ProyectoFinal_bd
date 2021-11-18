namespace ProyectoFinal_bd_v1.Formularios.ReportViewers
{
    partial class RepCajaGanancias
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
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.btnRegresar = new System.Windows.Forms.PictureBox();
            this.crvCajaGanancias = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlSuperior.Controls.Add(this.btnRegresar);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(790, 100);
            this.pnlSuperior.TabIndex = 1;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::ProyectoFinal_bd_v1.Properties.Resources.descarga__2__removebg_preview1;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(21, 44);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(42, 30);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.TabStop = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // crvCajaGanancias
            // 
            this.crvCajaGanancias.ActiveViewIndex = -1;
            this.crvCajaGanancias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCajaGanancias.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCajaGanancias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCajaGanancias.Location = new System.Drawing.Point(0, 100);
            this.crvCajaGanancias.Name = "crvCajaGanancias";
            this.crvCajaGanancias.Size = new System.Drawing.Size(790, 480);
            this.crvCajaGanancias.TabIndex = 2;
            // 
            // RepCajaGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 580);
            this.Controls.Add(this.crvCajaGanancias);
            this.Controls.Add(this.pnlSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepCajaGanancias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepCajaGanancias";
            this.Load += new System.EventHandler(this.RepCajaGanancias_Load);
            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegresar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox btnRegresar;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvCajaGanancias;
    }
}