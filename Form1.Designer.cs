namespace Lab4VichMatka
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculateDerivativeButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.BestStep = new System.Windows.Forms.Label();
            this.CalculateDerivativeFloatButton = new System.Windows.Forms.Button();
            this.CalculateDerivativeDecimalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CalculateDerivativeButton
            // 
            this.CalculateDerivativeButton.Location = new System.Drawing.Point(763, 30);
            this.CalculateDerivativeButton.Name = "CalculateDerivativeButton";
            this.CalculateDerivativeButton.Size = new System.Drawing.Size(326, 23);
            this.CalculateDerivativeButton.TabIndex = 0;
            this.CalculateDerivativeButton.Text = "Посчитать производную (double)";
            this.CalculateDerivativeButton.UseVisualStyleBackColor = true;
            this.CalculateDerivativeButton.Click += new System.EventHandler(this.CalculateDerivativeButton_Click);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(12, 30);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(33, 16);
            this.OutputLabel.TabIndex = 1;
            this.OutputLabel.Text = "Text";
            // 
            // BestStep
            // 
            this.BestStep.AutoSize = true;
            this.BestStep.Location = new System.Drawing.Point(819, 153);
            this.BestStep.Name = "BestStep";
            this.BestStep.Size = new System.Drawing.Size(33, 16);
            this.BestStep.TabIndex = 2;
            this.BestStep.Text = "Text";
            // 
            // CalculateDerivativeFloatButton
            // 
            this.CalculateDerivativeFloatButton.Location = new System.Drawing.Point(763, 68);
            this.CalculateDerivativeFloatButton.Name = "CalculateDerivativeFloatButton";
            this.CalculateDerivativeFloatButton.Size = new System.Drawing.Size(326, 23);
            this.CalculateDerivativeFloatButton.TabIndex = 3;
            this.CalculateDerivativeFloatButton.Text = "Посчитать производную (float)";
            this.CalculateDerivativeFloatButton.UseVisualStyleBackColor = true;
            this.CalculateDerivativeFloatButton.Click += new System.EventHandler(this.CalculateDerivativeFloatButton_Click);
            // 
            // CalculateDerivativeDecimalButton
            // 
            this.CalculateDerivativeDecimalButton.Location = new System.Drawing.Point(763, 108);
            this.CalculateDerivativeDecimalButton.Name = "CalculateDerivativeDecimalButton";
            this.CalculateDerivativeDecimalButton.Size = new System.Drawing.Size(326, 23);
            this.CalculateDerivativeDecimalButton.TabIndex = 4;
            this.CalculateDerivativeDecimalButton.Text = "Посчитать производную (decimal)";
            this.CalculateDerivativeDecimalButton.UseVisualStyleBackColor = true;
            this.CalculateDerivativeDecimalButton.Click += new System.EventHandler(this.CalculateDerivativeDecimalButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 619);
            this.Controls.Add(this.CalculateDerivativeDecimalButton);
            this.Controls.Add(this.CalculateDerivativeFloatButton);
            this.Controls.Add(this.BestStep);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CalculateDerivativeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateDerivativeButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Label BestStep;
        private System.Windows.Forms.Button CalculateDerivativeFloatButton;
        private System.Windows.Forms.Button CalculateDerivativeDecimalButton;
    }
}

