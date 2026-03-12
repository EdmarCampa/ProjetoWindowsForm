namespace WindowsFormsIMC
{
    partial class FrmIMC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC));
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btIMC = new Button();
            pbLogo = new PictureBox();
            lbPeso = new Label();
            lbAltura = new Label();
            lbMensagem = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(193, 50);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "digite o peso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 2;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(193, 79);
            txtAltura.Name = "txtAltura";
            txtAltura.PlaceholderText = "digite a altura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 3;
            // 
            // btIMC
            // 
            btIMC.Location = new Point(193, 108);
            btIMC.Name = "btIMC";
            btIMC.Size = new Size(100, 23);
            btIMC.TabIndex = 4;
            btIMC.Text = "Gerar";
            btIMC.UseVisualStyleBackColor = true;
            btIMC.Click += btIMC_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.exercise_icon_208576__1_;
            pbLogo.Location = new Point(12, 33);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 98);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Location = new Point(134, 58);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 6;
            lbPeso.Text = "Peso";
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.Location = new Point(134, 87);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 7;
            lbAltura.Text = "Altura";
            // 
            // lbMensagem
            // 
            lbMensagem.AutoSize = true;
            lbMensagem.Location = new Point(38, 146);
            lbMensagem.Name = "lbMensagem";
            lbMensagem.Size = new Size(0, 15);
            lbMensagem.TabIndex = 8;
            // 
            // FrmIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 179);
            Controls.Add(lbMensagem);
            Controls.Add(lbAltura);
            Controls.Add(lbPeso);
            Controls.Add(pbLogo);
            Controls.Add(btIMC);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IMC";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btIMC;
        private PictureBox pbLogo;
        private Label lbPeso;
        private Label lbAltura;
        private Label lbMensagem;
    }
}
