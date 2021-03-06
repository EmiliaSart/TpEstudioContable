namespace EstudioContable.interfazForm
{
    partial class FrmReportes
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
            this._lstEmpresas = new System.Windows.Forms.ListBox();
            this._lstCategorias = new System.Windows.Forms.ListBox();
            this._lblCategoria = new System.Windows.Forms.Label();
            this._lblEmpresa = new System.Windows.Forms.Label();
            this.btn_ReporteLiquidaciones = new System.Windows.Forms.Button();
            this._btnReporteEmpleados = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // _lstEmpresas
            // 
            this._lstEmpresas.FormattingEnabled = true;
            this._lstEmpresas.Location = new System.Drawing.Point(64, 124);
            this._lstEmpresas.Name = "_lstEmpresas";
            this._lstEmpresas.Size = new System.Drawing.Size(210, 199);
            this._lstEmpresas.TabIndex = 0;
            this._lstEmpresas.SelectedIndexChanged += new System.EventHandler(this._lstEmpresas_SelectedIndexChanged);
            // 
            // _lstCategorias
            // 
            this._lstCategorias.FormattingEnabled = true;
            this._lstCategorias.Location = new System.Drawing.Point(355, 124);
            this._lstCategorias.Name = "_lstCategorias";
            this._lstCategorias.Size = new System.Drawing.Size(219, 199);
            this._lstCategorias.TabIndex = 1;
            // 
            // _lblCategoria
            // 
            this._lblCategoria.AutoSize = true;
            this._lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCategoria.Location = new System.Drawing.Point(352, 94);
            this._lblCategoria.Name = "_lblCategoria";
            this._lblCategoria.Size = new System.Drawing.Size(87, 20);
            this._lblCategoria.TabIndex = 2;
            this._lblCategoria.Text = "Categoria";
            // 
            // _lblEmpresa
            // 
            this._lblEmpresa.AutoSize = true;
            this._lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblEmpresa.Location = new System.Drawing.Point(60, 94);
            this._lblEmpresa.Name = "_lblEmpresa";
            this._lblEmpresa.Size = new System.Drawing.Size(85, 20);
            this._lblEmpresa.TabIndex = 3;
            this._lblEmpresa.Text = "Empresa:";
            // 
            // btn_ReporteLiquidaciones
            // 
            this.btn_ReporteLiquidaciones.Location = new System.Drawing.Point(356, 348);
            this.btn_ReporteLiquidaciones.Name = "btn_ReporteLiquidaciones";
            this.btn_ReporteLiquidaciones.Size = new System.Drawing.Size(218, 44);
            this.btn_ReporteLiquidaciones.TabIndex = 4;
            this.btn_ReporteLiquidaciones.Text = "Reporte de Liquidaciones";
            this.btn_ReporteLiquidaciones.UseVisualStyleBackColor = true;
            this.btn_ReporteLiquidaciones.Click += new System.EventHandler(this.btn_ReporteLiquidaciones_Click);
            // 
            // _btnReporteEmpleados
            // 
            this._btnReporteEmpleados.Location = new System.Drawing.Point(64, 348);
            this._btnReporteEmpleados.Name = "_btnReporteEmpleados";
            this._btnReporteEmpleados.Size = new System.Drawing.Size(210, 44);
            this._btnReporteEmpleados.TabIndex = 5;
            this._btnReporteEmpleados.Text = "Reporte de Empleados";
            this._btnReporteEmpleados.UseVisualStyleBackColor = true;
            this._btnReporteEmpleados.Click += new System.EventHandler(this._btnReporteEmpleados_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.AutoSize = true;
            this._btnVolver.Location = new System.Drawing.Point(675, 393);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(37, 13);
            this._btnVolver.TabIndex = 6;
            this._btnVolver.TabStop = true;
            this._btnVolver.Text = "Volver";
            this._btnVolver.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnReporteEmpleados);
            this.Controls.Add(this.btn_ReporteLiquidaciones);
            this.Controls.Add(this._lblEmpresa);
            this.Controls.Add(this._lblCategoria);
            this.Controls.Add(this._lstCategorias);
            this.Controls.Add(this._lstEmpresas);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _lstEmpresas;
        private System.Windows.Forms.ListBox _lstCategorias;
        private System.Windows.Forms.Label _lblCategoria;
        private System.Windows.Forms.Label _lblEmpresa;
        private System.Windows.Forms.Button btn_ReporteLiquidaciones;
        private System.Windows.Forms.Button _btnReporteEmpleados;
        private System.Windows.Forms.LinkLabel _btnVolver;
    }
}