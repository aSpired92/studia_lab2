namespace Zadanie1
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
            this.inputA = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(12, 12);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 20);
            this.inputA.TabIndex = 0;
            this.inputA.TextChanged += new System.EventHandler(this.inputA_TextChanged);
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(137, 12);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 20);
            this.inputB.TabIndex = 1;
            this.inputB.TextChanged += new System.EventHandler(this.inputB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // inputOutput
            // 
            this.inputOutput.Location = new System.Drawing.Point(268, 12);
            this.inputOutput.Name = "inputOutput";
            this.inputOutput.ReadOnly = true;
            this.inputOutput.Size = new System.Drawing.Size(100, 20);
            this.inputOutput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(240, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 43);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputOutput;
        private System.Windows.Forms.Button button1;
    }
}

