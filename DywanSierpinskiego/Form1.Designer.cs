namespace DywanSierpinskiego
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
            this.carpetCanvas = new System.Windows.Forms.Panel();
            this.createButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stepsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.colorSelectButton = new System.Windows.Forms.Button();
            this.multiColorCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // carpetCanvas
            // 
            this.carpetCanvas.Location = new System.Drawing.Point(1, 3);
            this.carpetCanvas.Name = "carpetCanvas";
            this.carpetCanvas.Size = new System.Drawing.Size(500, 500);
            this.carpetCanvas.TabIndex = 0;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(513, 469);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(84, 23);
            this.createButton.TabIndex = 1;
            this.createButton.Text = "Stwórz dywan";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liczba kroków:";
            // 
            // stepsTextBox
            // 
            this.stepsTextBox.Location = new System.Drawing.Point(516, 29);
            this.stepsTextBox.Name = "stepsTextBox";
            this.stepsTextBox.Size = new System.Drawing.Size(81, 20);
            this.stepsTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolor:";
            // 
            // colorSelectButton
            // 
            this.colorSelectButton.Location = new System.Drawing.Point(516, 68);
            this.colorSelectButton.Name = "colorSelectButton";
            this.colorSelectButton.Size = new System.Drawing.Size(81, 23);
            this.colorSelectButton.TabIndex = 5;
            this.colorSelectButton.Text = "Wybierz";
            this.colorSelectButton.UseVisualStyleBackColor = true;
            this.colorSelectButton.Click += new System.EventHandler(this.colorSelectButton_Click);
            // 
            // multiColorCheckBox
            // 
            this.multiColorCheckBox.AutoSize = true;
            this.multiColorCheckBox.Location = new System.Drawing.Point(517, 97);
            this.multiColorCheckBox.Name = "multiColorCheckBox";
            this.multiColorCheckBox.Size = new System.Drawing.Size(90, 17);
            this.multiColorCheckBox.TabIndex = 6;
            this.multiColorCheckBox.Text = "Wielobarwnie";
            this.multiColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 504);
            this.Controls.Add(this.multiColorCheckBox);
            this.Controls.Add(this.colorSelectButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stepsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.carpetCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Dywan Sierpińskiego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel carpetCanvas;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stepsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button colorSelectButton;
        private System.Windows.Forms.CheckBox multiColorCheckBox;
    }
}

