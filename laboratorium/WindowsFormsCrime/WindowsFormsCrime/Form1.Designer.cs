namespace WindowsFormsCrime
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
            this.lblZajecia = new System.Windows.Forms.Label();
            this.txtButtonLabel = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkButtonEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblZajecia
            // 
            this.lblZajecia.AutoSize = true;
            this.lblZajecia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblZajecia.Location = new System.Drawing.Point(341, 87);
            this.lblZajecia.Name = "lblZajecia";
            this.lblZajecia.Size = new System.Drawing.Size(130, 26);
            this.lblZajecia.TabIndex = 0;
            this.lblZajecia.Text = "KWZP 2020";
            // 
            // txtButtonLabel
            // 
            this.txtButtonLabel.Location = new System.Drawing.Point(346, 159);
            this.txtButtonLabel.Name = "txtButtonLabel";
            this.txtButtonLabel.Size = new System.Drawing.Size(100, 20);
            this.txtButtonLabel.TabIndex = 1;
            this.txtButtonLabel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(360, 250);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // chkButtonEnabled
            // 
            this.chkButtonEnabled.AutoSize = true;
            this.chkButtonEnabled.Location = new System.Drawing.Point(346, 209);
            this.chkButtonEnabled.Name = "chkButtonEnabled";
            this.chkButtonEnabled.Size = new System.Drawing.Size(80, 17);
            this.chkButtonEnabled.TabIndex = 3;
            this.chkButtonEnabled.Text = "checkBox1";
            this.chkButtonEnabled.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkButtonEnabled);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtButtonLabel);
            this.Controls.Add(this.lblZajecia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZajecia;
        private System.Windows.Forms.TextBox txtButtonLabel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkButtonEnabled;
    }
}

