namespace Zadanie2
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
            this.inputOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(12, 11);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(100, 20);
            this.inputA.TabIndex = 0;
            this.inputA.TextChanged += new System.EventHandler(this.inputA_TextChanged);
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(152, 11);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(100, 20);
            this.inputB.TabIndex = 1;
            this.inputB.TextChanged += new System.EventHandler(this.inputB_TextChanged);
            // 
            // inputOutput
            // 
            this.inputOutput.Location = new System.Drawing.Point(283, 11);
            this.inputOutput.Name = "inputOutput";
            this.inputOutput.ReadOnly = true;
            this.inputOutput.Size = new System.Drawing.Size(100, 20);
            this.inputOutput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(255, 8);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxOperation.Location = new System.Drawing.Point(115, 9);
            this.comboBoxOperation.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(34, 24);
            this.comboBoxOperation.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 43);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputOutput);
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
        private System.Windows.Forms.TextBox inputOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxOperation;


    }
}

