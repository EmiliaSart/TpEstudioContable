namespace EstudioContable.interfazForm
{
    partial class FrmEmpresa
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
            this._btnConsultaEmpresa = new System.Windows.Forms.Button();
            this._txtRazonSocial = new System.Windows.Forms.TextBox();
            this._txtCuit = new System.Windows.Forms.TextBox();
            this._txtDomicilio = new System.Windows.Forms.TextBox();
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtId = new System.Windows.Forms.TextBox();
            this._txtUsuario = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this._btnAltaEmpresa = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _btnConsultaEmpresa
            // 
            this._btnConsultaEmpresa.Location = new System.Drawing.Point(268, 14);
            this._btnConsultaEmpresa.Name = "_btnConsultaEmpresa";
            this._btnConsultaEmpresa.Size = new System.Drawing.Size(146, 34);
            this._btnConsultaEmpresa.TabIndex = 0;
            this._btnConsultaEmpresa.Text = "Consulta Empresa";
            this._btnConsultaEmpresa.UseVisualStyleBackColor = true;
            this._btnConsultaEmpresa.Click += new System.EventHandler(this._btnConsultaEmpresa_Click);
            // 
            // _txtRazonSocial
            // 
            this._txtRazonSocial.Location = new System.Drawing.Point(104, 50);
            this._txtRazonSocial.Name = "_txtRazonSocial";
            this._txtRazonSocial.Size = new System.Drawing.Size(100, 20);
            this._txtRazonSocial.TabIndex = 1;
            // 
            // _txtCuit
            // 
            this._txtCuit.Location = new System.Drawing.Point(104, 93);
            this._txtCuit.Name = "_txtCuit";
            this._txtCuit.Size = new System.Drawing.Size(100, 20);
            this._txtCuit.TabIndex = 2;
            // 
            // _txtDomicilio
            // 
            this._txtDomicilio.Location = new System.Drawing.Point(104, 132);
            this._txtDomicilio.Name = "_txtDomicilio";
            this._txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this._txtDomicilio.TabIndex = 3;
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(104, 174);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(100, 20);
            this._txtFechaAlta.TabIndex = 4;
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(104, 17);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 20);
            this._txtId.TabIndex = 5;
            // 
            // _txtUsuario
            // 
            this._txtUsuario.Location = new System.Drawing.Point(104, 228);
            this._txtUsuario.Name = "_txtUsuario";
            this._txtUsuario.Size = new System.Drawing.Size(100, 20);
            this._txtUsuario.TabIndex = 6;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(24, 57);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 7;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(33, 96);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(25, 13);
            this.lblCuit.TabIndex = 8;
            this.lblCuit.Text = "Cuit";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(33, 135);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 9;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(24, 181);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 13);
            this.lblFechaAlta.TabIndex = 10;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(66, 20);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(33, 231);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usuario";
            // 
            // _btnAltaEmpresa
            // 
            this._btnAltaEmpresa.Location = new System.Drawing.Point(268, 125);
            this._btnAltaEmpresa.Name = "_btnAltaEmpresa";
            this._btnAltaEmpresa.Size = new System.Drawing.Size(146, 27);
            this._btnAltaEmpresa.TabIndex = 13;
            this._btnAltaEmpresa.Text = "Alta Empresa";
            this._btnAltaEmpresa.UseVisualStyleBackColor = true;
            this._btnAltaEmpresa.Click += new System.EventHandler(this._btnAltaEmpresa_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.AutoSize = true;
            this._btnVolver.Location = new System.Drawing.Point(428, 228);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(37, 13);
            this._btnVolver.TabIndex = 14;
            this._btnVolver.TabStop = true;
            this._btnVolver.Text = "Volver";
            this._btnVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._btnVolver_LinkClicked);
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 260);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAltaEmpresa);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this._txtUsuario);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._txtFechaAlta);
            this.Controls.Add(this._txtDomicilio);
            this.Controls.Add(this._txtCuit);
            this.Controls.Add(this._txtRazonSocial);
            this.Controls.Add(this._btnConsultaEmpresa);
            this.Name = "FrmEmpresa";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConsultaEmpresa;
        private System.Windows.Forms.TextBox _txtRazonSocial;
        private System.Windows.Forms.TextBox _txtCuit;
        private System.Windows.Forms.TextBox _txtDomicilio;
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.TextBox _txtUsuario;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button _btnAltaEmpresa;
        private System.Windows.Forms.LinkLabel _btnVolver;
    }
}