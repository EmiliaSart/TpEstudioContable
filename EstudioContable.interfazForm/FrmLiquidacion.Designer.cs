namespace EstudioContable.interfazForm
{
    partial class FrmLiquidacion
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
            this._btnConsultarLiquidacion = new System.Windows.Forms.Button();
            this._btnAltaLiquidación = new System.Windows.Forms.Button();
            this._txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this._txtIdEmpleado = new System.Windows.Forms.TextBox();
            this._txtPeriodo = new System.Windows.Forms.TextBox();
            this._txtBruto = new System.Windows.Forms.TextBox();
            this._txtCodigoTransferencia = new System.Windows.Forms.TextBox();
            this._txtFechaAlta = new System.Windows.Forms.TextBox();
            this._txtDescuentos = new System.Windows.Forms.TextBox();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblCodigoTransferencia = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblDescuentos = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _btnConsultarLiquidacion
            // 
            this._btnConsultarLiquidacion.Location = new System.Drawing.Point(309, 8);
            this._btnConsultarLiquidacion.Name = "_btnConsultarLiquidacion";
            this._btnConsultarLiquidacion.Size = new System.Drawing.Size(166, 26);
            this._btnConsultarLiquidacion.TabIndex = 0;
            this._btnConsultarLiquidacion.Text = "Consultar Liquidación";
            this._btnConsultarLiquidacion.UseVisualStyleBackColor = true;
            this._btnConsultarLiquidacion.Click += new System.EventHandler(this._btnConsultarLiquidacion_Click);
            // 
            // _btnAltaLiquidación
            // 
            this._btnAltaLiquidación.Location = new System.Drawing.Point(296, 106);
            this._btnAltaLiquidación.Name = "_btnAltaLiquidación";
            this._btnAltaLiquidación.Size = new System.Drawing.Size(179, 31);
            this._btnAltaLiquidación.TabIndex = 1;
            this._btnAltaLiquidación.Text = "Alta Liquidación";
            this._btnAltaLiquidación.UseVisualStyleBackColor = true;
            this._btnAltaLiquidación.Click += new System.EventHandler(this._btnAltaLiquidación_Click);
            // 
            // _txtId
            // 
            this._txtId.Location = new System.Drawing.Point(165, 12);
            this._txtId.Name = "_txtId";
            this._txtId.Size = new System.Drawing.Size(100, 20);
            this._txtId.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(66, 19);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "Id";
            // 
            // _txtIdEmpleado
            // 
            this._txtIdEmpleado.Location = new System.Drawing.Point(165, 51);
            this._txtIdEmpleado.Name = "_txtIdEmpleado";
            this._txtIdEmpleado.Size = new System.Drawing.Size(100, 20);
            this._txtIdEmpleado.TabIndex = 4;
            // 
            // _txtPeriodo
            // 
            this._txtPeriodo.Location = new System.Drawing.Point(165, 77);
            this._txtPeriodo.Name = "_txtPeriodo";
            this._txtPeriodo.Size = new System.Drawing.Size(100, 20);
            this._txtPeriodo.TabIndex = 5;
            // 
            // _txtBruto
            // 
            this._txtBruto.Location = new System.Drawing.Point(165, 146);
            this._txtBruto.Name = "_txtBruto";
            this._txtBruto.Size = new System.Drawing.Size(100, 20);
            this._txtBruto.TabIndex = 6;
            // 
            // _txtCodigoTransferencia
            // 
            this._txtCodigoTransferencia.Location = new System.Drawing.Point(165, 103);
            this._txtCodigoTransferencia.Name = "_txtCodigoTransferencia";
            this._txtCodigoTransferencia.Size = new System.Drawing.Size(100, 20);
            this._txtCodigoTransferencia.TabIndex = 7;
            // 
            // _txtFechaAlta
            // 
            this._txtFechaAlta.Location = new System.Drawing.Point(165, 230);
            this._txtFechaAlta.Name = "_txtFechaAlta";
            this._txtFechaAlta.Size = new System.Drawing.Size(100, 20);
            this._txtFechaAlta.TabIndex = 8;
            // 
            // _txtDescuentos
            // 
            this._txtDescuentos.Location = new System.Drawing.Point(165, 189);
            this._txtDescuentos.Name = "_txtDescuentos";
            this._txtDescuentos.Size = new System.Drawing.Size(100, 20);
            this._txtDescuentos.TabIndex = 9;
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(66, 54);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(66, 13);
            this.lblIdEmpleado.TabIndex = 10;
            this.lblIdEmpleado.Text = "Id Empleado";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(66, 80);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(45, 13);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Período";
            // 
            // lblCodigoTransferencia
            // 
            this.lblCodigoTransferencia.AutoSize = true;
            this.lblCodigoTransferencia.Location = new System.Drawing.Point(35, 106);
            this.lblCodigoTransferencia.Name = "lblCodigoTransferencia";
            this.lblCodigoTransferencia.Size = new System.Drawing.Size(108, 13);
            this.lblCodigoTransferencia.TabIndex = 12;
            this.lblCodigoTransferencia.Text = "Código Transferencia";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Location = new System.Drawing.Point(66, 146);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(32, 13);
            this.lblBruto.TabIndex = 13;
            this.lblBruto.Text = "Bruto";
            // 
            // lblDescuentos
            // 
            this.lblDescuentos.AutoSize = true;
            this.lblDescuentos.Location = new System.Drawing.Point(66, 192);
            this.lblDescuentos.Name = "lblDescuentos";
            this.lblDescuentos.Size = new System.Drawing.Size(64, 13);
            this.lblDescuentos.TabIndex = 14;
            this.lblDescuentos.Text = "Descuentos";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(66, 230);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(58, 13);
            this.lblFechaAlta.TabIndex = 15;
            this.lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblVolver
            // 
            this.lblVolver.AutoSize = true;
            this.lblVolver.Location = new System.Drawing.Point(467, 237);
            this.lblVolver.Name = "lblVolver";
            this.lblVolver.Size = new System.Drawing.Size(37, 13);
            this.lblVolver.TabIndex = 16;
            this.lblVolver.TabStop = true;
            this.lblVolver.Text = "Volver";
            this.lblVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this._linkVolver_Click);
            // 
            // FrmLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 262);
            this.Controls.Add(this.lblVolver);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblDescuentos);
            this.Controls.Add(this.lblBruto);
            this.Controls.Add(this.lblCodigoTransferencia);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this._txtDescuentos);
            this.Controls.Add(this._txtFechaAlta);
            this.Controls.Add(this._txtCodigoTransferencia);
            this.Controls.Add(this._txtBruto);
            this.Controls.Add(this._txtPeriodo);
            this.Controls.Add(this._txtIdEmpleado);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this._txtId);
            this.Controls.Add(this._btnAltaLiquidación);
            this.Controls.Add(this._btnConsultarLiquidacion);
            this.Name = "FrmLiquidacion";
            this.Text = "Liquidación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConsultarLiquidacion;
        private System.Windows.Forms.Button _btnAltaLiquidación;
        private System.Windows.Forms.TextBox _txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox _txtIdEmpleado;
        private System.Windows.Forms.TextBox _txtPeriodo;
        private System.Windows.Forms.TextBox _txtBruto;
        private System.Windows.Forms.TextBox _txtCodigoTransferencia;
        private System.Windows.Forms.TextBox _txtFechaAlta;
        private System.Windows.Forms.TextBox _txtDescuentos;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblCodigoTransferencia;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblDescuentos;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.LinkLabel lblVolver;
    }
}