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
            this.cbCategoriaEcuacion = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFormula = new System.Windows.Forms.Label();
            this.cbEcuacion = new System.Windows.Forms.ComboBox();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pbEcuacion = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpComponentes = new System.Windows.Forms.TabPage();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblInclinacion = new System.Windows.Forms.Label();
            this.msPrincipal.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpCM.SuspendLayout();
            this.tpFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEcuacion)).BeginInit();
            this.tpComponentes.SuspendLayout();
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
            this.msPrincipal.Size = new System.Drawing.Size(982, 25);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "Menú";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tpCM);
            this.tcPrincipal.Controls.Add(this.tpFormulas);
            this.tcPrincipal.Controls.Add(this.tpComponentes);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 25);
            this.tcPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(982, 573);
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
            this.tpCM.Location = new System.Drawing.Point(4, 26);
            this.tpCM.Name = "tpCM";
            this.tpCM.Padding = new System.Windows.Forms.Padding(3);
            this.tpCM.Size = new System.Drawing.Size(974, 543);
            this.tpCM.TabIndex = 0;
            this.tpCM.Text = "Convertidor de medidas";
            this.tpCM.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(506, 407);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(267, 211);
            this.txtCantidad.MaxLength = 38;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(249, 24);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(174, 214);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 17);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(267, 407);
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
            this.txtResultado.Location = new System.Drawing.Point(522, 293);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(192, 26);
            this.txtResultado.TabIndex = 7;
            // 
            // lblMedidaDestino
            // 
            this.lblMedidaDestino.AutoSize = true;
            this.lblMedidaDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMedidaDestino.Location = new System.Drawing.Point(234, 296);
            this.lblMedidaDestino.Name = "lblMedidaDestino";
            this.lblMedidaDestino.Size = new System.Drawing.Size(21, 18);
            this.lblMedidaDestino.TabIndex = 5;
            this.lblMedidaDestino.Text = "a:";
            // 
            // cbDestino
            // 
            this.cbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(267, 293);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(249, 26);
            this.cbDestino.TabIndex = 4;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.Font = new System.Drawing.Font("Arial", 12F);
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(522, 209);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(192, 26);
            this.cbOrigen.TabIndex = 2;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(161, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de medida:";
            // 
            // cbTipoMedida
            // 
            this.cbTipoMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoMedida.Font = new System.Drawing.Font("Arial", 12F);
            this.cbTipoMedida.FormattingEnabled = true;
            this.cbTipoMedida.Location = new System.Drawing.Point(314, 113);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(400, 26);
            this.cbTipoMedida.TabIndex = 0;
            this.cbTipoMedida.SelectedIndexChanged += new System.EventHandler(this.cbTipoMedida_SelectedIndexChanged);
            // 
            // tpFormulas
            // 
            this.tpFormulas.Controls.Add(this.label2);
            this.tpFormulas.Controls.Add(this.textBox1);
            this.tpFormulas.Controls.Add(this.cbCategoriaEcuacion);
            this.tpFormulas.Controls.Add(this.lblCategoriaFormula);
            this.tpFormulas.Controls.Add(this.pbEcuacion);
            this.tpFormulas.Controls.Add(this.cbEcuacion);
            this.tpFormulas.Controls.Add(this.lblEcuacion);
            this.tpFormulas.Location = new System.Drawing.Point(4, 26);
            this.tpFormulas.Name = "tpFormulas";
            this.tpFormulas.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulas.Size = new System.Drawing.Size(974, 543);
            this.tpFormulas.TabIndex = 1;
            this.tpFormulas.Text = "Fórmulas";
            this.tpFormulas.UseVisualStyleBackColor = true;
            // 
            // cbCategoriaEcuacion
            // 
            this.cbCategoriaEcuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaEcuacion.FormattingEnabled = true;
            this.cbCategoriaEcuacion.Location = new System.Drawing.Point(365, 34);
            this.cbCategoriaEcuacion.Name = "cbCategoriaEcuacion";
            this.cbCategoriaEcuacion.Size = new System.Drawing.Size(348, 25);
            this.cbCategoriaEcuacion.TabIndex = 7;
            this.cbCategoriaEcuacion.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaFormulas_SelectedIndexChanged);
            // 
            // lblCategoriaFormula
            // 
            this.lblCategoriaFormula.AutoSize = true;
            this.lblCategoriaFormula.Location = new System.Drawing.Point(260, 37);
            this.lblCategoriaFormula.Name = "lblCategoriaFormula";
            this.lblCategoriaFormula.Size = new System.Drawing.Size(75, 17);
            this.lblCategoriaFormula.TabIndex = 6;
            this.lblCategoriaFormula.Text = "Categoría:";
            // 
            // cbEcuacion
            // 
            this.cbEcuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcuacion.FormattingEnabled = true;
            this.cbEcuacion.Location = new System.Drawing.Point(365, 85);
            this.cbEcuacion.Name = "cbEcuacion";
            this.cbEcuacion.Size = new System.Drawing.Size(348, 25);
            this.cbEcuacion.TabIndex = 4;
            this.cbEcuacion.SelectedIndexChanged += new System.EventHandler(this.cbEcuacion_SelectedIndexChanged);
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Location = new System.Drawing.Point(172, 88);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(147, 17);
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
            // pbEcuacion
            // 
            this.pbEcuacion.BackColor = System.Drawing.Color.Transparent;
            this.pbEcuacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEcuacion.Location = new System.Drawing.Point(6, 127);
            this.pbEcuacion.Name = "pbEcuacion";
            this.pbEcuacion.Size = new System.Drawing.Size(960, 157);
            this.pbEcuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEcuacion.TabIndex = 5;
            this.pbEcuacion.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(365, 290);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 235);
            this.textBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // tpComponentes
            // 
            this.tpComponentes.Controls.Add(this.textBox2);
            this.tpComponentes.Controls.Add(this.lblInclinacion);
            this.tpComponentes.Controls.Add(this.txtFuerza);
            this.tpComponentes.Controls.Add(this.lblFuerza);
            this.tpComponentes.Location = new System.Drawing.Point(4, 26);
            this.tpComponentes.Name = "tpComponentes";
            this.tpComponentes.Padding = new System.Windows.Forms.Padding(3);
            this.tpComponentes.Size = new System.Drawing.Size(974, 543);
            this.tpComponentes.TabIndex = 2;
            this.tpComponentes.Text = "Componentes";
            this.tpComponentes.UseVisualStyleBackColor = true;
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(341, 106);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(58, 17);
            this.lblFuerza.TabIndex = 0;
            this.lblFuerza.Text = "Fuerza:";
            // 
            // txtFuerza
            // 
            this.txtFuerza.Location = new System.Drawing.Point(405, 103);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(166, 24);
            this.txtFuerza.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(405, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 24);
            this.textBox2.TabIndex = 3;
            // 
            // lblInclinacion
            // 
            this.lblInclinacion.AutoSize = true;
            this.lblInclinacion.Location = new System.Drawing.Point(260, 136);
            this.lblInclinacion.Name = "lblInclinacion";
            this.lblInclinacion.Size = new System.Drawing.Size(139, 17);
            this.lblInclinacion.TabIndex = 2;
            this.lblInclinacion.Text = "Inclinación (grados):";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 598);
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
            this.tpComponentes.ResumeLayout(false);
            this.tpComponentes.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tpComponentes;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblInclinacion;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.Label lblFuerza;
    }
}

