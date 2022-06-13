namespace EstudioContable.interfazForm
{
    partial class FrmReporteEmpleados
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
            this.txtReporteEmpleados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtReporteEmpleados
            // 
            this.txtReporteEmpleados.Enabled = false;
            this.txtReporteEmpleados.Location = new System.Drawing.Point(112, 89);
            this.txtReporteEmpleados.Name = "txtReporteEmpleados";
            this.txtReporteEmpleados.Size = new System.Drawing.Size(280, 20);
            this.txtReporteEmpleados.TabIndex = 0;
            // 
            // FrmReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReporteEmpleados);
            this.Name = "FrmReporteEmpleados";
            this.Text = "FrmReporteEmpleados";
            this.Load += new System.EventHandler(this.FrmReporteEmpleados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReporteEmpleados;
    }
}