namespace ProyectoFinal_bd_v1.Formularios
{
    partial class TerminarViajePanel
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
            this.dgvViajesEnProceso = new System.Windows.Forms.DataGridView();
            this.grpViajeTerminado = new System.Windows.Forms.GroupBox();
            this.btnTerminarViaje = new System.Windows.Forms.Button();
            this.txtIdViaje = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesEnProceso)).BeginInit();
            this.grpViajeTerminado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvViajesEnProceso
            // 
            this.dgvViajesEnProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajesEnProceso.Location = new System.Drawing.Point(83, 349);
            this.dgvViajesEnProceso.Name = "dgvViajesEnProceso";
            this.dgvViajesEnProceso.Size = new System.Drawing.Size(835, 232);
            this.dgvViajesEnProceso.TabIndex = 8;
            // 
            // grpViajeTerminado
            // 
            this.grpViajeTerminado.Controls.Add(this.btnTerminarViaje);
            this.grpViajeTerminado.Controls.Add(this.txtIdViaje);
            this.grpViajeTerminado.Controls.Add(this.label5);
            this.grpViajeTerminado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpViajeTerminado.ForeColor = System.Drawing.Color.White;
            this.grpViajeTerminado.Location = new System.Drawing.Point(83, 107);
            this.grpViajeTerminado.Name = "grpViajeTerminado";
            this.grpViajeTerminado.Size = new System.Drawing.Size(835, 224);
            this.grpViajeTerminado.TabIndex = 7;
            this.grpViajeTerminado.TabStop = false;
            this.grpViajeTerminado.Text = "Terminar viaje";
            // 
            // btnTerminarViaje
            // 
            this.btnTerminarViaje.ForeColor = System.Drawing.Color.Black;
            this.btnTerminarViaje.Location = new System.Drawing.Point(337, 140);
            this.btnTerminarViaje.Name = "btnTerminarViaje";
            this.btnTerminarViaje.Size = new System.Drawing.Size(132, 49);
            this.btnTerminarViaje.TabIndex = 4;
            this.btnTerminarViaje.Text = "Terminar viaje";
            this.btnTerminarViaje.UseVisualStyleBackColor = true;
            this.btnTerminarViaje.Click += new System.EventHandler(this.btnTerminarViaje_Click);
            // 
            // txtIdViaje
            // 
            this.txtIdViaje.Location = new System.Drawing.Point(423, 66);
            this.txtIdViaje.Name = "txtIdViaje";
            this.txtIdViaje.Size = new System.Drawing.Size(100, 31);
            this.txtIdViaje.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(268, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Clave del viaje";
            // 
            // TerminarViajePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1000, 688);
            this.Controls.Add(this.dgvViajesEnProceso);
            this.Controls.Add(this.grpViajeTerminado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TerminarViajePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerminarViajePanel";
            this.Load += new System.EventHandler(this.TerminarViajePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajesEnProceso)).EndInit();
            this.grpViajeTerminado.ResumeLayout(false);
            this.grpViajeTerminado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViajesEnProceso;
        private System.Windows.Forms.GroupBox grpViajeTerminado;
        private System.Windows.Forms.Button btnTerminarViaje;
        private System.Windows.Forms.TextBox txtIdViaje;
        private System.Windows.Forms.Label label5;
    }
}