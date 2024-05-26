namespace Zadanie3
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
            this.labelCPUUsage = new System.Windows.Forms.Label();
            this.labelRAMAvaiable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCPUUsage
            // 
            this.labelCPUUsage.AutoSize = true;
            this.labelCPUUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCPUUsage.Location = new System.Drawing.Point(12, 9);
            this.labelCPUUsage.Name = "labelCPUUsage";
            this.labelCPUUsage.Size = new System.Drawing.Size(124, 20);
            this.labelCPUUsage.TabIndex = 0;
            this.labelCPUUsage.Text = "CPU Usage: 0%";
            // 
            // labelRAMAvaiable
            // 
            this.labelRAMAvaiable.AutoSize = true;
            this.labelRAMAvaiable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRAMAvaiable.Location = new System.Drawing.Point(12, 39);
            this.labelRAMAvaiable.Name = "labelRAMAvaiable";
            this.labelRAMAvaiable.Size = new System.Drawing.Size(150, 20);
            this.labelRAMAvaiable.TabIndex = 1;
            this.labelRAMAvaiable.Text = "RAM Avaiable: 0MB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 84);
            this.Controls.Add(this.labelRAMAvaiable);
            this.Controls.Add(this.labelCPUUsage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCPUUsage;
        private System.Windows.Forms.Label labelRAMAvaiable;
    }
}

