namespace PII_2025_II_1P_LABORATORIO1
{
    partial class frmJuegoSemanal
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
            this.lblJuegoSemanal = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblJuegoSemanal
            // 
            this.lblJuegoSemanal.AutoSize = true;
            this.lblJuegoSemanal.Location = new System.Drawing.Point(215, 40);
            this.lblJuegoSemanal.Name = "lblJuegoSemanal";
            this.lblJuegoSemanal.Size = new System.Drawing.Size(80, 13);
            this.lblJuegoSemanal.TabIndex = 13;
            this.lblJuegoSemanal.Text = "Juego Semanal";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(329, 246);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(82, 38);
            this.btnJugar.TabIndex = 12;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(132, 246);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(92, 38);
            this.btnVender.TabIndex = 11;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(239, 123);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(110, 20);
            this.txtNumero1.TabIndex = 10;
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(64, 126);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(160, 13);
            this.lblNumero1.TabIndex = 9;
            this.lblNumero1.Text = "Primer numero a comprar (0-100)";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(187, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(64, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre del comprador:";
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(239, 159);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(110, 20);
            this.txtNumero2.TabIndex = 15;
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(64, 162);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(174, 13);
            this.lblNumero2.TabIndex = 14;
            this.lblNumero2.Text = "Segundo numero a comprar (0-100)";
            // 
            // frmJuegoSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 351);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.lblJuegoSemanal);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmJuegoSemanal";
            this.Text = "JuegoSemanal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblJuegoSemanal;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label lblNumero2;
    }
}