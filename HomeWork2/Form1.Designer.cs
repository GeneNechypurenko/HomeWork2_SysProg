namespace HomeWork2
{
    partial class Form1
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
            primeGroupBox = new GroupBox();
            maxPrimeNumeric = new NumericUpDown();
            minPrimeNumeric = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            outputPrimeListbox = new ListBox();
            generateButton = new Button();
            outputFiboListBox = new ListBox();
            fiboGroupBox = new GroupBox();
            maxFiboNumeric = new NumericUpDown();
            minFiboNumeric = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            stopPrimeButton = new Button();
            stopFiboButton = new Button();
            pausePrimeButton = new Button();
            pauseFiboButton = new Button();
            resumePrimeButton = new Button();
            resumeFiboButton = new Button();
            primeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxPrimeNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minPrimeNumeric).BeginInit();
            fiboGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)maxFiboNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minFiboNumeric).BeginInit();
            SuspendLayout();
            // 
            // primeGroupBox
            // 
            primeGroupBox.Controls.Add(maxPrimeNumeric);
            primeGroupBox.Controls.Add(minPrimeNumeric);
            primeGroupBox.Controls.Add(label2);
            primeGroupBox.Controls.Add(label1);
            primeGroupBox.Location = new Point(12, 12);
            primeGroupBox.Name = "primeGroupBox";
            primeGroupBox.Size = new Size(180, 112);
            primeGroupBox.TabIndex = 0;
            primeGroupBox.TabStop = false;
            primeGroupBox.Text = "Prime Numbers";
            // 
            // maxPrimeNumeric
            // 
            maxPrimeNumeric.Location = new Point(51, 70);
            maxPrimeNumeric.Name = "maxPrimeNumeric";
            maxPrimeNumeric.Size = new Size(123, 27);
            maxPrimeNumeric.TabIndex = 3;
            // 
            // minPrimeNumeric
            // 
            minPrimeNumeric.Location = new Point(51, 26);
            minPrimeNumeric.Name = "minPrimeNumeric";
            minPrimeNumeric.Size = new Size(123, 27);
            minPrimeNumeric.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 72);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 1;
            label2.Text = "max:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "min:";
            // 
            // outputPrimeListbox
            // 
            outputPrimeListbox.FormattingEnabled = true;
            outputPrimeListbox.Location = new Point(12, 130);
            outputPrimeListbox.Name = "outputPrimeListbox";
            outputPrimeListbox.Size = new Size(180, 204);
            outputPrimeListbox.TabIndex = 1;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(12, 340);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(366, 29);
            generateButton.TabIndex = 2;
            generateButton.Text = "GENERATE";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // outputFiboListBox
            // 
            outputFiboListBox.FormattingEnabled = true;
            outputFiboListBox.Location = new Point(198, 130);
            outputFiboListBox.Name = "outputFiboListBox";
            outputFiboListBox.Size = new Size(180, 204);
            outputFiboListBox.TabIndex = 4;
            // 
            // fiboGroupBox
            // 
            fiboGroupBox.Controls.Add(maxFiboNumeric);
            fiboGroupBox.Controls.Add(minFiboNumeric);
            fiboGroupBox.Controls.Add(label3);
            fiboGroupBox.Controls.Add(label4);
            fiboGroupBox.Location = new Point(198, 12);
            fiboGroupBox.Name = "fiboGroupBox";
            fiboGroupBox.Size = new Size(180, 112);
            fiboGroupBox.TabIndex = 3;
            fiboGroupBox.TabStop = false;
            fiboGroupBox.Text = "Fibonnachi Numbers";
            // 
            // maxFiboNumeric
            // 
            maxFiboNumeric.Location = new Point(51, 70);
            maxFiboNumeric.Name = "maxFiboNumeric";
            maxFiboNumeric.Size = new Size(123, 27);
            maxFiboNumeric.TabIndex = 3;
            // 
            // minFiboNumeric
            // 
            minFiboNumeric.Location = new Point(51, 26);
            minFiboNumeric.Name = "minFiboNumeric";
            minFiboNumeric.Size = new Size(123, 27);
            minFiboNumeric.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 72);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "max:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 0;
            label4.Text = "min:";
            // 
            // stopPrimeButton
            // 
            stopPrimeButton.Location = new Point(12, 375);
            stopPrimeButton.Name = "stopPrimeButton";
            stopPrimeButton.Size = new Size(180, 29);
            stopPrimeButton.TabIndex = 5;
            stopPrimeButton.Text = "STOP STREAM";
            stopPrimeButton.UseVisualStyleBackColor = true;
            stopPrimeButton.Click += stopPrimeButton_Click;
            // 
            // stopFiboButton
            // 
            stopFiboButton.Location = new Point(198, 375);
            stopFiboButton.Name = "stopFiboButton";
            stopFiboButton.Size = new Size(180, 29);
            stopFiboButton.TabIndex = 6;
            stopFiboButton.Text = "STOP STREAM";
            stopFiboButton.UseVisualStyleBackColor = true;
            stopFiboButton.Click += stopFiboButton_Click;
            // 
            // pausePrimeButton
            // 
            pausePrimeButton.Location = new Point(12, 410);
            pausePrimeButton.Name = "pausePrimeButton";
            pausePrimeButton.Size = new Size(180, 29);
            pausePrimeButton.TabIndex = 7;
            pausePrimeButton.Text = "PAUSE STREAM";
            pausePrimeButton.UseVisualStyleBackColor = true;
            pausePrimeButton.Click += pausePrimeButton_Click;
            // 
            // pauseFiboButton
            // 
            pauseFiboButton.Location = new Point(198, 410);
            pauseFiboButton.Name = "pauseFiboButton";
            pauseFiboButton.Size = new Size(180, 29);
            pauseFiboButton.TabIndex = 8;
            pauseFiboButton.Text = "PAUSE STREAM";
            pauseFiboButton.UseVisualStyleBackColor = true;
            pauseFiboButton.Click += pauseFiboButton_Click;
            // 
            // resumePrimeButton
            // 
            resumePrimeButton.Location = new Point(12, 445);
            resumePrimeButton.Name = "resumePrimeButton";
            resumePrimeButton.Size = new Size(180, 29);
            resumePrimeButton.TabIndex = 9;
            resumePrimeButton.Text = "RESUME STREAM";
            resumePrimeButton.UseVisualStyleBackColor = true;
            resumePrimeButton.Click += resumePrimeButton_Click;
            // 
            // resumeFiboButton
            // 
            resumeFiboButton.Location = new Point(198, 445);
            resumeFiboButton.Name = "resumeFiboButton";
            resumeFiboButton.Size = new Size(180, 29);
            resumeFiboButton.TabIndex = 10;
            resumeFiboButton.Text = "RESUME STREAM";
            resumeFiboButton.UseVisualStyleBackColor = true;
            resumeFiboButton.Click += resumeFiboButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 488);
            Controls.Add(resumeFiboButton);
            Controls.Add(resumePrimeButton);
            Controls.Add(pauseFiboButton);
            Controls.Add(pausePrimeButton);
            Controls.Add(stopFiboButton);
            Controls.Add(stopPrimeButton);
            Controls.Add(outputFiboListBox);
            Controls.Add(fiboGroupBox);
            Controls.Add(generateButton);
            Controls.Add(outputPrimeListbox);
            Controls.Add(primeGroupBox);
            Name = "Form1";
            Text = "Form1";
            primeGroupBox.ResumeLayout(false);
            primeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxPrimeNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minPrimeNumeric).EndInit();
            fiboGroupBox.ResumeLayout(false);
            fiboGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)maxFiboNumeric).EndInit();
            ((System.ComponentModel.ISupportInitialize)minFiboNumeric).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox primeGroupBox;
        private NumericUpDown maxPrimeNumeric;
        private NumericUpDown minPrimeNumeric;
        private Label label2;
        private Label label1;
        private ListBox outputPrimeListbox;
        private Button generateButton;
        private ListBox outputFiboListBox;
        private GroupBox fiboGroupBox;
        private NumericUpDown maxFiboNumeric;
        private NumericUpDown minFiboNumeric;
        private Label label3;
        private Label label4;
        private Button stopPrimeButton;
        private Button stopFiboButton;
        private Button pausePrimeButton;
        private Button pauseFiboButton;
        private Button resumePrimeButton;
        private Button resumeFiboButton;
    }
}
