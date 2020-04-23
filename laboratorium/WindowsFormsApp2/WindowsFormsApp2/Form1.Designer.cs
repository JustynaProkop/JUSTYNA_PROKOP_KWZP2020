namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.chkButtonEnabled = new System.Windows.Forms.CheckBox();
            this.txtButtonLabel = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KWZP 2020";
            // 
            // chkButtonEnabled
            // 
            this.chkButtonEnabled.AutoSize = true;
            this.chkButtonEnabled.Location = new System.Drawing.Point(343, 148);
            this.chkButtonEnabled.Name = "chkButtonEnabled";
            this.chkButtonEnabled.Size = new System.Drawing.Size(88, 17);
            this.chkButtonEnabled.TabIndex = 1;
            this.chkButtonEnabled.Text = "Jestem homo";
            this.chkButtonEnabled.UseVisualStyleBackColor = true;
            this.chkButtonEnabled.CheckedChanged += new System.EventHandler(this.chkButtonEnabled_CheckedChanged);
            // 
            // txtButtonLabel
            // 
            this.txtButtonLabel.Location = new System.Drawing.Point(343, 105);
            this.txtButtonLabel.Name = "txtButtonLabel";
            this.txtButtonLabel.Size = new System.Drawing.Size(100, 20);
            this.txtButtonLabel.TabIndex = 2;
            this.txtButtonLabel.TextChanged += new System.EventHandler(this.txtButtonLabel_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Wpisz tekst";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtButtonLabel);
            this.Controls.Add(this.chkButtonEnabled);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkButtonEnabled;
        private System.Windows.Forms.TextBox txtButtonLabel;
        private System.Windows.Forms.Button btnClose;
    }
}

