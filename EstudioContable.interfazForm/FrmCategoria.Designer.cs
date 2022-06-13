namespace EstudioContable.interfazForm
{
    partial class FrmCategoria
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
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtSueldoBasico = new System.Windows.Forms.TextBox();
            this._txtConvenio = new System.Windows.Forms.TextBox();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblSueldoBasico = new System.Windows.Forms.Label();
            this._btnConsultaCategoria = new System.Windows.Forms.Button();
            this._btnAltaCategoria = new System.Windows.Forms.Button();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(125, 12);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 20);
            this._txtId.TabIndex = 0;
            // 
            // _txtSueldoBasico
            // 
            this._txtSueldoBasico.Location = new System.Drawing.Point(125, 172);
            this._txtSueldoBasico.Name = "_txtSueldoBasico";
            this._txtSueldoBasico.Size = new System.Drawing.Size(100, 20);
            this._txtSueldoBasico.TabIndex = 1;
            // 
            // _txtConvenio
            // 
            this._txtConvenio.Location = new System.Drawing.Point(125, 110);
            this._txtConvenio.Name = "_txtConvenio";
            this._txtConvenio.Size = new System.Drawing.Size(100, 20);
            this._txtConvenio.TabIndex = 2;
            // 
            // _txtNombre
            // 
            this._txtNombre.Location = new System.Drawing.Point(125, 56);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(100, 20);
            this._txtNombre.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(49, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Id";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 59);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(41, 117);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(52, 13);
            this.lblConvenio.TabIndex = 6;
            this.lblConvenio.Text = "Convenio";
            // 
            // lblSueldoBasico
            // 
            this.lblSueldoBasico.AutoSize = true;
            this.lblSueldoBasico.Location = new System.Drawing.Point(26, 179);
            this.lblSueldoBasico.Name = "lblSueldoBasico";
            this.lblSueldoBasico.Size = new System.Drawing.Size(75, 13);
            this.lblSueldoBasico.TabIndex = 7;
            this.lblSueldoBasico.Text = "Sueldo Básico";
            // 
            // _btnConsultaCategoria
            // 
            this._btnConsultaCategoria.Location = new System.Drawing.Point(281, 9);
            this._btnConsultaCategoria.Name = "_btnConsultaCategoria";
            this._btnConsultaCategoria.Size = new System.Drawing.Size(121, 23);
            this._btnConsultaCategoria.TabIndex = 8;
            this._btnConsultaCategoria.Text = "Consulta Categoría";
            this._btnConsultaCategoria.UseVisualStyleBackColor = true;
            this._btnConsultaCategoria.Click += new System.EventHandler(this._btnConsultaCategoria_Click);
            // 
            // _btnAltaCategoria
            // 
            this._btnAltaCategoria.Location = new System.Drawing.Point(281, 107);
            this._btnAltaCategoria.Name = "_btnAltaCategoria";
            this._btnAltaCategoria.Size = new System.Drawing.Size(121, 23);
            this._btnAltaCategoria.TabIndex = 9;
            this._btnAltaCategoria.Text = "Alta Categoría";
            this._btnAltaCategoria.UseVisualStyleBackColor = true;
            this._btnAltaCategoria.Click += new System.EventHandler(this._btnAltaCategoria_Click);
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(399, 210);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(37, 13);
            this.lblVolver.TabIndex = 10;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkVolver_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 241);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this._btnAltaCategoria);
            this.Controls.Add(this._btnConsultaCategoria);
            this.Controls.Add(this.lblSueldoBasico);
            this.Controls.Add(this.lblConvenio);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._txtConvenio);
            this.Controls.Add(this._txtSueldoBasico);
            this.Controls.Add(this._txtId);
            this.Name = "FrmCategoria";
            this.Text = "Categoría";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtSueldoBasico;
        private System.Windows.Forms.TextBox _txtConvenio;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Label lblSueldoBasico;
        private System.Windows.Forms.Button _btnConsultaCategoria;
        private System.Windows.Forms.Button _btnAltaCategoria;
        private System.Windows.Forms.LinkLabel lblVolver;
    }
}