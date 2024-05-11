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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tpCM = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.pbConvertidor = new System.Windows.Forms.PictureBox();
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
            this.lblResultadoEcuacion = new System.Windows.Forms.Label();
            this.txtResultadoEcuacion = new System.Windows.Forms.TextBox();
            this.btnCalcularEcuacion = new System.Windows.Forms.Button();
            this.btnActualizarEcuaciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvVariables = new System.Windows.Forms.DataGridView();
            this.cbCategoriaEcuacion = new System.Windows.Forms.ComboBox();
            this.lblCategoriaFormula = new System.Windows.Forms.Label();
            this.cbEcuacion = new System.Windows.Forms.ComboBox();
            this.lblEcuacion = new System.Windows.Forms.Label();
            this.pbEcuacion = new System.Windows.Forms.PictureBox();
            this.tpComponentes = new System.Windows.Forms.TabPage();
            this.lblDisclaimerComponentes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComponenteX = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFuerza = new System.Windows.Forms.Label();
            this.btnLimpiarComponentes = new System.Windows.Forms.Button();
            this.btnCalcularcomponentes = new System.Windows.Forms.Button();
            this.txtComponenteY = new System.Windows.Forms.TextBox();
            this.lblComponentes = new System.Windows.Forms.Label();
            this.txtComponenteX = new System.Windows.Forms.TextBox();
            this.txtAngulo = new System.Windows.Forms.TextBox();
            this.txtFuerza = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblConsideracionesFormulario = new System.Windows.Forms.Label();
            this.msPrincipal.SuspendLayout();
            this.tcPrincipal.SuspendLayout();
            this.tpCM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertidor)).BeginInit();
            this.tpFormulas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEcuacion)).BeginInit();
            this.tpComponentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
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
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11F);
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
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
            this.tpCM.BackColor = System.Drawing.Color.Ivory;
            this.tpCM.Controls.Add(this.label4);
            this.tpCM.Controls.Add(this.pbConvertidor);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F);
            this.label4.Location = new System.Drawing.Point(356, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Convertidor de medidas";
            // 
            // pbConvertidor
            // 
            this.pbConvertidor.Location = new System.Drawing.Point(734, 185);
            this.pbConvertidor.Name = "pbConvertidor";
            this.pbConvertidor.Size = new System.Drawing.Size(95, 95);
            this.pbConvertidor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbConvertidor.TabIndex = 12;
            this.pbConvertidor.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(570, 407);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(111, 35);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(267, 224);
            this.txtCantidad.MaxLength = 38;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(249, 24);
            this.txtCantidad.TabIndex = 10;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(187, 226);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 17);
            this.lblCantidad.TabIndex = 9;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCalcular.Location = new System.Drawing.Point(342, 407);
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
            this.txtResultado.Location = new System.Drawing.Point(524, 280);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(192, 26);
            this.txtResultado.TabIndex = 7;
            // 
            // lblMedidaDestino
            // 
            this.lblMedidaDestino.AutoSize = true;
            this.lblMedidaDestino.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMedidaDestino.Location = new System.Drawing.Point(236, 283);
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
            this.cbDestino.Location = new System.Drawing.Point(269, 280);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(247, 26);
            this.cbDestino.TabIndex = 4;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.Font = new System.Drawing.Font("Arial", 12F);
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(522, 222);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(192, 26);
            this.cbOrigen.TabIndex = 2;
            this.cbOrigen.SelectedIndexChanged += new System.EventHandler(this.cbOrigen_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(136, 166);
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
            this.cbTipoMedida.Location = new System.Drawing.Point(269, 163);
            this.cbTipoMedida.Name = "cbTipoMedida";
            this.cbTipoMedida.Size = new System.Drawing.Size(445, 26);
            this.cbTipoMedida.TabIndex = 0;
            this.cbTipoMedida.SelectedIndexChanged += new System.EventHandler(this.cbTipoMedida_SelectedIndexChanged);
            // 
            // tpFormulas
            // 
            this.tpFormulas.BackColor = System.Drawing.Color.Ivory;
            this.tpFormulas.Controls.Add(this.lblConsideracionesFormulario);
            this.tpFormulas.Controls.Add(this.lblResultadoEcuacion);
            this.tpFormulas.Controls.Add(this.txtResultadoEcuacion);
            this.tpFormulas.Controls.Add(this.btnCalcularEcuacion);
            this.tpFormulas.Controls.Add(this.btnActualizarEcuaciones);
            this.tpFormulas.Controls.Add(this.label3);
            this.tpFormulas.Controls.Add(this.dgvVariables);
            this.tpFormulas.Controls.Add(this.cbCategoriaEcuacion);
            this.tpFormulas.Controls.Add(this.lblCategoriaFormula);
            this.tpFormulas.Controls.Add(this.cbEcuacion);
            this.tpFormulas.Controls.Add(this.lblEcuacion);
            this.tpFormulas.Controls.Add(this.pbEcuacion);
            this.tpFormulas.Location = new System.Drawing.Point(4, 26);
            this.tpFormulas.Name = "tpFormulas";
            this.tpFormulas.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormulas.Size = new System.Drawing.Size(974, 543);
            this.tpFormulas.TabIndex = 1;
            this.tpFormulas.Text = "Fórmulas";
            // 
            // lblResultadoEcuacion
            // 
            this.lblResultadoEcuacion.AutoSize = true;
            this.lblResultadoEcuacion.Location = new System.Drawing.Point(644, 428);
            this.lblResultadoEcuacion.Name = "lblResultadoEcuacion";
            this.lblResultadoEcuacion.Size = new System.Drawing.Size(78, 17);
            this.lblResultadoEcuacion.TabIndex = 15;
            this.lblResultadoEcuacion.Text = "Resultado:";
            // 
            // txtResultadoEcuacion
            // 
            this.txtResultadoEcuacion.Location = new System.Drawing.Point(728, 425);
            this.txtResultadoEcuacion.Name = "txtResultadoEcuacion";
            this.txtResultadoEcuacion.ReadOnly = true;
            this.txtResultadoEcuacion.Size = new System.Drawing.Size(185, 24);
            this.txtResultadoEcuacion.TabIndex = 14;
            // 
            // btnCalcularEcuacion
            // 
            this.btnCalcularEcuacion.Location = new System.Drawing.Point(647, 400);
            this.btnCalcularEcuacion.Name = "btnCalcularEcuacion";
            this.btnCalcularEcuacion.Size = new System.Drawing.Size(75, 25);
            this.btnCalcularEcuacion.TabIndex = 13;
            this.btnCalcularEcuacion.Text = "Calcular";
            this.btnCalcularEcuacion.UseVisualStyleBackColor = true;
            this.btnCalcularEcuacion.Click += new System.EventHandler(this.btnCalcularEcuacion_Click);
            // 
            // btnActualizarEcuaciones
            // 
            this.btnActualizarEcuaciones.Location = new System.Drawing.Point(728, 109);
            this.btnActualizarEcuaciones.Name = "btnActualizarEcuaciones";
            this.btnActualizarEcuaciones.Size = new System.Drawing.Size(110, 29);
            this.btnActualizarEcuaciones.TabIndex = 12;
            this.btnActualizarEcuaciones.Text = "Actualizar";
            this.btnActualizarEcuaciones.UseVisualStyleBackColor = true;
            this.btnActualizarEcuaciones.Click += new System.EventHandler(this.btnActualizarEcuaciones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16F);
            this.label3.Location = new System.Drawing.Point(409, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Formulario";
            // 
            // dgvVariables
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVariables.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariables.Location = new System.Drawing.Point(311, 310);
            this.dgvVariables.Name = "dgvVariables";
            this.dgvVariables.Size = new System.Drawing.Size(329, 227);
            this.dgvVariables.TabIndex = 10;
            // 
            // cbCategoriaEcuacion
            // 
            this.cbCategoriaEcuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaEcuacion.FormattingEnabled = true;
            this.cbCategoriaEcuacion.Location = new System.Drawing.Point(365, 73);
            this.cbCategoriaEcuacion.Name = "cbCategoriaEcuacion";
            this.cbCategoriaEcuacion.Size = new System.Drawing.Size(348, 25);
            this.cbCategoriaEcuacion.TabIndex = 7;
            this.cbCategoriaEcuacion.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaEcuacion_SelectedIndexChanged);
            // 
            // lblCategoriaFormula
            // 
            this.lblCategoriaFormula.AutoSize = true;
            this.lblCategoriaFormula.Location = new System.Drawing.Point(284, 76);
            this.lblCategoriaFormula.Name = "lblCategoriaFormula";
            this.lblCategoriaFormula.Size = new System.Drawing.Size(75, 17);
            this.lblCategoriaFormula.TabIndex = 6;
            this.lblCategoriaFormula.Text = "Categoría:";
            // 
            // cbEcuacion
            // 
            this.cbEcuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEcuacion.FormattingEnabled = true;
            this.cbEcuacion.Location = new System.Drawing.Point(365, 112);
            this.cbEcuacion.Name = "cbEcuacion";
            this.cbEcuacion.Size = new System.Drawing.Size(348, 25);
            this.cbEcuacion.TabIndex = 4;
            this.cbEcuacion.SelectedIndexChanged += new System.EventHandler(this.cbEcuacion_SelectedIndexChanged);
            // 
            // lblEcuacion
            // 
            this.lblEcuacion.AutoSize = true;
            this.lblEcuacion.Location = new System.Drawing.Point(212, 115);
            this.lblEcuacion.Name = "lblEcuacion";
            this.lblEcuacion.Size = new System.Drawing.Size(147, 17);
            this.lblEcuacion.TabIndex = 3;
            this.lblEcuacion.Text = "Seleccione ecuación:";
            // 
            // pbEcuacion
            // 
            this.pbEcuacion.BackColor = System.Drawing.Color.Transparent;
            this.pbEcuacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbEcuacion.Location = new System.Drawing.Point(6, 147);
            this.pbEcuacion.Name = "pbEcuacion";
            this.pbEcuacion.Size = new System.Drawing.Size(960, 157);
            this.pbEcuacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbEcuacion.TabIndex = 5;
            this.pbEcuacion.TabStop = false;
            // 
            // tpComponentes
            // 
            this.tpComponentes.BackColor = System.Drawing.Color.Ivory;
            this.tpComponentes.Controls.Add(this.lblDisclaimerComponentes);
            this.tpComponentes.Controls.Add(this.label6);
            this.tpComponentes.Controls.Add(this.lblComponenteX);
            this.tpComponentes.Controls.Add(this.label5);
            this.tpComponentes.Controls.Add(this.lblFuerza);
            this.tpComponentes.Controls.Add(this.btnLimpiarComponentes);
            this.tpComponentes.Controls.Add(this.btnCalcularcomponentes);
            this.tpComponentes.Controls.Add(this.txtComponenteY);
            this.tpComponentes.Controls.Add(this.lblComponentes);
            this.tpComponentes.Controls.Add(this.txtComponenteX);
            this.tpComponentes.Controls.Add(this.txtAngulo);
            this.tpComponentes.Controls.Add(this.txtFuerza);
            this.tpComponentes.Controls.Add(this.pictureBox2);
            this.tpComponentes.Location = new System.Drawing.Point(4, 26);
            this.tpComponentes.Name = "tpComponentes";
            this.tpComponentes.Padding = new System.Windows.Forms.Padding(3);
            this.tpComponentes.Size = new System.Drawing.Size(974, 543);
            this.tpComponentes.TabIndex = 2;
            this.tpComponentes.Text = "Componentes";
            // 
            // lblDisclaimerComponentes
            // 
            this.lblDisclaimerComponentes.AutoSize = true;
            this.lblDisclaimerComponentes.Location = new System.Drawing.Point(342, 30);
            this.lblDisclaimerComponentes.Name = "lblDisclaimerComponentes";
            this.lblDisclaimerComponentes.Size = new System.Drawing.Size(283, 17);
            this.lblDisclaimerComponentes.TabIndex = 17;
            this.lblDisclaimerComponentes.Text = "(Los componentes se calculan en metros)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(790, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Valor del componente en Y";
            // 
            // lblComponenteX
            // 
            this.lblComponenteX.AutoSize = true;
            this.lblComponenteX.Location = new System.Drawing.Point(280, 414);
            this.lblComponenteX.Name = "lblComponenteX";
            this.lblComponenteX.Size = new System.Drawing.Size(185, 17);
            this.lblComponenteX.TabIndex = 15;
            this.lblComponenteX.Text = "Valor del componente en X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fuerza:";
            // 
            // lblFuerza
            // 
            this.lblFuerza.AutoSize = true;
            this.lblFuerza.Location = new System.Drawing.Point(163, 222);
            this.lblFuerza.Name = "lblFuerza";
            this.lblFuerza.Size = new System.Drawing.Size(58, 17);
            this.lblFuerza.TabIndex = 13;
            this.lblFuerza.Text = "Fuerza:";
            // 
            // btnLimpiarComponentes
            // 
            this.btnLimpiarComponentes.Location = new System.Drawing.Point(602, 468);
            this.btnLimpiarComponentes.Name = "btnLimpiarComponentes";
            this.btnLimpiarComponentes.Size = new System.Drawing.Size(111, 35);
            this.btnLimpiarComponentes.TabIndex = 12;
            this.btnLimpiarComponentes.Text = "Limpiar";
            this.btnLimpiarComponentes.UseVisualStyleBackColor = true;
            this.btnLimpiarComponentes.Click += new System.EventHandler(this.btnLimpiarComponentes_Click);
            // 
            // btnCalcularcomponentes
            // 
            this.btnCalcularcomponentes.Font = new System.Drawing.Font("Arial", 12F);
            this.btnCalcularcomponentes.Location = new System.Drawing.Point(354, 468);
            this.btnCalcularcomponentes.Name = "btnCalcularcomponentes";
            this.btnCalcularcomponentes.Size = new System.Drawing.Size(111, 35);
            this.btnCalcularcomponentes.TabIndex = 9;
            this.btnCalcularcomponentes.Text = "Calcular";
            this.btnCalcularcomponentes.UseVisualStyleBackColor = true;
            this.btnCalcularcomponentes.Click += new System.EventHandler(this.btnCalcularcomponentes_Click);
            // 
            // txtComponenteY
            // 
            this.txtComponenteY.Font = new System.Drawing.Font("Arial", 14F);
            this.txtComponenteY.Location = new System.Drawing.Point(790, 235);
            this.txtComponenteY.Name = "txtComponenteY";
            this.txtComponenteY.ReadOnly = true;
            this.txtComponenteY.Size = new System.Drawing.Size(178, 29);
            this.txtComponenteY.TabIndex = 7;
            // 
            // lblComponentes
            // 
            this.lblComponentes.AutoSize = true;
            this.lblComponentes.Font = new System.Drawing.Font("Arial", 16F);
            this.lblComponentes.Location = new System.Drawing.Point(313, 5);
            this.lblComponentes.Name = "lblComponentes";
            this.lblComponentes.Size = new System.Drawing.Size(336, 25);
            this.lblComponentes.TabIndex = 6;
            this.lblComponentes.Text = "Cálculo de componentes en X y Y";
            // 
            // txtComponenteX
            // 
            this.txtComponenteX.Font = new System.Drawing.Font("Arial", 14F);
            this.txtComponenteX.Location = new System.Drawing.Point(471, 407);
            this.txtComponenteX.Name = "txtComponenteX";
            this.txtComponenteX.ReadOnly = true;
            this.txtComponenteX.Size = new System.Drawing.Size(166, 29);
            this.txtComponenteX.TabIndex = 5;
            // 
            // txtAngulo
            // 
            this.txtAngulo.Font = new System.Drawing.Font("Arial", 14F);
            this.txtAngulo.Location = new System.Drawing.Point(372, 340);
            this.txtAngulo.Name = "txtAngulo";
            this.txtAngulo.Size = new System.Drawing.Size(91, 29);
            this.txtAngulo.TabIndex = 3;
            // 
            // txtFuerza
            // 
            this.txtFuerza.Font = new System.Drawing.Font("Arial", 14F);
            this.txtFuerza.Location = new System.Drawing.Point(223, 215);
            this.txtFuerza.Name = "txtFuerza";
            this.txtFuerza.Size = new System.Drawing.Size(166, 29);
            this.txtFuerza.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoFisica.Properties.Resources.triangulo;
            this.pictureBox2.Location = new System.Drawing.Point(87, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(700, 331);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
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
            // lblConsideracionesFormulario
            // 
            this.lblConsideracionesFormulario.AutoSize = true;
            this.lblConsideracionesFormulario.Location = new System.Drawing.Point(8, 333);
            this.lblConsideracionesFormulario.Name = "lblConsideracionesFormulario";
            this.lblConsideracionesFormulario.Size = new System.Drawing.Size(95, 17);
            this.lblConsideracionesFormulario.TabIndex = 16;
            this.lblConsideracionesFormulario.Text = "Instrucciones";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 598);
            this.Controls.Add(this.tcPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.Font = new System.Drawing.Font("Arial", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto - Física I";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tcPrincipal.ResumeLayout(false);
            this.tpCM.ResumeLayout(false);
            this.tpCM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConvertidor)).EndInit();
            this.tpFormulas.ResumeLayout(false);
            this.tpFormulas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEcuacion)).EndInit();
            this.tpComponentes.ResumeLayout(false);
            this.tpComponentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.TabPage tpComponentes;
        private System.Windows.Forms.TextBox txtAngulo;
        private System.Windows.Forms.TextBox txtFuerza;
        private System.Windows.Forms.PictureBox pbConvertidor;
        private System.Windows.Forms.DataGridView dgvVariables;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblComponentes;
        private System.Windows.Forms.TextBox txtComponenteX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComponenteY;
        private System.Windows.Forms.Button btnCalcularcomponentes;
        private System.Windows.Forms.Button btnLimpiarComponentes;
        private System.Windows.Forms.Label lblFuerza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComponenteX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDisclaimerComponentes;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button btnActualizarEcuaciones;
        private System.Windows.Forms.Button btnCalcularEcuacion;
        private System.Windows.Forms.Label lblResultadoEcuacion;
        private System.Windows.Forms.TextBox txtResultadoEcuacion;
        private System.Windows.Forms.Label lblConsideracionesFormulario;
    }
}

