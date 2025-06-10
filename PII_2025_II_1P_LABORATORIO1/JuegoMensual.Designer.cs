namespace PII_2025_II_1P_LABORATORIO1
{
    partial class frmLoteria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombreD = new System.Windows.Forms.Label();
            this.txtNombreD = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnVenderD = new System.Windows.Forms.Button();
            this.btnJugarD = new System.Windows.Forms.Button();
            this.lblJuegoMensual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombreD.AutoSize = true;
            this.lblNombreD.Location = new System.Drawing.Point(57, 81);
            this.lblNombreD.Name = "lblNombre";
            this.lblNombreD.Size = new System.Drawing.Size(117, 13);
            this.lblNombreD.TabIndex = 0;
            this.lblNombreD.Text = "Nombre del comprador:";
            // 
            // txtNombre
            // 
            this.txtNombreD.Location = new System.Drawing.Point(180, 78);
            this.txtNombreD.Name = "txtNombre";
            this.txtNombreD.Size = new System.Drawing.Size(284, 20);
            this.txtNombreD.TabIndex = 1;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(57, 128);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(130, 13);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Numero a comprar (0-100)";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(193, 125);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(110, 20);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // btnVender
            // 
            this.btnVenderD.Location = new System.Drawing.Point(118, 191);
            this.btnVenderD.Name = "btnVender";
            this.btnVenderD.Size = new System.Drawing.Size(92, 38);
            this.btnVenderD.TabIndex = 4;
            this.btnVenderD.Text = "Vender";
            this.btnVenderD.UseVisualStyleBackColor = true;
            this.btnVenderD.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnJugar
            // 
            this.btnJugarD.Location = new System.Drawing.Point(315, 191);
            this.btnJugarD.Name = "btnJugar";
            this.btnJugarD.Size = new System.Drawing.Size(82, 38);
            this.btnJugarD.TabIndex = 5;
            this.btnJugarD.Text = "Jugar";
            this.btnJugarD.UseVisualStyleBackColor = true;
            this.btnJugarD.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblJuegoMensual
            // 
            this.lblJuegoMensual.AutoSize = true;
            this.lblJuegoMensual.Location = new System.Drawing.Point(208, 42);
            this.lblJuegoMensual.Name = "lblJuegoMensual";
            this.lblJuegoMensual.Size = new System.Drawing.Size(79, 13);
            this.lblJuegoMensual.TabIndex = 6;
            this.lblJuegoMensual.Text = "Juego Mensual";
            this.lblJuegoMensual.Click += new System.EventHandler(this.lblJuegoMensual_Click);
            // 
            // frmJuegoMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.lblJuegoMensual);
            this.Controls.Add(this.btnJugarD);
            this.Controls.Add(this.btnVenderD);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNombreD);
            this.Controls.Add(this.lblNombreD);
            this.Name = "frmJuegoMensual";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreD;
        private System.Windows.Forms.TextBox txtNombreD;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVenderD;
        private System.Windows.Forms.Button btnJugarD;
        private System.Windows.Forms.Label lblJuegoMensual;
    }
}

