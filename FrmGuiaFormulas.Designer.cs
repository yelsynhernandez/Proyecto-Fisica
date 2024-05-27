namespace ProyectoFisica
{
    partial class FrmGuiaFormulas
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
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.pbGuiaFormulas = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuiaFormulas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpControl
            // 
            this.tlpControl.ColumnCount = 1;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControl.Controls.Add(this.pbGuiaFormulas, 0, 0);
            this.tlpControl.Controls.Add(this.button1, 0, 1);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControl.Location = new System.Drawing.Point(0, 0);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 2;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tlpControl.Size = new System.Drawing.Size(850, 600);
            this.tlpControl.TabIndex = 0;
            // 
            // pbGuiaFormulas
            // 
            this.pbGuiaFormulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbGuiaFormulas.Location = new System.Drawing.Point(3, 3);
            this.pbGuiaFormulas.Name = "pbGuiaFormulas";
            this.pbGuiaFormulas.Size = new System.Drawing.Size(844, 546);
            this.pbGuiaFormulas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGuiaFormulas.TabIndex = 1;
            this.pbGuiaFormulas.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Arial", 11F);
            this.button1.Location = new System.Drawing.Point(3, 558);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(844, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGuiaFormulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.tlpControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGuiaFormulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guía de fórmulas";
            this.Load += new System.EventHandler(this.FrmGuiaFormulas_Load);
            this.tlpControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGuiaFormulas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.PictureBox pbGuiaFormulas;
        private System.Windows.Forms.Button button1;
    }
}