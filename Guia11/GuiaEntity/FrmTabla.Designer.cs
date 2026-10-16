namespace GuiaEntity
{
    partial class FrmTabla
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // Labels
            //
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(40, 40);
            this.Label1.Name = "Label1";
            this.Label1.Text = "ID";
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(40, 80);
            this.Label2.Name = "Label2";
            this.Label2.Text = "Nombre:";
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(40, 120);
            this.Label3.Name = "Label3";
            this.Label3.Text = "Correo:";
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(40, 160);
            this.Label4.Name = "Label4";
            this.Label4.Text = "Fecha de nacimiento:";
            //
            // Cajas de texto y fecha
            //
            this.TxtId.Location = new System.Drawing.Point(200, 37);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtNombre.Location = new System.Drawing.Point(200, 77);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(180, 20);
            this.TxtCorreo.Location = new System.Drawing.Point(200, 117);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(180, 20);
            this.DtpFecha.Location = new System.Drawing.Point(200, 157);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            //
            // BtnGuardar
            //
            this.BtnGuardar.Location = new System.Drawing.Point(300, 215);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(90, 28);
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            //
            // FrmTabla
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 270);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.BtnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Datos de persona";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Button BtnGuardar;
    }
}
