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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblMedidaDestino = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoMedida = new System.Windows.Forms.ComboBox();
            this.tpFormulas = new System.Windows.Forms.TabPage();
            this.pbEcuacion = new System.Windows.Forms.PictureBox();
            this.cbEcuacion = new System.Windows.Forms.ComboBox();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cbCategoriaEcuacion = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFormula = new System.Windows.Forms.Label();
            this.msPrincipal.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpCM.SuspendLayout();
            this.tpFormulas.SuspendLayout();
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpCM);
            this.tcPrincipal.Controls.Add(this.tpFormulas);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 30);
            this.tcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(982, 723);
            this.tcPrincipal.TabIndex = 1;
            this.tcPrincipal.SelectedIndexChanged += new System.EventHandler(this.tcPrincipal_SelectedIndexChanged);
            // 
            // tpCM
            // 
            this.tpCM.Controls.Add(this.btnLimpiar);
            this.tpCM.Controls.Add(this.txtCantidad);
            this.tpCM.Controls.Add(this.lblCantidad);
            this.tpCM.Controls.Add(this.btnCalcular);
            this.tpCM.Controls.Add(this.txtResultado);
            this.tpCM.Controls.Add(this.lblMedidaDestino);
            this.tpCM.Controls.Add(this.cbDestino);
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
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(285, 483);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(271, 246);
            this.txtCantidad.MaxLength = 38;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(249, 29);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(178, 249);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(90, 22);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(493, 482);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Arial", 12F);
            this.txtResultado.Location = new System.Drawing.Point(526, 331);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(192, 30);
            this.txtResultado.TabIndex = 7;
            // 
            // lblMedidaDestino
            // 
            this.lblMedidaDestino.AutoSize = true;
            this.lblMedidaDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMedidaDestino.Location = new System.Drawing.Point(238, 331);
            this.lblMedidaDestino.Name = "lblMedidaDestino";
            this.lblMedidaDestino.Size = new System.Drawing.Size(27, 23);
            this.lblMedidaDestino.TabIndex = 5;
            this.lblMedidaDestino.Text = "a:";
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(271, 328);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(249, 31);
            this.cbDestino.TabIndex = 4;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.Font = new System.Drawing.Font("Arial", 12F);
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(526, 244);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(192, 31);
            this.cbOrigen.TabIndex = 2;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(165, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de medida:";
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedida.Font = new System.Drawing.Font("Arial", 12F);
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Location = new System.Drawing.Point(318, 148);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(400, 31);
            this.cbTipoMedida.TabIndex = 0;
            this.cbTipoMedida.SelectedIndexChanged += new System.EventHandler(this.cbTipoMedida_SelectedIndexChanged);
            // 
            // tpFormulas
            // 
            this.tpFormulas.Controls.Add(this.cbCategoriaEcuacion);
            this.tpFormulas.Controls.Add(this.lblCategoriaFormula);
            this.tpFormulas.Controls.Add(this.pbEcuacion);
            this.tpFormulas.Controls.Add(this.cbEcuacion);
            this.tpFormulas.Controls.Add(this.lblEcuacion);
            this.tpFormulas.Location = new System.Drawing.Point(4, 30);
            this.tpFormulas.Name = "tpFormulas";
            this.tpFormulas.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulas.Size = new System.Drawing.Size(974, 689);
            this.tpFormulas.TabIndex = 1;
            this.tpFormulas.Text = "Fórmulas";
            this.tpFormulas.UseVisualStyleBackColor = true;
            // 
            // pbEcuacion
            // 
            this.pbEcuacion.Location = new System.Drawing.Point(16, 196);
            this.pbEcuacion.Name = "pbEcuacion";
            this.pbEcuacion.Size = new System.Drawing.Size(950, 157);
            this.pbEcuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEcuacion.TabIndex = 5;
            this.pbEcuacion.TabStop = false;
            // 
            // cbEcuacion
            // 
            this.cbEcuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcuacion.FormattingEnabled = true;
            this.cbEcuacion.Location = new System.Drawing.Point(365, 141);
            this.cbEcuacion.Name = "cbEcuacion";
            this.cbEcuacion.Size = new System.Drawing.Size(348, 29);
            this.cbEcuacion.TabIndex = 4;
            this.cbEcuacion.SelectedIndexChanged += new System.EventHandler(this.cbEcuacion_SelectedIndexChanged);
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Location = new System.Drawing.Point(172, 144);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(191, 22);
            this.lblEcuacion.TabIndex = 3;
            this.lblEcuacion.Text = "Seleccione ecuación:";
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
            // cbCategoriaEcuacion
            // 
            this.cbCategoriaEcuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaEcuacion.FormattingEnabled = true;
            this.cbCategoriaEcuacion.Location = new System.Drawing.Point(365, 90);
            this.cbCategoriaEcuacion.Name = "cbCategoriaEcuacion";
            this.cbCategoriaEcuacion.Size = new System.Drawing.Size(348, 29);
            this.cbCategoriaEcuacion.TabIndex = 7;
            this.cbCategoriaEcuacion.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaFormulas_SelectedIndexChanged);
            // 
            // lblCategoriaFormula
            // 
            this.lblCategoriaFormula.AutoSize = true;
            this.lblCategoriaFormula.Location = new System.Drawing.Point(260, 93);
            this.lblCategoriaFormula.Name = "lblCategoriaFormula";
            this.lblCategoriaFormula.Size = new System.Drawing.Size(99, 22);
            this.lblCategoriaFormula.TabIndex = 6;
            this.lblCategoriaFormula.Text = "Categoría:";
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
            this.tpFormulas.ResumeLayout(false);
            this.tpFormulas.PerformLayout();
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
        private System.Windows.Forms.TabPage tpFormulas;
        private System.Windows.Forms.PictureBox pbEcuacion;
        private System.Windows.Forms.ComboBox cbEcuacion;
        private System.Windows.Forms.Label lblEcuacion;
        private System.Windows.Forms.ComboBox cbTipoMedida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMedidaDestino;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbCategoriaEcuacion;
        private System.Windows.Forms.Label lblCategoriaFormula;
    }
}

