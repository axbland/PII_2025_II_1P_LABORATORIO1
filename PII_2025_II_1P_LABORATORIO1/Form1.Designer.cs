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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblJuegoMensual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(57, 81);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del comprador:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 20);
            this.txtNombre.TabIndex = 1;
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
            this.btnVender.Location = new System.Drawing.Point(118, 191);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(92, 38);
            this.btnVender.TabIndex = 4;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(315, 191);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(82, 38);
            this.btnJugar.TabIndex = 5;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
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
            // frmLoteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 286);
            this.Controls.Add(this.lblJuegoMensual);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmLoteria";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblJuegoMensual;
    }
}

