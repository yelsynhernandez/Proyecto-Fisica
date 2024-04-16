namespace ProyectoFisica
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpCM = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbEcuacion = new System.Windows.Forms.PictureBox();
            this.cbEcuaciones = new System.Windows.Forms.ComboBox();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.cbTipoMedida = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMedidaOrigen = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.lblMedidaDestino = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.msPrincipal.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpCM.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEcuacion)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(982, 30);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "Menú";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(87, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpCM);
            this.tcPrincipal.Controls.Add(this.tabPage4);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 30);
            this.tcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(982, 723);
            this.tcPrincipal.TabIndex = 1;
            // 
            // tpCM
            // 
            this.tpCM.Controls.Add(this.btnCalcular);
            this.tpCM.Controls.Add(this.txtResultado);
            this.tpCM.Controls.Add(this.lblResultado);
            this.tpCM.Controls.Add(this.lblMedidaDestino);
            this.tpCM.Controls.Add(this.cbDestino);
            this.tpCM.Controls.Add(this.lblMedidaOrigen);
            this.tpCM.Controls.Add(this.cbOrigen);
            this.tpCM.Controls.Add(this.label1);
            this.tpCM.Controls.Add(this.cbTipoMedida);
            this.tpCM.Location = new System.Drawing.Point(4, 30);
            this.tpCM.Name = "tpCM";
            this.tpCM.Padding = new System.Windows.Forms.Padding(3);
            this.tpCM.Size = new System.Drawing.Size(974, 689);
            this.tpCM.TabIndex = 0;
            this.tpCM.Text = "Convertidor de medidas";
            this.tpCM.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pbEcuacion);
            this.tabPage4.Controls.Add(this.cbEcuaciones);
            this.tabPage4.Controls.Add(this.lblEcuacion);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(974, 691);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "MRU";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(882, 625);
            this.tabControl1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pbEcuacion
            // 
            this.pbEcuacion.Location = new System.Drawing.Point(7, 108);
            this.pbEcuacion.Name = "pbEcuacion";
            this.pbEcuacion.Size = new System.Drawing.Size(860, 157);
            this.pbEcuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEcuacion.TabIndex = 5;
            this.pbEcuacion.TabStop = false;
            // 
            // cbEcuaciones
            // 
            this.cbEcuaciones.FormattingEnabled = true;
            this.cbEcuaciones.Location = new System.Drawing.Point(356, 53);
            this.cbEcuaciones.Name = "cbEcuaciones";
            this.cbEcuaciones.Size = new System.Drawing.Size(348, 29);
            this.cbEcuaciones.TabIndex = 4;
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Location = new System.Drawing.Point(163, 56);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(191, 22);
            this.lblEcuacion.TabIndex = 3;
            this.lblEcuacion.Text = "Seleccione ecuación:";
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.Font = new System.Drawing.Font("Arial", 12F);
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Location = new System.Drawing.Point(378, 82);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(289, 31);
            this.cbTipoMedida.TabIndex = 0;
            this.cbTipoMedida.SelectedIndexChanged += new System.EventHandler(this.cbTipoMedida_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(225, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de medida:";
            // 
            // lblMedidaOrigen
            // 
            this.lblMedidaOrigen.AutoSize = true;
            this.lblMedidaOrigen.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMedidaOrigen.Location = new System.Drawing.Point(238, 273);
            this.lblMedidaOrigen.Name = "lblMedidaOrigen";
            this.lblMedidaOrigen.Size = new System.Drawing.Size(141, 23);
            this.lblMedidaOrigen.TabIndex = 3;
            this.lblMedidaOrigen.Text = "Medida origen:";
            // 
            // cbOrigen
            // 
            this.cbOrigen.Font = new System.Drawing.Font("Arial", 12F);
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(378, 270);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(289, 31);
            this.cbOrigen.TabIndex = 2;
            // 
            // lblMedidaDestino
            // 
            this.lblMedidaDestino.AutoSize = true;
            this.lblMedidaDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMedidaDestino.Location = new System.Drawing.Point(225, 338);
            this.lblMedidaDestino.Name = "lblMedidaDestino";
            this.lblMedidaDestino.Size = new System.Drawing.Size(150, 23);
            this.lblMedidaDestino.TabIndex = 5;
            this.lblMedidaDestino.Text = "Medida destino:";
            // 
            // cbDestino
            // 
            this.cbDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(378, 335);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(289, 31);
            this.cbDestino.TabIndex = 4;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F);
            this.lblResultado.Location = new System.Drawing.Point(268, 404);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(104, 23);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial", 12F);
            this.txtResultado.Location = new System.Drawing.Point(375, 401);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(292, 30);
            this.txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(425, 532);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.tcPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto - Física I";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tcPrincipal.ResumeLayout(false);
            this.tpCM.ResumeLayout(false);
            this.tpCM.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEcuacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tpCM;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pbEcuacion;
        private System.Windows.Forms.ComboBox cbEcuaciones;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.ComboBox cbTipoMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedidaDestino;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Label lblMedidaOrigen;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
    }
}

